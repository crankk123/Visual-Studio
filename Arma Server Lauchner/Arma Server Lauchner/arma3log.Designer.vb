<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arma3log
    Inherits MetroSuite.MetroForm

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
        Me.MetroControlBox1 = New MetroSuite.MetroControlBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MetroButton1 = New MetroSuite.MetroButton()
        Me.MetroButton2 = New MetroSuite.MetroButton()
        Me.SuspendLayout()
        '
        'MetroControlBox1
        '
        Me.MetroControlBox1.FormHeight = 0
        Me.MetroControlBox1.FormWidth = 0
        Me.MetroControlBox1.Location = New System.Drawing.Point(618, 14)
        Me.MetroControlBox1.Name = "MetroControlBox1"
        Me.MetroControlBox1.Size = New System.Drawing.Size(110, 26)
        Me.MetroControlBox1.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 46)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(716, 597)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'MetroButton1
        '
        MainColorScheme1.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme1.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme1.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme1.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.MetroButton1.ColorScheme = MainColorScheme1
        Me.MetroButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton1.ForeColor = System.Drawing.Color.Black
        Me.MetroButton1.Location = New System.Drawing.Point(12, 649)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(105, 27)
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "Speichern"
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
        Me.MetroButton2.Location = New System.Drawing.Point(123, 649)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(105, 27)
        Me.MetroButton2.TabIndex = 4
        Me.MetroButton2.Text = "Updaten"
        '
        'arma3log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(740, 676)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MetroControlBox1)
        Me.MaximumSize = New System.Drawing.Size(740, 676)
        Me.MinimumSize = New System.Drawing.Size(740, 676)
        Me.Name = "arma3log"
        Me.Text = "Arma 3 Server Log"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroControlBox1 As MetroSuite.MetroControlBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MetroButton1 As MetroSuite.MetroButton
    Friend WithEvents MetroButton2 As MetroSuite.MetroButton
End Class
