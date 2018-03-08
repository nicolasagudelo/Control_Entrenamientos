Imports System.ComponentModel

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterControls()
    End Sub
    Private Sub CenterControls()
        Label1.Text = "Por favor indique si " & NombreEntrenado & " supero satisfactoriamente el entrenamiento"
        Label1.AutoSize = True
        Label1.Left = (Me.ClientSize.Width / 2) - (Label1.Width / 2)
        RadioButton1.Left = (Me.ClientSize.Width / 2) - (RadioButton1.Width / 2)
        RadioButton2.Left = (Me.ClientSize.Width / 2) - (RadioButton1.Width / 2)
        BtnAceptar.Left = (Me.ClientSize.Width / 2) - (BtnAceptar.Width / 2)
    End Sub
    Private Sub Form5_Resize(ByVal sender As Object,
                     ByVal e As System.EventArgs) Handles MyBase.Resize
        CenterControls()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If RadioButton1.Checked Then
            CalificacionEntrenado = "SI"
        ElseIf RadioButton2.Checked Then
            CalificacionEntrenado = "NO"
        End If
        Me.Close()
    End Sub

    Private Sub Form5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If CalificacionEntrenado = "" Then
            MsgBox("Califique al entrenado para continuar.", MsgBoxStyle.Information, "Info.")
            e.Cancel = True
            Exit Sub
        End If
    End Sub
End Class