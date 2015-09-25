Imports System.IO

Public Class arma3log
    Inherits MetroSuite.MetroForm
    Dim zeit As Date
    Dim datei As String
    Private Sub arma3log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim files() As String = Directory.GetFiles("E:\Arma3Server\SC", "*.rpt")
        For Each thisFile As String In files
            ' RichTextBox1.Text += File.ReadAllText(thisFile)
        Next
    End Sub

    Private Function ScrollViewer() As Object
        Throw New NotImplementedException
    End Function

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim files() As String = Directory.GetFiles("E:\Arma3Server\SC", "*.rpt")
        For Each thisFile As String In files
            Dim INFOS As System.IO.FileInfo
            INFOS = My.Computer.FileSystem.GetFileInfo(thisFile)
            'so was machen wir jz
            RichTextBox1.Text += INFOS.LastWriteTime
            'RichTextBox1.Text += File.ReadAllText(thisFile)
        Next
    End Sub

    Private Function frm_main() As Object
        Throw New NotImplementedException
    End Function

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim files() As String = Directory.GetFiles("E:\Arma3Server\SC", "*.rpt")
        For Each thisFile As String In files
            Dim INFOS As System.IO.FileInfo
            zeit = DateSerial(1900, 1, 1)
            INFOS = My.Computer.FileSystem.GetFileInfo(thisFile)
            If INFOS.LastWriteTime > zeit Then
                zeit = INFOS.LastWriteTime
                datei = INFOS.FullName
                Console.Out.WriteLine(datei)
            End If

            'RichTextBox1.Text += File.ReadAllText(datei)
        Next
    End Sub
End Class