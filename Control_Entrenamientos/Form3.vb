Imports System.ComponentModel
Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.IO

Module ListaEntrenados
    Public NombreEntrenado As String = ""
    Public IdEntrenado As Integer
    Public CalificacionEntrenador As Integer = 0
    Public CalificacionEntrenado As String = ""
    Public Cancelar As Boolean = False
    Public Enroll As Boolean = False
End Module

Public Class form3
    Implements EventHandler
    Private Captura As Capture
    Private Template As Template
    Private Verificador As Verification.Verification
    Private Delegate Sub _delegateTxtBxEntrenado()
    Private Delegate Sub _CerrarForm()

    Dim conn As New MySqlConnection
    Private Sub connect()
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("cs").ConnectionString
        Try
            conn.Open()
            Console.WriteLine("conectandose a la base de datos")
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            Exit Sub
        End Try
        conn.Close()
    End Sub

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                Verificador = New Verification.Verification
                Template = New Template()
            Else
                MsgBox("No se puede instanciar la captura de huella")
            End If
        Catch ex As Exception
            MsgBox("No se puede instanciar la captura de huella" & vbCrLf & ex.Message)
        End Try
    End Sub

    Protected Sub Iniciar_Captura()
        If Not Captura Is Nothing Then
            Try
                Captura.StartCapture()
            Catch ex As Exception
                MsgBox("No se puede iniciar la captura de la huella" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Protected Sub Parar_Captura()
        If Not Captura Is Nothing Then
            Try
                Captura.StopCapture()
            Catch ex As Exception
                MsgBox("No se puede detener la captura de la huella" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Protected Function ConvertirHuellaaMapadeBits(ByVal Sample As Sample) As Bitmap
        Dim Convertor As New SampleConversion() 'Es una variable de tipo convertor de un DPFP.Sample
        Dim MapaBits As Bitmap = Nothing
        Convertor.ConvertToPicture(Sample, MapaBits)
        Return MapaBits
    End Function

    Private Sub LlenarPictureBoxHuella(ByVal bmp)
        ImagenHuellaEntrenado.Image = bmp
    End Sub

    Protected Function ExtraerCaracteristicasHuellas(ByVal Sample As Sample, ByVal Purpose As Processing.DataPurpose) As FeatureSet
        Dim Extractor As New Processing.FeatureExtraction
        Dim Alimentacion As CaptureFeedback = CaptureFeedback.None
        Dim Caracteristicas As New FeatureSet()
        Extractor.CreateFeatureSet(Sample, Purpose, Alimentacion, Caracteristicas)
        If Alimentacion = DPFP.Capture.CaptureFeedback.Good Then
            Return Caracteristicas
        Else
            Return Nothing
        End If
    End Function


    Dim nombre As String = ""
    Dim Id As Integer
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        LlenarPictureBoxHuella(ConvertirHuellaaMapadeBits(Sample))
        Dim Caracteristicas As FeatureSet = ExtraerCaracteristicasHuellas(Sample, Processing.DataPurpose.Verification)
        If Not Caracteristicas Is Nothing Then
            Dim result As New Verification.Verification.Result
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(String.Format("SELECT * from usuarios"), conn)
                Dim read As MySqlDataReader
                read = cmd.ExecuteReader()
                Dim verificado As Boolean = False
                Dim iteracion As Integer = 1
                While read.Read
                    Try
                        Dim Memoria As New MemoryStream(CType(read("Huella"), Byte()))
                        Template.DeSerialize(Memoria.ToArray)
                        Verificador.Verify(Caracteristicas, Template, result)
                        If result.Verified Then
                            nombre = read("Nombre")
                            Id = read("UsuarioID")
                            verificado = True
                            Exit While
                        End If
                    Catch ex As Exception

                    End Try
                End While
                If verificado = False Then
                    If MessageBox.Show("No se encontro registro del usuario en el base de datos" & vbCrLf & "¿Desea agregar este usuario a la base de datos?" & vbCrLf & " (Si presiona NO podra reintentar colocar la huella en el lector y realizar la busqueda nuevamente)", "Info.", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Parar_Captura()
                        Enroll = True
                        Dim deleg2 As New _CerrarForm(AddressOf CerrarForm)
                        Me.Invoke(deleg2)
                    End If
                Else
                    Dim deleg As New _delegateTxtBxEntrenado(AddressOf EscribirEntrenado)
                    Me.Invoke(deleg) 'Si quiero cambiar un label o textbox en la form debo implementar el uso de delegados
                End If
                read.Close()
                conn.Close()
                read.Dispose()
                conn.Dispose()
            Catch ex As Exception
                MsgBox("No se logro conectar a la base de datos:" & vbCrLf & ex.Message)
                Dim deleg2 As New _CerrarForm(AddressOf CerrarForm)
                Me.Invoke(deleg2)
            End Try
        End If
    End Sub

    Private Sub CerrarForm()
        Parar_Captura()
        conn.Close()
        conn.Dispose()
        Me.Close()
    End Sub

    Private Sub EscribirEntrenado()
        NombreEntrenado = nombre
        IdEntrenado = Id
        Parar_Captura()
        conn.Close()
        conn.Dispose()
        Me.Close()
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Parar_Captura()
        connect()
        Init()
        Iniciar_Captura()
    End Sub

    Private Sub form3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If NombreEntrenado = "" Then
            If Enroll Then
                Parar_Captura()
                Exit Sub
            End If
            If MessageBox.Show("¿Esta seguro que desea salir?", "Info.", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
            Else
                Cancelar = True
                Parar_Captura()
            End If
        End If

    End Sub
End Class