<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fWhite = New System.Windows.Forms.RadioButton()
        Me.fYellow = New System.Windows.Forms.RadioButton()
        Me.fRed = New System.Windows.Forms.RadioButton()
        Me.fBlue = New System.Windows.Forms.RadioButton()
        Me.bWhite = New System.Windows.Forms.RadioButton()
        Me.bYellow = New System.Windows.Forms.RadioButton()
        Me.bRed = New System.Windows.Forms.RadioButton()
        Me.bBlue = New System.Windows.Forms.RadioButton()
        Me.vSText = New System.Windows.Forms.Label()
        Me.applyColors = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fWhite
        '
        Me.fWhite.AutoSize = True
        Me.fWhite.Location = New System.Drawing.Point(18, 18)
        Me.fWhite.Name = "fWhite"
        Me.fWhite.Size = New System.Drawing.Size(53, 17)
        Me.fWhite.TabIndex = 2
        Me.fWhite.TabStop = True
        Me.fWhite.Tag = ""
        Me.fWhite.Text = "White"
        Me.fWhite.UseVisualStyleBackColor = True
        '
        'fYellow
        '
        Me.fYellow.AutoSize = True
        Me.fYellow.Location = New System.Drawing.Point(18, 41)
        Me.fYellow.Name = "fYellow"
        Me.fYellow.Size = New System.Drawing.Size(56, 17)
        Me.fYellow.TabIndex = 3
        Me.fYellow.TabStop = True
        Me.fYellow.Text = "Yellow"
        Me.fYellow.UseVisualStyleBackColor = True
        '
        'fRed
        '
        Me.fRed.AutoSize = True
        Me.fRed.Location = New System.Drawing.Point(18, 64)
        Me.fRed.Name = "fRed"
        Me.fRed.Size = New System.Drawing.Size(45, 17)
        Me.fRed.TabIndex = 4
        Me.fRed.TabStop = True
        Me.fRed.Text = "Red"
        Me.fRed.UseVisualStyleBackColor = True
        '
        'fBlue
        '
        Me.fBlue.AutoSize = True
        Me.fBlue.Location = New System.Drawing.Point(18, 87)
        Me.fBlue.Name = "fBlue"
        Me.fBlue.Size = New System.Drawing.Size(46, 17)
        Me.fBlue.TabIndex = 5
        Me.fBlue.TabStop = True
        Me.fBlue.Text = "Blue"
        Me.fBlue.UseVisualStyleBackColor = True
        '
        'bWhite
        '
        Me.bWhite.AutoSize = True
        Me.bWhite.Location = New System.Drawing.Point(6, 18)
        Me.bWhite.Name = "bWhite"
        Me.bWhite.Size = New System.Drawing.Size(53, 17)
        Me.bWhite.TabIndex = 6
        Me.bWhite.TabStop = True
        Me.bWhite.Text = "White"
        Me.bWhite.UseVisualStyleBackColor = True
        '
        'bYellow
        '
        Me.bYellow.AutoSize = True
        Me.bYellow.Location = New System.Drawing.Point(6, 41)
        Me.bYellow.Name = "bYellow"
        Me.bYellow.Size = New System.Drawing.Size(56, 17)
        Me.bYellow.TabIndex = 7
        Me.bYellow.TabStop = True
        Me.bYellow.Text = "Yellow"
        Me.bYellow.UseVisualStyleBackColor = True
        '
        'bRed
        '
        Me.bRed.AutoSize = True
        Me.bRed.Location = New System.Drawing.Point(6, 64)
        Me.bRed.Name = "bRed"
        Me.bRed.Size = New System.Drawing.Size(45, 17)
        Me.bRed.TabIndex = 8
        Me.bRed.TabStop = True
        Me.bRed.Text = "Red"
        Me.bRed.UseVisualStyleBackColor = True
        '
        'bBlue
        '
        Me.bBlue.AutoSize = True
        Me.bBlue.Location = New System.Drawing.Point(5, 87)
        Me.bBlue.Name = "bBlue"
        Me.bBlue.Size = New System.Drawing.Size(46, 17)
        Me.bBlue.TabIndex = 9
        Me.bBlue.TabStop = True
        Me.bBlue.Text = "Blue"
        Me.bBlue.UseVisualStyleBackColor = True
        '
        'vSText
        '
        Me.vSText.AutoSize = True
        Me.vSText.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vSText.Location = New System.Drawing.Point(16, 141)
        Me.vSText.Name = "vSText"
        Me.vSText.Size = New System.Drawing.Size(240, 38)
        Me.vSText.TabIndex = 10
        Me.vSText.Text = "VISUAL BASIC"
        '
        'applyColors
        '
        Me.applyColors.Location = New System.Drawing.Point(277, 43)
        Me.applyColors.Name = "applyColors"
        Me.applyColors.Size = New System.Drawing.Size(75, 77)
        Me.applyColors.TabIndex = 11
        Me.applyColors.Text = "Apply Colors"
        Me.applyColors.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fBlue)
        Me.GroupBox1.Controls.Add(Me.fWhite)
        Me.GroupBox1.Controls.Add(Me.fYellow)
        Me.GroupBox1.Controls.Add(Me.fRed)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 123)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Foreground Color"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bWhite)
        Me.GroupBox2.Controls.Add(Me.bYellow)
        Me.GroupBox2.Controls.Add(Me.bRed)
        Me.GroupBox2.Controls.Add(Me.bBlue)
        Me.GroupBox2.Location = New System.Drawing.Point(140, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 123)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Background Color"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 197)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.applyColors)
        Me.Controls.Add(Me.vSText)
        Me.Name = "Form1"
        Me.Text = "Colors"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fWhite As RadioButton
    Friend WithEvents fYellow As RadioButton
    Friend WithEvents fRed As RadioButton
    Friend WithEvents fBlue As RadioButton
    Friend WithEvents bWhite As RadioButton
    Friend WithEvents bYellow As RadioButton
    Friend WithEvents bRed As RadioButton
    Friend WithEvents bBlue As RadioButton
    Friend WithEvents vSText As Label
    Friend WithEvents applyColors As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
