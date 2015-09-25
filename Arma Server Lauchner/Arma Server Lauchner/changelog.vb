Public Class changelog

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = System.IO.File.ReadAllText("changelog.txt", System.Text.Encoding.Default)
    End Sub
End Class