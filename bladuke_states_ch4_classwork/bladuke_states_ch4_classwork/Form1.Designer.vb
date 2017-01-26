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
        Me.stateBox = New System.Windows.Forms.GroupBox()
        Me.categoryBox = New System.Windows.Forms.GroupBox()
        Me.btnCali = New System.Windows.Forms.RadioButton()
        Me.btnIndiana = New System.Windows.Forms.RadioButton()
        Me.btnMississippi = New System.Windows.Forms.RadioButton()
        Me.btnNewYork = New System.Windows.Forms.RadioButton()
        Me.btnFlower = New System.Windows.Forms.RadioButton()
        Me.btnNickname = New System.Windows.Forms.RadioButton()
        Me.btnMotto = New System.Windows.Forms.RadioButton()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.stateBox.SuspendLayout()
        Me.categoryBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'stateBox
        '
        Me.stateBox.Controls.Add(Me.btnNewYork)
        Me.stateBox.Controls.Add(Me.btnMississippi)
        Me.stateBox.Controls.Add(Me.btnIndiana)
        Me.stateBox.Controls.Add(Me.btnCali)
        Me.stateBox.Location = New System.Drawing.Point(13, 13)
        Me.stateBox.Name = "stateBox"
        Me.stateBox.Size = New System.Drawing.Size(110, 114)
        Me.stateBox.TabIndex = 0
        Me.stateBox.TabStop = False
        Me.stateBox.Text = "State"
        '
        'categoryBox
        '
        Me.categoryBox.Controls.Add(Me.btnMotto)
        Me.categoryBox.Controls.Add(Me.btnNickname)
        Me.categoryBox.Controls.Add(Me.btnFlower)
        Me.categoryBox.Location = New System.Drawing.Point(146, 13)
        Me.categoryBox.Name = "categoryBox"
        Me.categoryBox.Size = New System.Drawing.Size(119, 114)
        Me.categoryBox.TabIndex = 1
        Me.categoryBox.TabStop = False
        Me.categoryBox.Text = "Category"
        '
        'btnCali
        '
        Me.btnCali.AutoSize = True
        Me.btnCali.Location = New System.Drawing.Point(7, 20)
        Me.btnCali.Name = "btnCali"
        Me.btnCali.Size = New System.Drawing.Size(68, 17)
        Me.btnCali.TabIndex = 0
        Me.btnCali.TabStop = True
        Me.btnCali.Text = "California"
        Me.btnCali.UseVisualStyleBackColor = True
        '
        'btnIndiana
        '
        Me.btnIndiana.AutoSize = True
        Me.btnIndiana.Location = New System.Drawing.Point(7, 44)
        Me.btnIndiana.Name = "btnIndiana"
        Me.btnIndiana.Size = New System.Drawing.Size(60, 17)
        Me.btnIndiana.TabIndex = 1
        Me.btnIndiana.TabStop = True
        Me.btnIndiana.Text = "Indiana"
        Me.btnIndiana.UseVisualStyleBackColor = True
        '
        'btnMississippi
        '
        Me.btnMississippi.AutoSize = True
        Me.btnMississippi.Location = New System.Drawing.Point(7, 68)
        Me.btnMississippi.Name = "btnMississippi"
        Me.btnMississippi.Size = New System.Drawing.Size(74, 17)
        Me.btnMississippi.TabIndex = 2
        Me.btnMississippi.TabStop = True
        Me.btnMississippi.Text = "Mississippi"
        Me.btnMississippi.UseVisualStyleBackColor = True
        '
        'btnNewYork
        '
        Me.btnNewYork.AutoSize = True
        Me.btnNewYork.Location = New System.Drawing.Point(7, 91)
        Me.btnNewYork.Name = "btnNewYork"
        Me.btnNewYork.Size = New System.Drawing.Size(72, 17)
        Me.btnNewYork.TabIndex = 3
        Me.btnNewYork.TabStop = True
        Me.btnNewYork.Text = "New York"
        Me.btnNewYork.UseVisualStyleBackColor = True
        '
        'btnFlower
        '
        Me.btnFlower.AutoSize = True
        Me.btnFlower.Location = New System.Drawing.Point(7, 20)
        Me.btnFlower.Name = "btnFlower"
        Me.btnFlower.Size = New System.Drawing.Size(56, 17)
        Me.btnFlower.TabIndex = 0
        Me.btnFlower.TabStop = True
        Me.btnFlower.Text = "Flower"
        Me.btnFlower.UseVisualStyleBackColor = True
        '
        'btnNickname
        '
        Me.btnNickname.AutoSize = True
        Me.btnNickname.Location = New System.Drawing.Point(7, 44)
        Me.btnNickname.Name = "btnNickname"
        Me.btnNickname.Size = New System.Drawing.Size(73, 17)
        Me.btnNickname.TabIndex = 1
        Me.btnNickname.TabStop = True
        Me.btnNickname.Text = "Nickname"
        Me.btnNickname.UseVisualStyleBackColor = True
        '
        'btnMotto
        '
        Me.btnMotto.AutoSize = True
        Me.btnMotto.Location = New System.Drawing.Point(7, 68)
        Me.btnMotto.Name = "btnMotto"
        Me.btnMotto.Size = New System.Drawing.Size(52, 17)
        Me.btnMotto.TabIndex = 2
        Me.btnMotto.TabStop = True
        Me.btnMotto.Text = "Motto"
        Me.btnMotto.UseVisualStyleBackColor = True
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(13, 134)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(252, 36)
        Me.btnShowInfo.TabIndex = 2
        Me.btnShowInfo.Text = "Show State Information"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(13, 177)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(252, 20)
        Me.txtInfo.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 261)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.categoryBox)
        Me.Controls.Add(Me.stateBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.stateBox.ResumeLayout(False)
        Me.stateBox.PerformLayout()
        Me.categoryBox.ResumeLayout(False)
        Me.categoryBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stateBox As GroupBox
    Friend WithEvents categoryBox As GroupBox
    Friend WithEvents btnNewYork As RadioButton
    Friend WithEvents btnMississippi As RadioButton
    Friend WithEvents btnIndiana As RadioButton
    Friend WithEvents btnCali As RadioButton
    Friend WithEvents btnMotto As RadioButton
    Friend WithEvents btnNickname As RadioButton
    Friend WithEvents btnFlower As RadioButton
    Friend WithEvents btnShowInfo As Button
    Friend WithEvents txtInfo As TextBox
End Class
