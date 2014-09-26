<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class t4e
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(t4e))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.main1 = New System.Windows.Forms.Button()
        Me.club = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tracklist = New System.Windows.Forms.Button()
        Me.hard = New System.Windows.Forms.Button()
        Me.sendeplan = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(-3, 0)
        Me.AxWindowsMediaPlayer1.MaximumSize = New System.Drawing.Size(447, 76)
        Me.AxWindowsMediaPlayer1.MinimumSize = New System.Drawing.Size(447, 76)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(447, 76)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'main1
        '
        Me.main1.Location = New System.Drawing.Point(21, 82)
        Me.main1.Name = "main1"
        Me.main1.Size = New System.Drawing.Size(75, 23)
        Me.main1.TabIndex = 1
        Me.main1.Text = "Main Stream"
        Me.main1.UseVisualStyleBackColor = True
        '
        'club
        '
        Me.club.Location = New System.Drawing.Point(102, 82)
        Me.club.Name = "club"
        Me.club.Size = New System.Drawing.Size(75, 23)
        Me.club.TabIndex = 2
        Me.club.Text = "Club Stream"
        Me.club.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(345, 111)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 4
        Me.back.Text = "Zurück"
        Me.back.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tracklist
        '
        Me.tracklist.Location = New System.Drawing.Point(264, 82)
        Me.tracklist.Name = "tracklist"
        Me.tracklist.Size = New System.Drawing.Size(75, 23)
        Me.tracklist.TabIndex = 6
        Me.tracklist.Text = "Tracklist"
        Me.tracklist.UseVisualStyleBackColor = True
        '
        'hard
        '
        Me.hard.Location = New System.Drawing.Point(183, 82)
        Me.hard.Name = "hard"
        Me.hard.Size = New System.Drawing.Size(75, 23)
        Me.hard.TabIndex = 7
        Me.hard.Text = "Hard Stream"
        Me.hard.UseVisualStyleBackColor = True
        '
        'sendeplan
        '
        Me.sendeplan.Location = New System.Drawing.Point(345, 82)
        Me.sendeplan.Name = "sendeplan"
        Me.sendeplan.Size = New System.Drawing.Size(75, 23)
        Me.sendeplan.TabIndex = 8
        Me.sendeplan.Text = "Sendeplan"
        Me.sendeplan.UseVisualStyleBackColor = True
        '
        't4e
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 151)
        Me.Controls.Add(Me.sendeplan)
        Me.Controls.Add(Me.hard)
        Me.Controls.Add(Me.tracklist)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.club)
        Me.Controls.Add(Me.main1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "t4e"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Techno4Ever Streams"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents main1 As System.Windows.Forms.Button
    Friend WithEvents club As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tracklist As System.Windows.Forms.Button
    Friend WithEvents hard As System.Windows.Forms.Button
    Friend WithEvents sendeplan As System.Windows.Forms.Button
End Class
