Imports System.Net
Imports System.IO
Public Class Download
    Public url As String
    Public filename As String
    Public filesize As Long
    Public downloaded As Long
    Public Saveto As String
    Public bytes As Byte()
    Public tillnow As Long
    Public OURdIRECTORY As String = Download_Info.folder & "\" & "Unique Downloader"
    Public Downloader As New Downloader
    Public Folder As String = Download_Info.folder
    Private Sub Download_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim p As Process = Process.GetCurrentProcess
        p.Kill()
    End Sub
    Private Sub Download_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Download()
    End Sub
    Public Sub Download()
        Try
            url = Download_Info.URL
            Link.Text = url
            filesize = Download_Info.filesize
            filelength.Text = "File size  " & sizestring(filesize)
            Saveto = Download_Info.folder & "\" & Download_Info.fileName
            Dim FILENAME As String = Download_Info.fileName
            target.Text = "Target  " & Saveto
            Dim uniquename As String
            If FILENAME.Contains(".") Then
                uniquename = FILENAME.Split(".")(0)
            Else
                uniquename = FILENAME
            End If
            If IO.File.Exists(Saveto) Then
                If IO.File.ReadAllBytes(Saveto).LongLength >= filesize Then
                    Dim result = MsgBox("File already exists and has been downloaded completly", MsgBoxStyle.OkOnly)
                    If result = MsgBoxResult.Ok Then
                        Dim p = Process.GetCurrentProcess
                        p.Kill()
                    End If
                End If
            End If
            If IO.Directory.Exists(OURdIRECTORY) Then
                If IO.Directory.Exists(OURdIRECTORY & "\" & uniquename) Then
                    Downloader.manageit(url, OURdIRECTORY & "\" & uniquename, FILENAME, filesize, Saveto, True)
                Else
                    GoTo 1
                End If
            Else
                IO.Directory.CreateDirectory(OURdIRECTORY)
1:              IO.Directory.CreateDirectory(OURdIRECTORY & "\" & uniquename)
                Downloader.manageit(url, OURdIRECTORY & "\" & uniquename, FILENAME, filesize, Saveto, False)
            End If
        Catch ex As Exception
            Dim result = MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            If result = MsgBoxResult.Ok Then
                Dim P As Process
                P = Process.GetCurrentProcess
                P.Kill()
            End If
        End Try
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Downloader.Wholedownloaded = Downloader.Downloadedpart1 + Downloader.downloadedpart2 + Downloader.Downloadedpart3 + Downloader.Downloadedpart4 + Downloader.Downloadedpart5
            Downloader.WholePercentage = (Downloader.Wholedownloaded / filesize) * 100
            If Downloader.Wholedownloaded >= filesize Then
                Downloader.Finish = True
                Downloader.WholeStatus = "Completed"
                downloadedbytes.Text = "Downloaded  " & sizestring(Downloader.Wholedownloaded)
                Label1.Text = "State  " & Downloader.WholeStatus
                ProgressBar1.Maximum = 100
                ProgressBar1.Value = Downloader.WholePercentage
                percentage.Text = "Percentage  " & Downloader.WholePercentage.ToString & " %"
                Dim bytes() As Byte = IO.File.ReadAllBytes(Downloader.Uniquepath1)
                Dim filestream As New FileStream(Downloader.FilePath, IO.FileMode.OpenOrCreate)
                filestream.Position = filestream.Length
                filestream.Write(bytes, 0, bytes.Length)
                filestream.Flush()
                filestream.Dispose()
                IO.File.Delete(Downloader.Uniquepath1)
                bytes = IO.File.ReadAllBytes(Downloader.Uniquepath2)
                filestream = New FileStream(Downloader.FilePath, IO.FileMode.OpenOrCreate)
                filestream.Position = filestream.Length
                filestream.Write(bytes, 0, bytes.Length)
                filestream.Flush()
                filestream.Dispose()
                IO.File.Delete(Downloader.Uniquepath2)
                bytes = IO.File.ReadAllBytes(Downloader.Uniquepath3)
                filestream = New FileStream(Downloader.FilePath, IO.FileMode.OpenOrCreate)
                filestream.Position = filestream.Length
                filestream.Write(bytes, 0, bytes.Length)
                filestream.Flush()
                filestream.Dispose()
                IO.File.Delete(Downloader.Uniquepath3)
                bytes = IO.File.ReadAllBytes(Downloader.Uniquepath4)
                filestream = New FileStream(Downloader.FilePath, IO.FileMode.OpenOrCreate)
                filestream.Position = filestream.Length
                filestream.Write(bytes, 0, bytes.Length)
                filestream.Flush()
                filestream.Dispose()
                IO.File.Delete(Downloader.Uniquepath4)
                bytes = IO.File.ReadAllBytes(Downloader.Uniquepath5)
                filestream = New FileStream(Downloader.FilePath, IO.FileMode.OpenOrCreate)
                filestream.Position = filestream.Length
                filestream.Write(bytes, 0, bytes.Length)
                filestream.Flush()
                filestream.Dispose()
                IO.File.Delete(Downloader.Uniquepath5)
                IO.File.Delete(Downloader.Uniquedir & "\Info.txt")
                IO.Directory.Delete(Downloader.Uniquedir)
                If IO.Directory.GetFiles(OURdIRECTORY).Length > 0 Then
                Else
                    IO.Directory.Delete(OURdIRECTORY)
                End If
                Timer1.Stop()
            Else
                Downloader.WholeStatus = "Downloading...."
                downloadedbytes.Text = "Downloaded  " & sizestring(Downloader.Wholedownloaded)
                Label1.Text = "State  " & Downloader.WholeStatus
                ProgressBar1.Value = Downloader.WholePercentage
                percentage.Text = "Percentage  " & Downloader.WholePercentage.ToString & " %"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Show Details" Then
            Button3.Text = "Hide Details"
            Me.Size = New Point(729, 532)
        ElseIf Button3.Text = "Hide Details" Then
            Button3.Text = "Show Details"
            Me.Size = New Point(729, 364)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim P As Process
        P = Process.GetCurrentProcess
        P.Kill()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
                PB1.Value = Downloader.Percentage1
                Me.Downloadedpart1.Text = sizestring(Downloader.Downloadedpart1)
                Me.Percentage1.Text = Downloader.Percentage1 & " %"
            Me.Status1.Text = Downloader.Status1
            PB2.Value = Downloader.Percentage2
            Me.Downloadedpart2.Text = sizestring(Downloader.downloadedpart2)
            Me.Percentage2.Text = Downloader.Percentage2 & " %"
            Me.Status2.Text = Downloader.Status2
            PB3.Value = Downloader.Percentage3
            Me.downloadedpart3.Text = sizestring(Downloader.Downloadedpart3)
            Me.percentage3.Text = Downloader.Percentage3 & " %"
            Me.Status3.Text = Downloader.Status3
            PB4.Value = Downloader.Percentage4
            Me.downloadedpart4.Text = sizestring(Downloader.Downloadedpart4)
            Me.percentage4.Text = Downloader.Percentage4 & " %"
            Me.Status4.Text = Downloader.Status4
            PB5.Value = Downloader.Percentage5
            Me.downloadedpart5.Text = sizestring(Downloader.Downloadedpart5)
            Me.percentage5.Text = Downloader.Percentage5 & " %"
            Me.Status5.Text = Downloader.Status5
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Stop" Then
            Downloader.Work = False
            Button1.Text = "Resume"
        ElseIf Button1.Text = "Resume" Then
            Downloader.Work = True
            Button1.Text = "Stop"
        End If
    End Sub
End Class