Imports System.ComponentModel

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterControls()
    End Sub

    Private Sub CenterControls()
        Label1.Left = (Me.ClientSize.Width / 2) - (Label1.Width / 2)
        RadioButton1.Left = (Me.ClientSize.Width / 2) - (RadioButton1.Width / 2)
        RadioButton2.Left = (Me.ClientSize.Width / 2) - (RadioButton1.Width / 2)
        RadioButton3.Left = (Me.ClientSize.Width / 2) - (RadioButton1.Width / 2)
        RadioButton4.Left = (Me.ClientSize.Width / 2) - (RadioButton1.Width / 2)
        RadioButton5.Left = (Me.ClientSize.Width / 2) - (RadioButton1.Width / 2)
        BtnAceptar.Left = (Me.ClientSize.Width / 2) - (BtnAceptar.Width / 2)
    End Sub

    Private Sub Form4_Resize(ByVal sender As Object,
                     ByVal e As System.EventArgs) Handles MyBase.Resize
        CenterControls()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If RadioButton1.Checked Then
            CalificacionEntrenador = 1
        ElseIf RadioButton2.Checked Then
            CalificacionEntrenador = 2
        ElseIf RadioButton3.Checked Then
            CalificacionEntrenador = 3
        ElseIf RadioButton4.Checked Then
            CalificacionEntrenador = 4
        ElseIf RadioButton5.Checked Then
            CalificacionEntrenador = 5
        End If
        Me.Close()
    End Sub

    Private Sub Form4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If CalificacionEntrenador = 0 Then
            MsgBox("Califique a su entrenador antes de continuar.", MsgBoxStyle.Information, "Info.")
            e.Cancel = True
            Exit Sub
        End If
    End Sub
End Class