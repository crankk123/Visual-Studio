Public Class beccfg
    Inherits MetroSuite.MetroForm
    Private Sub beccfg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTextBox1.Text = System.IO.File.ReadAllText("E:\Arma3Server\BEC\Config\Config.cfg", System.Text.Encoding.Default)
    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click

    End Sub
End Class