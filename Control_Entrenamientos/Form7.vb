Imports DPFP
Imports DPFP.Capture
Imports System.Text
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form7
    Implements EventHandler

    Private Captura As Capture
    Private Enroller As Processing.Enrollment
    Private Delegate Sub _delegadoMuestra(ByVal text As String)
    Private Delegate Sub _delegadoControles()
    Private Template As Template

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

    Private Sub ActivarControles()
        If BtnGuardar.InvokeRequired Then
            Dim Deleg As New _delegadoControles(AddressOf ActivarControles)
            Me.Invoke(Deleg)
        Else
            Parar_Captura()
            BtnGuardar.Enabled = True
            TxtBxNombre.Enabled = True
        End If
    End Sub

    Private Sub MostrarVeces(ByVal Texto As String)
        If LblHuella.InvokeRequired Then
            Dim Deleg As New _delegadoMuestra(AddressOf MostrarVeces)
            Me.Invoke(Deleg, New Object() {Texto})
        Else
            LblHuella.Text = Texto
        End If
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Init()
        Iniciar_Captura()
    End Sub

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
                Enroller = New Processing.Enrollment()
                Dim text As New StringBuilder()
                text.AppendFormat("Necesitar colocar el dedo {0} veces", Enroller.FeaturesNeeded)
                LblHuella.Text = text.ToString
            Else
                MsgBox("No se puede instanciar la captura de huella")
            End If
        Catch ex As Exception
            MsgBox("No se pede instanciar la captura de huella" & vbCrLf & ex.Message)
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

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        LlenarPictureBoxHuella(ConvertirHuellaaMapadeBits(Sample))
        Procesar(Sample)
    End Sub

    Private Sub Form7_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Parar_Captura()
    End Sub

    Protected Function ConvertirHuellaaMapadeBits(ByVal Sample As Sample) As Bitmap
        Dim Convertor As New SampleConversion() 'Es una variable de tipo convertor de un DPFP.Sample
        Dim MapaBits As Bitmap = Nothing
        Convertor.ConvertToPicture(Sample, MapaBits)
        Return MapaBits
    End Function

    Private Sub LlenarPictureBoxHuella(ByVal bmp)
        ImagenHuella.Image = bmp
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

    Protected Sub Procesar(ByVal Sample As Sample)
        Dim Caracteristicas As FeatureSet = ExtraerCaracteristicasHuellas(Sample, Processing.DataPurpose.Enrollment)
        If Not Caracteristicas Is Nothing Then
            Try
                Enroller.AddFeatures(Caracteristicas)
            Finally
                Dim text As New StringBuilder()
                text.AppendFormat("Necesitar colocar el dedo {0} veces", Enroller.FeaturesNeeded)
                MostrarVeces(text.ToString)
                Select Case Enroller.TemplateStatus
                    Case Processing.Enrollment.Status.Ready
                        Template = Enroller.Template
                        ActivarControles()
                    Case Processing.Enrollment.Status.Failed
                        Enroller.Clear()
                        Parar_Captura()
                        MsgBox("La captura de la huella fallo por favor intentelo nuevamente")
                        Iniciar_Captura()
                End Select
            End Try
        End If
    End Sub

    Dim Enrolled As Boolean = False

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtBxNombre.Text.Trim.Equals("") Then
            MsgBox("Ingrese el nombre de la persona")
            Exit Sub
        Else
            Try
                conn.Open()
                Dim cmd2 As New MySqlCommand("select max(usuarioID + 1) from usuarios;", conn)
                Dim id As String = cmd2.ExecuteScalar
                Dim query As String = "INSERT INTO usuarios(UsuarioID, Nombre, Huella, Activo, PedirHuella) values (?, ?, ?, ?, ?);"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("UsuarioID", id)
                cmd.Parameters.AddWithValue("Nombre", TxtBxNombre.Text)
                Using fm As New MemoryStream(Template.Bytes)
                    cmd.Parameters.AddWithValue("Huella", fm.ToArray())
                End Using
                cmd.Parameters.AddWithValue("Activo", CBActivo.Checked)
                cmd.Parameters.AddWithValue("PedirHuella", False)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Informacion de Usuario Agregada", MsgBoxStyle.Information, "Info.")
                Enrolled = True
                conn.Close()
                conn.Dispose()
                BtnGuardar.Enabled = False
                TxtBxNombre.Clear()
                TxtBxNombre.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error.")
                conn.Close()
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub Form7_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If Enrolled Then
            Parar_Captura()
        End If
        MsgBox("Termine con el registro antes de continuar.", MsgBoxStyle.Exclamation, "Error.")
    End Sub

    Private Sub Form7_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Parar_Captura()
        Init()
        Iniciar_Captura()
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
End Class