<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tb))
        Me.main = New System.Windows.Forms.Button()
        Me.house = New System.Windows.Forms.Button()
        Me.trance = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tracklist = New System.Windows.Forms.Button()
        Me.hardbasetb = New System.Windows.Forms.Button()
        Me.coretime = New System.Windows.Forms.Button()
        Me.clubtime = New System.Windows.Forms.Button()
        Me.sendeplantb = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main
        '
        Me.main.Location = New System.Drawing.Point(21, 82)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(75, 23)
        Me.main.TabIndex = 0
        Me.main.Text = "Main Stream"
        Me.main.UseVisualStyleBackColor = True
        '
        'house
        '
        Me.house.Location = New System.Drawing.Point(102, 82)
        Me.house.Name = "house"
        Me.house.Size = New System.Drawing.Size(75, 23)
        Me.house.TabIndex = 1
        Me.house.Text = "House"
        Me.house.UseVisualStyleBackColor = True
        '
        'trance
        '
        Me.trance.Location = New System.Drawing.Point(264, 82)
        Me.trance.Name = "trance"
        Me.trance.Size = New System.Drawing.Size(75, 23)
        Me.trance.TabIndex = 2
        Me.trance.Text = "Trance"
        Me.trance.UseVisualStyleBackColor = True
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
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(345, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Zurück"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tracklist
        '
        Me.tracklist.Location = New System.Drawing.Point(264, 111)
        Me.tracklist.Name = "tracklist"
        Me.tracklist.Size = New System.Drawing.Size(75, 23)
        Me.tracklist.TabIndex = 7
        Me.tracklist.Text = "Tracklist"
        Me.tracklist.UseVisualStyleBackColor = True
        '
        'hardbasetb
        '
        Me.hardbasetb.Location = New System.Drawing.Point(183, 82)
        Me.hardbasetb.Name = "hardbasetb"
        Me.hardbasetb.Size = New System.Drawing.Size(75, 23)
        Me.hardbasetb.TabIndex = 8
        Me.hardbasetb.Text = "Hardbase"
        Me.hardbasetb.UseVisualStyleBackColor = True
        '
        'coretime
        '
        Me.coretime.Location = New System.Drawing.Point(345, 82)
        Me.coretime.Name = "coretime"
        Me.coretime.Size = New System.Drawing.Size(75, 23)
        Me.coretime.TabIndex = 9
        Me.coretime.Text = "Coretime"
        Me.coretime.UseVisualStyleBackColor = True
        '
        'clubtime
        '
        Me.clubtime.Location = New System.Drawing.Point(21, 111)
        Me.clubtime.Name = "clubtime"
        Me.clubtime.Size = New System.Drawing.Size(75, 23)
        Me.clubtime.TabIndex = 10
        Me.clubtime.Text = "Clubtime"
        Me.clubtime.UseVisualStyleBackColor = True
        '
        'sendeplantb
        '
        Me.sendeplantb.Location = New System.Drawing.Point(183, 111)
        Me.sendeplantb.Name = "sendeplantb"
        Me.sendeplantb.Size = New System.Drawing.Size(75, 23)
        Me.sendeplantb.TabIndex = 11
        Me.sendeplantb.Text = "Sendeplan"
        Me.sendeplantb.UseVisualStyleBackColor = True
        '
        'tb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 151)
        Me.Controls.Add(Me.sendeplantb)
        Me.Controls.Add(Me.clubtime)
        Me.Controls.Add(Me.coretime)
        Me.Controls.Add(Me.hardbasetb)
        Me.Controls.Add(Me.tracklist)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.trance)
        Me.Controls.Add(Me.house)
        Me.Controls.Add(Me.main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Technobase Streams"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main As System.Windows.Forms.Button
    Friend WithEvents house As System.Windows.Forms.Button
    Friend WithEvents trance As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tracklist As System.Windows.Forms.Button
    Friend WithEvents hardbasetb As System.Windows.Forms.Button
    Friend WithEvents coretime As System.Windows.Forms.Button
    Friend WithEvents clubtime As System.Windows.Forms.Button
    Friend WithEvents sendeplantb As System.Windows.Forms.Button
End Class
