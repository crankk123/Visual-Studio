Imports Ionic.Zip
Imports System.Net
Imports System.EventArgs

Public Class Updater
    Private WithEvents httpclient As WebClient
    Dim tempPfad As String = My.Computer.FileSystem.SpecialDirectories.Temp
    Dim pfad As String = tempPfad + "\updater.zip"
    Dim pfadExe As String = tempPfad + "\updater.exe"


    Private Sub Updater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                httpclient = New WebClient
                Dim url As String = "http://teampenner.de/player/updater.zip"
                Me.Hide()
                Application.DoEvents()
            httpclient.DownloadFileAsync(New Uri(url), pfad)
                Application.DoEvents()
            Catch ex As Exception
                MsgBox("Es ist folgender Fehler aufgetreten:" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Es ist ein Fehler aufgetreten")
                End
            End Try
    End Sub

    Private Sub httpclient_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles httpclient.DownloadFileCompleted

        Using zip1 As ZipFile = ZipFile.Read(pfad)
            Dim g As ZipEntry
            For Each g In zip1
                g.Extract(tempPfad, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
        'UAC
        Dim info As New ProcessStartInfo(pfadExe)
        info.UseShellExecute = True
        info.Verb = "runas"
        Process.Start(info)
        Me.Close()
        End
    End Sub

    Private Sub httpclient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles httpclient.DownloadProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        Dim totalbytes As Double = e.TotalBytesToReceive
        Dim bytes As Double = e.BytesReceived
        Me.Label1.Text = bytes & " MB von " & totalbytes & " MB "
    End Sub
End Class
