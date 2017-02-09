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
        Me.txtPhrase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPhrase
        '
        Me.txtPhrase.Location = New System.Drawing.Point(13, 36)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(259, 20)
        Me.txtPhrase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a word of phrase:"
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(13, 72)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(259, 43)
        Me.btnDetermine.TabIndex = 2
        Me.btnDetermine.Text = "Calculate if Palindrome"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(91, 121)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhrase)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhrase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDetermine As Button
    Friend WithEvents txtResult As TextBox
End Class
