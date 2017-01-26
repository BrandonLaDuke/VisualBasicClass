<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bladukeWeek2Homework
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
        Me.firstNum = New System.Windows.Forms.TextBox()
        Me.secondNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Button()
        Me.subtract = New System.Windows.Forms.Button()
        Me.multiply = New System.Windows.Forms.Button()
        Me.resultBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'firstNum
        '
        Me.firstNum.Location = New System.Drawing.Point(12, 22)
        Me.firstNum.Name = "firstNum"
        Me.firstNum.Size = New System.Drawing.Size(100, 20)
        Me.firstNum.TabIndex = 0
        '
        'secondNum
        '
        Me.secondNum.Location = New System.Drawing.Point(172, 22)
        Me.secondNum.Name = "secondNum"
        Me.secondNum.Size = New System.Drawing.Size(100, 20)
        Me.secondNum.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Second Number"
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(15, 93)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(55, 43)
        Me.add.TabIndex = 4
        Me.add.Text = "+"
        Me.add.UseVisualStyleBackColor = True
        '
        'subtract
        '
        Me.subtract.Location = New System.Drawing.Point(76, 93)
        Me.subtract.Name = "subtract"
        Me.subtract.Size = New System.Drawing.Size(56, 43)
        Me.subtract.TabIndex = 5
        Me.subtract.Text = "-"
        Me.subtract.UseVisualStyleBackColor = True
        '
        'multiply
        '
        Me.multiply.Location = New System.Drawing.Point(150, 93)
        Me.multiply.Name = "multiply"
        Me.multiply.Size = New System.Drawing.Size(54, 43)
        Me.multiply.TabIndex = 6
        Me.multiply.Text = "X"
        Me.multiply.UseVisualStyleBackColor = True
        '
        'resultBox
        '
        Me.resultBox.Location = New System.Drawing.Point(15, 175)
        Me.resultBox.Name = "resultBox"
        Me.resultBox.Size = New System.Drawing.Size(257, 20)
        Me.resultBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Result"
        '
        'bladukeWeek2Homework
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.resultBox)
        Me.Controls.Add(Me.multiply)
        Me.Controls.Add(Me.subtract)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.secondNum)
        Me.Controls.Add(Me.firstNum)
        Me.Name = "bladukeWeek2Homework"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstNum As TextBox
    Friend WithEvents secondNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents add As Button
    Friend WithEvents subtract As Button
    Friend WithEvents multiply As Button
    Friend WithEvents resultBox As TextBox
    Friend WithEvents Label3 As Label
End Class
