Public Class tb

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles main.Click
        AxWindowsMediaPlayer1.URL = ("http://listen.technobase.fm/tunein-dsl-ram")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        AxWindowsMediaPlayer1.close()
    End Sub

    Private Sub tracklist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tracklist.Click
        Process.Start("http://www.technobase.fm/tracklist/")
    End Sub

    Private Sub house_Click(sender As Object, e As EventArgs) Handles house.Click
        AxWindowsMediaPlayer1.URL = ("http://listen.housetime.fm/tunein-dsl-ram")
    End Sub

    Private Sub hardbasetb_Click(sender As Object, e As EventArgs) Handles hardbasetb.Click
        AxWindowsMediaPlayer1.URL = ("http://listen.hardbase.fm/tunein-dsl-ram")
    End Sub

    Private Sub coretime_Click(sender As Object, e As EventArgs) Handles coretime.Click
        AxWindowsMediaPlayer1.URL = ("http://listen.coretime.fm/tunein-dsl-ram")
    End Sub

    Private Sub clubtime_Click(sender As Object, e As EventArgs) Handles clubtime.Click
        AxWindowsMediaPlayer1.URL = ("http://listen.clubtime.fm/tunein-dsl-ram")
    End Sub

    Private Sub trance_Click(sender As Object, e As EventArgs) Handles trance.Click
        AxWindowsMediaPlayer1.URL = ("http://listen.trancebase.fm/tunein-dsl-ram")

    End Sub

    Private Sub sendeplantb_Click(sender As Object, e As EventArgs) Handles sendeplantb.Click
        Process.Start("http://www.technobase.fm/showplan/")
    End Sub
End Class