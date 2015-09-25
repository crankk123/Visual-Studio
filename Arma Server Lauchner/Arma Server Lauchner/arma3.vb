Public Class arma3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim proc As New ProcessStartInfo
        proc.FileName = "E:\Arma3Server\start.bat"
        proc.UseShellExecute = True
        Dim startProc As Process = Process.Start(proc)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim proc As New ProcessStartInfo
        proc.FileName = "E:\Arma3Server\DB\start-redis.cmd"
        proc.UseShellExecute = True
        Dim startProc As Process = Process.Start(proc)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim proc As New ProcessStartInfo
        proc.FileName = "E:\Arma3Server\BEC\start.bat"
        proc.UseShellExecute = True
        Dim startProc As Process = Process.Start(proc)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("taskkill /F /IM arma3server.exe ")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("taskkill /F /IM redis-server.exe ")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("taskkill /F /IM BEC.exe ")
    End Sub
End Class