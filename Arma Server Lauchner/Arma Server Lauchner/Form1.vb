Imports System.Net
Imports System.IO
Imports System.Reflection.Assembly
Public Class Ω
    Inherits MetroSuite.MetroForm
    Private Sub UpdateSuchenToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        My.Computer.Network.DownloadFile("http://server4.server2.eu/vb/launcher/version", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\version.ini", "", "", False, 60000, True)
        Dim version As Version = GetExecutingAssembly.GetName.Version
        Dim MeineVersion As String = version.ToString()
        Dim ServerVersion As String = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\version.ini")
        If ServerVersion > MeineVersion Then

            Dim result = MessageBox.Show("Update Verfügbar!", "Update Ausführen?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                ' Abbbruch
            ElseIf result = DialogResult.Yes Then
                ' JA
                updater.ShowDialog()
            End If
        End If

        If ServerVersion <= MeineVersion Then
            MsgBox("Sie benutzen bereits die Aktuelle Version.", MsgBoxStyle.Information, "Nach Updates suchen")
        End If
    End Sub
    Private Sub MetroButton11_Click(sender As Object, e As EventArgs) Handles MetroButton11.Click
        arma3srvcfg.ShowDialog()
    End Sub

    Private Sub MetroButton13_Click(sender As Object, e As EventArgs) Handles MetroButton13.Click
        beccfg.ShowDialog()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim proc As New ProcessStartInfo
        proc.FileName = "E:\Arma3Server\start.bat"
        proc.UseShellExecute = True
        Dim startProc As Process = Process.Start(proc)
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim proc As New ProcessStartInfo
        proc.FileName = "E:\Arma3Server\DB\start-redis.cmd"
        proc.UseShellExecute = True
        Dim startProc As Process = Process.Start(proc)
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Dim proc As New ProcessStartInfo
        proc.FileName = "E:\Arma3Server\BEC\start.bat"
        proc.UseShellExecute = True
        Dim startProc As Process = Process.Start(proc)
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Shell("taskkill /F /IM arma3server.exe ")
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Shell("taskkill /F /IM redis-server.exe ")
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Shell("taskkill /F /IM BEC.exe ")
    End Sub

    Private Sub MetroButton9_Click_1(sender As Object, e As EventArgs) Handles MetroButton9.Click
        My.Computer.Network.DownloadFile("http://server4.server2.eu/vb/launcher/version", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\version.ini", "", "", False, 60000, True)
        Dim version As Version = GetExecutingAssembly.GetName.Version
        Dim MeineVersion As String = version.ToString()
        Dim ServerVersion As String = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\version.ini")
        If ServerVersion > MeineVersion Then

            Dim result = MessageBox.Show("Update Verfügbar!", "Update Ausführen?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                ' Abbbruch
            ElseIf result = DialogResult.Yes Then
                ' JA
                updater.ShowDialog()
            End If
        End If

        If ServerVersion <= MeineVersion Then
            MsgBox("Sie benutzen bereits die Aktuelle Version.", MsgBoxStyle.Information, "Nach Updates suchen")
        End If
    End Sub

    Private Sub MetroButton16_Click(sender As Object, e As EventArgs) Handles MetroButton16.Click
        credits.ShowDialog()
    End Sub

    Private Sub MetroButton17_Click(sender As Object, e As EventArgs) Handles MetroButton17.Click
        arma3log.ShowDialog()
    End Sub
End Class
