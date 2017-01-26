<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pay
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
        Me.lblWage = New System.Windows.Forms.Label()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblEarnings = New System.Windows.Forms.Label()
        Me.txtEarnings = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblWage
        '
        Me.lblWage.AutoSize = True
        Me.lblWage.Location = New System.Drawing.Point(13, 13)
        Me.lblWage.Name = "lblWage"
        Me.lblWage.Size = New System.Drawing.Size(69, 13)
        Me.lblWage.TabIndex = 0
        Me.lblWage.Text = "Hourly wage:"
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(88, 10)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(100, 20)
        Me.txtWage.TabIndex = 1
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(13, 36)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(76, 13)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Hours worked:"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(88, 33)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(13, 63)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(175, 38)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Earnings for the Week"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblEarnings
        '
        Me.lblEarnings.AutoSize = True
        Me.lblEarnings.Location = New System.Drawing.Point(13, 113)
        Me.lblEarnings.Name = "lblEarnings"
        Me.lblEarnings.Size = New System.Drawing.Size(51, 13)
        Me.lblEarnings.TabIndex = 5
        Me.lblEarnings.Text = "Earnings:"
        '
        'txtEarnings
        '
        Me.txtEarnings.Location = New System.Drawing.Point(88, 110)
        Me.txtEarnings.Name = "txtEarnings"
        Me.txtEarnings.Size = New System.Drawing.Size(100, 20)
        Me.txtEarnings.TabIndex = 6
        '
        'Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtEarnings)
        Me.Controls.Add(Me.lblEarnings)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.txtWage)
        Me.Controls.Add(Me.lblWage)
        Me.Name = "Pay"
        Me.Text = "Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWage As Label
    Friend WithEvents txtWage As TextBox
    Friend WithEvents lblHours As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblEarnings As Label
    Friend WithEvents txtEarnings As TextBox
End Class
