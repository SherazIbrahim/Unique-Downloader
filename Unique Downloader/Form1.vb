Imports System.Net
Imports System.IO
Public Class Form1
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If TextBox1.Text.Length > 0 Then
                Download_Info.Show()
                Me.Hide()
            Else
                MsgBox("Fill the box")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
