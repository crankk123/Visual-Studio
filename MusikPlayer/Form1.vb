Imports System.Net
Imports System.Reflection
Imports System
Imports System.Reflection.Assembly
Imports System.Math
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tb.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        t4e.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Network.DownloadFile("http://teampenner.de/player/version", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\version.ini", "", "", False, 60000, True)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        bigfm.ShowDialog()
    End Sub
End Class
