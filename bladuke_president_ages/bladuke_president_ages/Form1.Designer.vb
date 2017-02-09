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
        Me.lstAges = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtAvgAge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ages"
        '
        'lstAges
        '
        Me.lstAges.FormattingEnabled = True
        Me.lstAges.Items.AddRange(New Object() {"57", "61", "57", "57", "58", "57", "61", "54", "68", "51", "49", "64", "50", "48", "65", "52", "56", "46", "54", "49", "51", "47", "55", "55", "54", "42", "51", "56", "55", "51", "54", "51", "60", "62", "43", "55", "56", "61", "52", "69", "64", "46", "54", "47", "70"})
        Me.lstAges.Location = New System.Drawing.Point(16, 41)
        Me.lstAges.Name = "lstAges"
        Me.lstAges.Size = New System.Drawing.Size(120, 95)
        Me.lstAges.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(158, 41)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 45)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Average Age"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtAvgAge
        '
        Me.txtAvgAge.Location = New System.Drawing.Point(158, 103)
        Me.txtAvgAge.Name = "txtAvgAge"
        Me.txtAvgAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAvgAge.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtAvgAge)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstAges)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstAges As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtAvgAge As TextBox
End Class
