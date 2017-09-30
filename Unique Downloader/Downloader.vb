Imports System.Net
Imports System.IO
Public Class Downloader
    Public Thread1 As Threading.Thread
    Public Thread2 As Threading.Thread
    Public Thread3 As Threading.Thread
    Public Thread4 As Threading.Thread
    Public Thread5 As Threading.Thread
    Public Downloadedpart1 As Long = 0
    Public downloadedpart2 As Long = 0
    Public Downloadedpart3 As Long = 0
    Public Downloadedpart4 As Long = 0
    Public Downloadedpart5 As Long = 0
    Public Wholedownloaded As Long = 0
    Public Downloadedleft As Long = 0
    Public Status1 As String
    Public Status2 As String
    Public Status3 As String
    Public Status4 As String
    Public Status5 As String
    Public Percentage1 As Integer = 0
    Public Percentage2 As Integer = 0
    Public Percentage3 As Integer = 0
    Public Percentage4 As Integer = 0
    Public Percentage5 As Integer = 0
    Public WholePercentage As Integer = 0
    Public WholeStatus As String
    Public othersize As Long
    Public Lastsize As Long
    Public Speed As Long
    Public Timeleft As Long
    Public Display As Boolean = False
    Public Uniquepath1 As String
    Public Uniquepath2 As String
    Public Uniquepath3 As String
    Public Uniquepath4 As String
    Public Uniquepath5 As String
    Public Uniquedir As String
    Public FilePath As String
    Public Url As String
    Public Work As Boolean = True
    Public Finish As Boolean = False
    Public Sub ManageSize(ByVal Length As Long)
        Dim modified As String = ""
        Dim divided As Long = Length / 5
        Dim Fst5 As Long = divided + divided + divided + divided
        Dim last As Long = Length - Fst5
        othersize = divided
        Lastsize = last
    End Sub
    Public Sub manageit(ByVal URL As String, ByVal uniquedirectory As String, ByVal filename As String, ByVal filesize As Long, ByVal filepath As String, ByVal Existedb4 As Boolean)
        Try
            Uniquepath1 = uniquedirectory & "\1.ud"
            Uniquepath2 = uniquedirectory & "\2.ud"
            Uniquepath3 = uniquedirectory & "\3.ud"
            Uniquepath4 = uniquedirectory & "\4.ud"
            Uniquepath5 = uniquedirectory & "\5.ud"
            Uniquedir = uniquedirectory
            Me.FilePath = filepath
            ManageSize(filesize)
            Me.Url = URL
            If Existedb4 Then
                Dim files As String = ""
                For Each Fil In IO.Directory.GetFiles(uniquedirectory)
                    files = files & My.Computer.FileSystem.GetName(Fil.ToString)
                Next
                If files.Contains("1.ud") And files.Contains("2.ud") And files.Contains("3.ud") And files.Contains("4.ud") And files.Contains("5.ud") And files.Contains("Info.txt") Then
                    DownloadPart1()
                    DownloadPart2()
                    DownloadPart3()
                    DownloadPart4()
                    DownloadPart5()
                Else
                    For Each Fil In IO.Directory.GetFiles(uniquedirectory)
                        IO.File.Delete(Fil)
                        IO.File.WriteAllText(uniquedirectory & "\Info.txt", filepath)
                        For i = 1 To 5
                            Dim Filestream As New FileStream(uniquedirectory & "\" & i.ToString & ".ud", IO.FileMode.CreateNew)
                            Filestream.Flush()
                            Filestream.Dispose()
                        Next
                        DownloadPart1()
                        DownloadPart2()
                        DownloadPart3()
                        DownloadPart4()
                        DownloadPart5()
                    Next
                End If
            Else
                IO.File.WriteAllText(uniquedirectory & "\Info.txt", filepath)
                For i = 1 To 5
                    Dim Filestream As New FileStream(uniquedirectory & "\" & i.ToString & ".ud", IO.FileMode.CreateNew)
                    Filestream.Flush()
                    Filestream.Dispose()
                Next
                DownloadPart1()
                DownloadPart2()
                DownloadPart3()
                DownloadPart4()
                DownloadPart5()
            End If
            Download.Timer1.Start()
        Catch ex As Exception
            Dim result = MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            If result = MsgBoxResult.Ok Then
                Dim P As Process
                P = Process.GetCurrentProcess
                P.Kill()
            End If
        End Try
    End Sub
    Public Sub DownloadPart5()
        Thread5 = New Threading.Thread(Sub()
                                           Try
1:
                                               If Finish = True Then
                                               Else
                                                   If Work = True Then
                                                       Downloadedpart5 = IO.File.ReadAllBytes(Uniquepath5).LongLength
                                                       Status5 = "Recieving Bytes...."
                                                       Percentage5 = (Downloadedpart5 / Lastsize) * 100
                                                       If Downloadedpart5 >= Lastsize Then
                                                           Percentage5 = (Downloadedpart5 / Lastsize) * 100
                                                           Status5 = "Completed"
                                                       Else
                                                           Dim BlockSize As Long = 1000000
                                                           If BlockSize + Downloadedpart5 > Lastsize Then
                                                               BlockSize = Lastsize - Downloadedpart5
                                                           End If
                                                           Dim bytes() As Byte = BlockBytes(Downloadedpart5 + othersize + othersize + othersize + othersize, BlockSize)
                                                           If bytes.LongLength = 0 Then
                                                               GoTo 1
                                                           Else
                                                               Status5 = "Recieving Bytes...."
                                                               Dim filestream As New IO.FileStream(Uniquepath5, IO.FileMode.OpenOrCreate)
                                                               filestream.Position = Downloadedpart5
                                                               filestream.Write(bytes, 0, bytes.Length)
                                                               filestream.Flush()
                                                               filestream.Dispose()
                                                               Downloadedpart5 += bytes.Length
                                                               GoTo 1
                                                           End If
                                                       End If
                                                   Else
                                                       GoTo 1
                                                   End If
                                               End If
                                           Catch ex As Exception
                                               GoTo 1
                                           End Try
                                       End Sub)
        Thread5.Start()
    End Sub
    Public Sub DownloadPart4()
        Thread4 = New Threading.Thread(Sub()
                                           Try
1:
                                               If Finish = True Then
                                               Else
                                                   If Work = True Then
                                                       Downloadedpart4 = IO.File.ReadAllBytes(Uniquepath4).LongLength
                                                       Status4 = "Recieving Bytes...."
                                                       Percentage4 = (Downloadedpart4 / othersize) * 100
                                                       If Downloadedpart4 >= othersize Then
                                                           Percentage4 = (Downloadedpart4 / othersize) * 100
                                                           Status4 = "Completed"
                                                       Else
                                                           Dim BlockSize As Long = 1000000
                                                           If BlockSize + Downloadedpart4 > othersize Then
                                                               BlockSize = othersize - Downloadedpart4
                                                           End If
                                                           Dim bytes() As Byte = BlockBytes(Downloadedpart4 + othersize + othersize + othersize, BlockSize)
                                                           If bytes.LongLength = 0 Then
                                                               GoTo 1
                                                           Else
                                                               Status4 = "Recieving Bytes...."
                                                               Dim filestream As New IO.FileStream(Uniquepath4, IO.FileMode.OpenOrCreate)
                                                               filestream.Position = Downloadedpart4
                                                               filestream.Write(bytes, 0, bytes.Length)
                                                               filestream.Flush()
                                                               filestream.Dispose()
                                                               Downloadedpart4 += bytes.Length
                                                               GoTo 1
                                                           End If
                                                       End If
                                                   Else
                                                       GoTo 1
                                                   End If
                                               End If
                                           Catch ex As Exception
                                               GoTo 1
                                           End Try
                                       End Sub)
        Thread4.Start()
    End Sub
    Public Sub DownloadPart3()
        Thread3 = New Threading.Thread(Sub()
                                           Try
1:
                                               If Finish = True Then
                                               Else
                                                   If Work = True Then
                                                       Downloadedpart3 = IO.File.ReadAllBytes(Uniquepath3).LongLength
                                                       Status3 = "Recieving Bytes...."
                                                       Percentage3 = (Downloadedpart3 / othersize) * 100
                                                       If Downloadedpart3 >= othersize Then
                                                           Percentage3 = (Downloadedpart3 / othersize) * 100
                                                           Status3 = "Completed"
                                                       Else
                                                           Dim BlockSize As Long = 1000000
                                                           If BlockSize + Downloadedpart3 > othersize Then
                                                               BlockSize = othersize - Downloadedpart3
                                                           End If
                                                           Dim bytes() As Byte = BlockBytes(Downloadedpart3 + othersize + othersize, BlockSize)
                                                           If bytes.LongLength = 0 Then
                                                               GoTo 1
                                                           Else
                                                               Status3 = "Recieving Bytes...."
                                                               Dim filestream As New IO.FileStream(Uniquepath3, IO.FileMode.OpenOrCreate)
                                                               filestream.Position = Downloadedpart3
                                                               filestream.Write(bytes, 0, bytes.Length)
                                                               filestream.Flush()
                                                               filestream.Dispose()
                                                               Downloadedpart3 += bytes.Length
                                                               GoTo 1
                                                           End If
                                                       End If
                                                   Else
                                                       GoTo 1
                                                   End If
                                               End If
                                           Catch ex As Exception
                                               GoTo 1
                                           End Try
                                       End Sub)
        Thread3.Start()
    End Sub
    Public Sub DownloadPart2()
        Thread2 = New Threading.Thread(Sub()
                                           Try
1:
                                               If Finish = True Then
                                               Else
                                                   If Work = True Then
                                                       downloadedpart2 = IO.File.ReadAllBytes(Uniquepath2).LongLength
                                                       Status2 = "Recieving Bytes...."
                                                       Percentage2 = (downloadedpart2 / othersize) * 100
                                                       If downloadedpart2 >= othersize Then
                                                           Percentage2 = (downloadedpart2 / othersize) * 100
                                                           Status2 = "Completed"
                                                       Else
                                                           Dim BlockSize As Long = 1000000
                                                           If BlockSize + downloadedpart2 > othersize Then
                                                               BlockSize = othersize - downloadedpart2
                                                           End If
                                                           Dim bytes() As Byte = BlockBytes(othersize + downloadedpart2, BlockSize)
                                                           If bytes.LongLength = 0 Then
                                                               GoTo 1
                                                           Else
                                                               Status2 = "Recieving Bytes...."
                                                               Dim filestream As New IO.FileStream(Uniquepath2, IO.FileMode.OpenOrCreate)
                                                               filestream.Position = downloadedpart2
                                                               filestream.Write(bytes, 0, bytes.Length)
                                                               filestream.Flush()
                                                               filestream.Dispose()
                                                               downloadedpart2 += bytes.Length
                                                               GoTo 1
                                                           End If
                                                       End If
                                                   Else
                                                       GoTo 1
                                                   End If
                                               End If
                                           Catch ex As Exception
                                               GoTo 1
                                           End Try
                                       End Sub)
        Thread2.Start()
    End Sub
    Public Sub DownloadPart1()
        Thread1 = New Threading.Thread(Sub()
                                           Try
1:
                                               If Finish = True Then
                                               Else
                                                   If Work = True Then
                                                       Downloadedpart1 = IO.File.ReadAllBytes(Uniquepath1).LongLength
                                                       Status1 = "Recieving Bytes...."
                                                       Percentage1 = (Downloadedpart1 / othersize) * 100
                                                       If Downloadedpart1 >= othersize Then
                                                           Percentage1 = (Downloadedpart1 / othersize) * 100
                                                           Status1 = "Completed"
                                                       Else
                                                           Dim Blocksize As Long = 1000000
                                                           If Blocksize + Downloadedpart1 > othersize Then
                                                               Blocksize = othersize - Downloadedpart1
                                                           End If
                                                           Dim bytes() As Byte = BlockBytes(Downloadedpart1, Blocksize)
                                                           If bytes.LongLength = 0 Then
                                                               GoTo 1
                                                           Else
                                                               Status1 = "Recieving Bytes...."
                                                               Dim filestream As New IO.FileStream(Uniquepath1, IO.FileMode.OpenOrCreate)
                                                               filestream.Position = Downloadedpart1
                                                               filestream.Write(bytes, 0, bytes.Length)
                                                               filestream.Flush()
                                                               filestream.Dispose()
                                                               Downloadedpart1 += bytes.Length
                                                               GoTo 1
                                                           End If
                                                       End If
                                                   Else
                                                       GoTo 1
                                                   End If
                                               End If
                                           Catch ex As Exception
                                               GoTo 1
                                           End Try
                                       End Sub)
        Thread1.Start()
    End Sub
    Public Function BlockBytes(ByVal Startindex As Long, ByVal Blocksize As Long) As Byte()
        Dim Recievedbytes As Byte()
        Try
            Dim Request As HttpWebRequest = DirectCast(HttpWebRequest.Create(Url), HttpWebRequest)
            Request.AddRange(Startindex)
            Dim Response As HttpWebResponse = DirectCast(Request.GetResponse, HttpWebResponse)
            Dim Stream As Stream = Response.GetResponseStream
            Dim reader As New BinaryReader(Stream)
            Recievedbytes = reader.ReadBytes(Blocksize)
            Stream.Close()
            Response.Close()
        Catch ex As Exception
            Recievedbytes = Nothing
        End Try
        Return Recievedbytes
    End Function
End Class
