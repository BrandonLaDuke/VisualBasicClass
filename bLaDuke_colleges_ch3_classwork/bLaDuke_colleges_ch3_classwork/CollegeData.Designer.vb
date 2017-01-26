<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollegeData
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
        Me.lstColleges = New System.Windows.Forms.ListBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstColleges
        '
        Me.lstColleges.FormattingEnabled = True
        Me.lstColleges.Location = New System.Drawing.Point(23, 26)
        Me.lstColleges.Name = "lstColleges"
        Me.lstColleges.Size = New System.Drawing.Size(398, 56)
        Me.lstColleges.TabIndex = 0
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(23, 87)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(398, 42)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display Data"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'CollegeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 261)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lstColleges)
        Me.Name = "CollegeData"
        Me.Text = "College Data"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstColleges As ListBox
    Friend WithEvents btnDisplay As Button
End Class
