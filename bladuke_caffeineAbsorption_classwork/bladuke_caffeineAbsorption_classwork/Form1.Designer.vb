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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt65 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOne24 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMany24 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate Values"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "One cup. When will 65mg remain?"
        '
        'txt65
        '
        Me.txt65.Location = New System.Drawing.Point(189, 48)
        Me.txt65.Name = "txt65"
        Me.txt65.Size = New System.Drawing.Size(100, 20)
        Me.txt65.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "One cup. Quarterly after 24 hours:"
        '
        'txtOne24
        '
        Me.txtOne24.Location = New System.Drawing.Point(189, 78)
        Me.txtOne24.Name = "txtOne24"
        Me.txtOne24.Size = New System.Drawing.Size(100, 20)
        Me.txtOne24.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hourly Cups. Quarterly after 24 hours:"
        '
        'txtMany24
        '
        Me.txtMany24.Location = New System.Drawing.Point(203, 106)
        Me.txtMany24.Name = "txtMany24"
        Me.txtMany24.Size = New System.Drawing.Size(100, 20)
        Me.txtMany24.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 261)
        Me.Controls.Add(Me.txtMany24)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOne24)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt65)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt65 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOne24 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMany24 As TextBox
End Class
