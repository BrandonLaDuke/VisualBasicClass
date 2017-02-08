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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtWhen = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount deposited: "
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(123, 16)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 1
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(22, 42)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(201, 33)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Calculate years to become a millionaire"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtWhen
        '
        Me.txtWhen.Location = New System.Drawing.Point(22, 82)
        Me.txtWhen.Name = "txtWhen"
        Me.txtWhen.Size = New System.Drawing.Size(201, 20)
        Me.txtWhen.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 114)
        Me.Controls.Add(Me.txtWhen)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtWhen As TextBox
End Class
