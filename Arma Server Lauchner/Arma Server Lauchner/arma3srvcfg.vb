Public Class arma3srvcfg
    Inherits MetroSuite.MetroForm



    Private Sub arma3srvcfg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTextBox1.Text = System.IO.File.ReadAllText("E:\Arma3Server\SC\config.cfg", System.Text.Encoding.Default)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        My.Computer.FileSystem.WriteAllText("E:\Arma3Server\SC\config.cfg", MetroTextBox1.Text, False)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub
End Class