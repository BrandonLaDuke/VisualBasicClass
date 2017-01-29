<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GPA
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
        Me.class1Grade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.class1CrHours = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.class2CrHours = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.class2Grade = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.class3CrHours = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.class3Grade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.class4CrHours = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.class4Grade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grade Class 1:"
        '
        'class1Grade
        '
        Me.class1Grade.Location = New System.Drawing.Point(96, 10)
        Me.class1Grade.Name = "class1Grade"
        Me.class1Grade.Size = New System.Drawing.Size(100, 20)
        Me.class1Grade.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Credit Hours:"
        '
        'class1CrHours
        '
        Me.class1CrHours.Location = New System.Drawing.Point(289, 10)
        Me.class1CrHours.Name = "class1CrHours"
        Me.class1CrHours.Size = New System.Drawing.Size(100, 20)
        Me.class1CrHours.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(16, 123)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(373, 46)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate GPA"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "GPA: "
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(183, 175)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(100, 20)
        Me.txtGPA.TabIndex = 7
        '
        'class2CrHours
        '
        Me.class2CrHours.Location = New System.Drawing.Point(289, 36)
        Me.class2CrHours.Name = "class2CrHours"
        Me.class2CrHours.Size = New System.Drawing.Size(100, 20)
        Me.class2CrHours.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Credit Hours:"
        '
        'class2Grade
        '
        Me.class2Grade.Location = New System.Drawing.Point(96, 36)
        Me.class2Grade.Name = "class2Grade"
        Me.class2Grade.Size = New System.Drawing.Size(100, 20)
        Me.class2Grade.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Grade Class 2"
        '
        'class3CrHours
        '
        Me.class3CrHours.Location = New System.Drawing.Point(289, 62)
        Me.class3CrHours.Name = "class3CrHours"
        Me.class3CrHours.Size = New System.Drawing.Size(100, 20)
        Me.class3CrHours.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Credit Hours:"
        '
        'class3Grade
        '
        Me.class3Grade.Location = New System.Drawing.Point(96, 62)
        Me.class3Grade.Name = "class3Grade"
        Me.class3Grade.Size = New System.Drawing.Size(100, 20)
        Me.class3Grade.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Grade Class 3:"
        '
        'class4CrHours
        '
        Me.class4CrHours.Location = New System.Drawing.Point(289, 88)
        Me.class4CrHours.Name = "class4CrHours"
        Me.class4CrHours.Size = New System.Drawing.Size(100, 20)
        Me.class4CrHours.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Credit Hours:"
        '
        'class4Grade
        '
        Me.class4Grade.Location = New System.Drawing.Point(96, 88)
        Me.class4Grade.Name = "class4Grade"
        Me.class4Grade.Size = New System.Drawing.Size(100, 20)
        Me.class4Grade.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Grade Class 4:"
        '
        'GPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 208)
        Me.Controls.Add(Me.class4CrHours)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.class4Grade)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.class3CrHours)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.class3Grade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.class2CrHours)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.class2Grade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.class1CrHours)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.class1Grade)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GPA"
        Me.Text = "GPA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents class1Grade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents class1CrHours As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents class2CrHours As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents class2Grade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents class3CrHours As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents class3Grade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents class4CrHours As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents class4Grade As TextBox
    Friend WithEvents Label9 As Label
End Class
