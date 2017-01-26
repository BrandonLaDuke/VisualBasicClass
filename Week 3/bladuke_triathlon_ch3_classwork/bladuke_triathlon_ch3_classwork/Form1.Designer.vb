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
        Me.hrCyl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hrRun = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hrSwm = New System.Windows.Forms.TextBox()
        Me.computeWL = New System.Windows.Forms.Button()
        Me.resultsTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of hours cycling:"
        '
        'hrCyl
        '
        Me.hrCyl.Location = New System.Drawing.Point(146, 33)
        Me.hrCyl.Name = "hrCyl"
        Me.hrCyl.Size = New System.Drawing.Size(100, 20)
        Me.hrCyl.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of hours running:"
        '
        'hrRun
        '
        Me.hrRun.Location = New System.Drawing.Point(146, 65)
        Me.hrRun.Name = "hrRun"
        Me.hrRun.Size = New System.Drawing.Size(100, 20)
        Me.hrRun.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of hours swimming:"
        '
        'hrSwm
        '
        Me.hrSwm.Location = New System.Drawing.Point(146, 97)
        Me.hrSwm.Name = "hrSwm"
        Me.hrSwm.Size = New System.Drawing.Size(100, 20)
        Me.hrSwm.TabIndex = 5
        '
        'computeWL
        '
        Me.computeWL.Location = New System.Drawing.Point(21, 139)
        Me.computeWL.Name = "computeWL"
        Me.computeWL.Size = New System.Drawing.Size(234, 43)
        Me.computeWL.TabIndex = 6
        Me.computeWL.Text = "Compute Weight Loss"
        Me.computeWL.UseVisualStyleBackColor = True
        '
        'resultsTxt
        '
        Me.resultsTxt.Location = New System.Drawing.Point(21, 198)
        Me.resultsTxt.Name = "resultsTxt"
        Me.resultsTxt.Size = New System.Drawing.Size(225, 20)
        Me.resultsTxt.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.resultsTxt)
        Me.Controls.Add(Me.computeWL)
        Me.Controls.Add(Me.hrSwm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hrRun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hrCyl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents hrCyl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents hrRun As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents hrSwm As TextBox
    Friend WithEvents computeWL As Button
    Friend WithEvents resultsTxt As TextBox
End Class
