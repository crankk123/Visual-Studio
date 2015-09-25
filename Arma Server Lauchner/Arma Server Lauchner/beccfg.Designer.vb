<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class beccfg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(beccfg))
        Me.MetroTextBox1 = New MetroSuite.MetroTextBox()
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
        Me.MetroTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.Size = New System.Drawing.Size(707, 652)
        Me.MetroTextBox1.TabIndex = 1
        Me.MetroTextBox1.Text = "MetroTextBox1"
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MetroTextBox1.UseDefaultText = False
        '
        'beccfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 676)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.MaximumSize = New System.Drawing.Size(740, 676)
        Me.MinimumSize = New System.Drawing.Size(740, 676)
        Me.Name = "beccfg"
        Me.Text = "beccfg"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTextBox1 As MetroSuite.MetroTextBox
End Class
