<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class table
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstTable = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(13, 13)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(259, 55)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Multiplication Table"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstTable
        '
        Me.lstTable.FormattingEnabled = True
        Me.lstTable.Location = New System.Drawing.Point(13, 75)
        Me.lstTable.Name = "lstTable"
        Me.lstTable.Size = New System.Drawing.Size(259, 160)
        Me.lstTable.TabIndex = 1
        '
        'table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lstTable)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "table"
        Me.Text = "Multiplication Table"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstTable As ListBox
End Class
