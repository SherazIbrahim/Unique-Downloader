Imports System.Net
Public Class Download_Info
    Public filesize As Long
    Public URL As String
    Public fileName As String
    Public folder As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim P As Process
            P = Process.GetCurrentProcess
            P.Kill()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim result = FolderBrowserDialog1.ShowDialog
            If result = DialogResult.OK Then
                folder = FolderBrowserDialog1.SelectedPath
                TextBox2.Text = folder
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Download_Info_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim p As Process = Process.GetCurrentProcess
        p.Kill()
    End Sub

    Private Sub Download_Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            URL = Form1.TextBox1.Text
            TextBox1.Text = URL
            TextBox2.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(URL), HttpWebRequest)
            request.Proxy = Nothing
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            filesize = response.ContentLength
            Label4.Text = sizestring(filesize)
            fileName = IO.Path.GetFileName(My.Computer.FileSystem.GetName(URL))
            TextBox3.Text = fileName
        Catch ex As Exception
            Dim result = MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            If result = MsgBoxResult.Ok Then
                Dim P As Process
                P = Process.GetCurrentProcess
                P.Kill()
            End If
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text.Length > 0 AndAlso TextBox2.Text.Length > 0 AndAlso TextBox3.Text.Length > 0 Then
            fileName = TextBox3.Text
            folder = TextBox2.Text
            Download.Show()
            Me.Hide()
        Else
            MsgBox("Fill all Boxes")
        End If
    End Sub
    Public Function sizestring(ByVal length As Long) As String
        Dim modified As String = ""
        If length < 1024 Then
            modified = length.ToString & " B"
        ElseIf length < 1024 * 1024 Then
            Dim nw As Decimal = length / 1024
            If nw.ToString.Contains(".") Then
                Dim nw1() As String = nw.ToString.Split(".")
                If nw1(1).Length > 3 Then
                    Dim nww As String = nw1(1).Remove(3, nw1(1).Length - 4)
                    modified = nw1(0) & "." & nww & " KB"
                Else
                    modified = nw.ToString & " KB"
                End If
            Else
                modified = nw.ToString & " KB"
            End If
        ElseIf length < 1024 * 1024 * 1024 Then
            Dim nw As Decimal = length / 1024 / 1024
            If nw.ToString.Contains(".") Then
                Dim nw1() As String = nw.ToString.Split(".")
                If nw1(1).Length > 3 Then
                    Dim nww As String = nw1(1).Remove(3, nw1(1).Length - 4)
                    modified = nw1(0) & "." & nww & " MB"
                Else
                    modified = nw.ToString & " MB"
                End If
            Else
                modified = nw.ToString & " MB"
            End If
        Else
            Dim nw As Decimal = length / 1024 / 1024 / 1024
            If nw.ToString.Contains(".") Then
                Dim nw1() As String = nw.ToString.Split(".")
                If nw1(1).Length > 3 Then
                    Dim nww As String = nw1(1).Remove(3, nw1(1).Length - 4)
                    modified = nw1(0) & "." & nww & " GB"
                Else
                    modified = nw.ToString & " GB"
                End If
            Else
                modified = nw.ToString & " GB"
            End If
        End If
        sizestring = modified
    End Function
End Class