<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arma3srvcfg
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
        Dim MainColorScheme1 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(arma3srvcfg))
        Dim MainColorScheme2 As MetroSuite.MetroButton.MainColorScheme = New MetroSuite.MetroButton.MainColorScheme()
        Dim MainColorScheme3 As MetroSuite.MetroButton.MainColorScheme = New MetroSuite.MetroButton.MainColorScheme()
        Me.MetroTextBox1 = New MetroSuite.MetroTextBox()
        Me.MetroControlBox1 = New MetroSuite.MetroControlBox()
        Me.MetroButton1 = New MetroSuite.MetroButton()
        Me.MetroButton2 = New MetroSuite.MetroButton()
        Me.SuspendLayout()
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.BanChars = False
        MainColorScheme1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme1.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme1.MainColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.MetroTextBox1.ColorScheme = MainColorScheme1
        Me.MetroTextBox1.DefaultText = Nothing
        Me.MetroTextBox1.DefaultTextColor = System.Drawing.Color.LightGray
        Me.MetroTextBox1.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroTextBox1.IllegalChars = CType(resources.GetObject("MetroTextBox1.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.MetroTextBox1.Location = New System.Drawing.Point(17, 37)
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.Size = New System.Drawing.Size(707, 601)
        Me.MetroTextBox1.TabIndex = 2
        Me.MetroTextBox1.Text = "MetroTextBox1"
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MetroTextBox1.UseDefaultText = False
        '
        'MetroControlBox1
        '
        Me.MetroControlBox1.FormHeight = 0
        Me.MetroControlBox1.FormWidth = 0
        Me.MetroControlBox1.Location = New System.Drawing.Point(618, 5)
        Me.MetroControlBox1.Name = "MetroControlBox1"
        Me.MetroControlBox1.Size = New System.Drawing.Size(110, 26)
        Me.MetroControlBox1.TabIndex = 3
        '
        'MetroButton1
        '
        MainColorScheme2.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme2.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme2.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme2.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.MetroButton1.ColorScheme = MainColorScheme2
        Me.MetroButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton1.ForeColor = System.Drawing.Color.Black
        Me.MetroButton1.Location = New System.Drawing.Point(456, 644)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(105, 27)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "Speichern"
        '
        'MetroButton2
        '
        MainColorScheme3.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme3.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme3.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme3.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme3.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.MetroButton2.ColorScheme = MainColorScheme3
        Me.MetroButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton2.ForeColor = System.Drawing.Color.Black
        Me.MetroButton2.Location = New System.Drawing.Point(618, 644)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(105, 27)
        Me.MetroButton2.TabIndex = 5
        Me.MetroButton2.Text = "Abbrechen"
        '
        'arma3srvcfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(740, 676)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroControlBox1)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.MaximumSize = New System.Drawing.Size(740, 676)
        Me.MinimumSize = New System.Drawing.Size(740, 676)
        Me.Name = "arma3srvcfg"
        Me.Text = "Arma 3 Server Config"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTextBox1 As MetroSuite.MetroTextBox
    Friend WithEvents MetroControlBox1 As MetroSuite.MetroControlBox
    Friend WithEvents MetroButton1 As MetroSuite.MetroButton
    Friend WithEvents MetroButton2 As MetroSuite.MetroButton
End Class
