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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAnalize = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name first and last only:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(139, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(345, 20)
        Me.txtName.TabIndex = 1
        '
        'btnAnalize
        '
        Me.btnAnalize.Location = New System.Drawing.Point(16, 61)
        Me.btnAnalize.Name = "btnAnalize"
        Me.btnAnalize.Size = New System.Drawing.Size(115, 37)
        Me.btnAnalize.TabIndex = 2
        Me.btnAnalize.Text = "Analize Name"
        Me.btnAnalize.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(139, 61)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(345, 43)
        Me.lstResults.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 261)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnAnalize)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAnalize As Button
    Friend WithEvents lstResults As ListBox
End Class
