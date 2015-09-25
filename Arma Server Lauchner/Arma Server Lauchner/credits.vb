Public Class credits

    Inherits MetroSuite.MetroForm
    Private Sub frm_credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroLinkLabel1_Click(sender As Object, e As EventArgs) Handles MetroLinkLabel1.Click
        Process.Start("http://www.inzane-esports.eu")
    End Sub

    Private Sub MetroLinkLabel2_Click(sender As Object, e As EventArgs) Handles MetroLinkLabel2.Click
        Process.Start("http://www.vb-paradise.de/sonstiges/showroom-testcenter/libraries-controls/81271-metrosuite-update-08-02-2013-holt-euch-den-modernen-windows-8-style/")
    End Sub

    Private Sub MetroLinkLabel3_Click(sender As Object, e As EventArgs) Handles MetroLinkLabel3.Click
        Process.Start("http://www.vb-paradise.de/sonstiges/showroom-testcenter/libraries-controls/81284-aero-lite-controls-windows-8-stil-fuer-windows-forms-neue-version/")
    End Sub

    Private Sub MetroLinkLabel4_Click(sender As Object, e As EventArgs) Handles MetroLinkLabel4.Click
        Process.Start("http://www.vb-paradise.de/sonstiges/showroom-testcenter/libraries-controls/74093-progress-controls-beta/")
    End Sub

End Class