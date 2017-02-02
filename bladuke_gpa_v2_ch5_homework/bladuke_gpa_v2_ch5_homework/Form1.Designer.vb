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
        Me.grades = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbCredits = New System.Windows.Forms.TextBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grade (A, B, ...)"
        '
        'grades
        '
        Me.grades.Location = New System.Drawing.Point(99, 10)
        Me.grades.Name = "grades"
        Me.grades.Size = New System.Drawing.Size(100, 20)
        Me.grades.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Credit Hours"
        '
        'mtbCredits
        '
        Me.mtbCredits.Location = New System.Drawing.Point(99, 30)
        Me.mtbCredits.Name = "mtbCredits"
        Me.mtbCredits.Size = New System.Drawing.Size(100, 20)
        Me.mtbCredits.TabIndex = 3
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(19, 63)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Record this course"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(101, 63)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(47, 113)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(100, 20)
        Me.txtGPA.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 340)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.mtbCredits)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grades)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grades As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbCredits As TextBox
    Friend WithEvents btnRecord As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtGPA As TextBox
End Class
