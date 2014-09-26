Public Class t4e

    Private Sub main1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main1.Click

        AxWindowsMediaPlayer1.URL = ("http://tunein.t4e.dj/main/dsl/mp3")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles club.Click
        AxWindowsMediaPlayer1.URL = ("http://tunein.t4e.dj/club/dsl/mp3")
    End Sub

    Private Sub trance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        AxWindowsMediaPlayer1.close()
        Me.Close()
    End Sub

    Private Sub tracklist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tracklist.Click
        Process.Start("http://www.techno4ever.fm/tracklist")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles hard.Click
        AxWindowsMediaPlayer1.URL = ("http://tunein.t4e.dj/hard/dsl/mp3")
    End Sub

    Private Sub sendeplan_Click(sender As Object, e As EventArgs) Handles sendeplan.Click
        Process.Start("http://www.techno4ever.fm/Shedule")
    End Sub

    Private Sub t4e_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class