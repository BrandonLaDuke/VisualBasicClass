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
        Me.firstNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.secondNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'firstNumber
        '
        Me.firstNumber.Location = New System.Drawing.Point(85, 12)
        Me.firstNumber.Name = "firstNumber"
        Me.firstNumber.Size = New System.Drawing.Size(100, 20)
        Me.firstNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Number"
        '
        'secondNumber
        '
        Me.secondNumber.Location = New System.Drawing.Point(106, 52)
        Me.secondNumber.Name = "secondNumber"
        Me.secondNumber.Size = New System.Drawing.Size(100, 20)
        Me.secondNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Second Number"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(16, 92)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(235, 41)
        Me.btnCompute.TabIndex = 4
        Me.btnCompute.Text = "Find Largest Value"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(16, 152)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(235, 20)
        Me.txtResult.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.secondNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.firstNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents secondNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtResult As TextBox
End Class
