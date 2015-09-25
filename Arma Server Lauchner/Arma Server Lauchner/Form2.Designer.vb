<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim MainColorScheme1 As MetroSuite.MetroButton.MainColorScheme = New MetroSuite.MetroButton.MainColorScheme()
        Dim MainColorScheme2 As MetroSuite.MetroButton.MainColorScheme = New MetroSuite.MetroButton.MainColorScheme()
        Dim MainColorScheme3 As MetroSuite.MetroButton.MainColorScheme = New MetroSuite.MetroButton.MainColorScheme()
        Dim MainColorScheme4 As MetroSuite.MetroButton.MainColorScheme = New MetroSuite.MetroButton.MainColorScheme()
        Dim MainColorScheme5 As MetroSuite.MetroButton.MainColorScheme = New MetroSuite.MetroButton.MainColorScheme()
        Me.MetroButton3 = New MetroSuite.MetroButton()
        Me.MetroButton2 = New MetroSuite.MetroButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroSuite.MetroButton()
        Me.btn_speichern = New MetroSuite.MetroButton()
        Me.btn_reload = New MetroSuite.MetroButton()
        Me.SuspendLayout()
        '
        'MetroButton3
        '
        MainColorScheme1.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme1.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme1.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme1.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.MetroButton3.ColorScheme = MainColorScheme1
        Me.MetroButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton3.ForeColor = System.Drawing.Color.Black
        Me.MetroButton3.Location = New System.Drawing.Point(628, 225)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(105, 27)
        Me.MetroButton3.TabIndex = 74
        Me.MetroButton3.Text = "Starten"
        '
        'MetroButton2
        '
        MainColorScheme2.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme2.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme2.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme2.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.MetroButton2.ColorScheme = MainColorScheme2
        Me.MetroButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton2.ForeColor = System.Drawing.Color.Black
        Me.MetroButton2.Location = New System.Drawing.Point(517, 224)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(105, 27)
        Me.MetroButton2.TabIndex = 73
        Me.MetroButton2.Text = "Stoppen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(514, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Server"
        '
        'MetroButton1
        '
        MainColorScheme3.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme3.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme3.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme3.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme3.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.MetroButton1.ColorScheme = MainColorScheme3
        Me.MetroButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton1.ForeColor = System.Drawing.Color.Black
        Me.MetroButton1.Location = New System.Drawing.Point(517, 190)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(215, 27)
        Me.MetroButton1.TabIndex = 71
        Me.MetroButton1.Text = "Version anzeigen"
        '
        'btn_speichern
        '
        MainColorScheme4.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme4.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme4.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme4.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme4.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btn_speichern.ColorScheme = MainColorScheme4
        Me.btn_speichern.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_speichern.ForeColor = System.Drawing.Color.Black
        Me.btn_speichern.Location = New System.Drawing.Point(517, 157)
        Me.btn_speichern.Name = "btn_speichern"
        Me.btn_speichern.Size = New System.Drawing.Size(105, 27)
        Me.btn_speichern.TabIndex = 70
        Me.btn_speichern.Text = "Speichern"
        '
        'btn_reload
        '
        MainColorScheme5.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme5.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme5.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme5.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme5.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btn_reload.ColorScheme = MainColorScheme5
        Me.btn_reload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_reload.ForeColor = System.Drawing.Color.Black
        Me.btn_reload.Location = New System.Drawing.Point(627, 157)
        Me.btn_reload.Name = "btn_reload"
        Me.btn_reload.Size = New System.Drawing.Size(105, 27)
        Me.btn_reload.TabIndex = 69
        Me.btn_reload.Text = "Reload"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 261)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btn_speichern)
        Me.Controls.Add(Me.btn_reload)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton3 As MetroSuite.MetroButton
    Friend WithEvents MetroButton2 As MetroSuite.MetroButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroSuite.MetroButton
    Friend WithEvents btn_speichern As MetroSuite.MetroButton
    Friend WithEvents btn_reload As MetroSuite.MetroButton
End Class
