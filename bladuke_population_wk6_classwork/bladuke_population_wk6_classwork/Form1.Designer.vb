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
        Me.btnPopulation = New System.Windows.Forms.Button()
        Me.lstPopulation = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnPopulation
        '
        Me.btnPopulation.Location = New System.Drawing.Point(59, 12)
        Me.btnPopulation.Name = "btnPopulation"
        Me.btnPopulation.Size = New System.Drawing.Size(120, 38)
        Me.btnPopulation.TabIndex = 0
        Me.btnPopulation.Text = "Display Population"
        Me.btnPopulation.UseVisualStyleBackColor = True
        '
        'lstPopulation
        '
        Me.lstPopulation.FormattingEnabled = True
        Me.lstPopulation.Location = New System.Drawing.Point(59, 56)
        Me.lstPopulation.Name = "lstPopulation"
        Me.lstPopulation.Size = New System.Drawing.Size(120, 95)
        Me.lstPopulation.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 179)
        Me.Controls.Add(Me.lstPopulation)
        Me.Controls.Add(Me.btnPopulation)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPopulation As Button
    Friend WithEvents lstPopulation As ListBox
End Class
