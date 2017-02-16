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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtContinent = New System.Windows.Forms.TextBox()
        Me.txtPop = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtDensity = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(33, 13)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(201, 42)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Data"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name of Country:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Continent:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Population:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Area:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Density:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(129, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 6
        '
        'txtContinent
        '
        Me.txtContinent.Location = New System.Drawing.Point(129, 89)
        Me.txtContinent.Name = "txtContinent"
        Me.txtContinent.Size = New System.Drawing.Size(100, 20)
        Me.txtContinent.TabIndex = 7
        '
        'txtPop
        '
        Me.txtPop.Location = New System.Drawing.Point(129, 116)
        Me.txtPop.Name = "txtPop"
        Me.txtPop.Size = New System.Drawing.Size(100, 20)
        Me.txtPop.TabIndex = 8
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(129, 143)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(100, 20)
        Me.txtArea.TabIndex = 9
        '
        'txtDensity
        '
        Me.txtDensity.Location = New System.Drawing.Point(129, 170)
        Me.txtDensity.Name = "txtDensity"
        Me.txtDensity.Size = New System.Drawing.Size(100, 20)
        Me.txtDensity.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtDensity)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtPop)
        Me.Controls.Add(Me.txtContinent)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtContinent As TextBox
    Friend WithEvents txtPop As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtDensity As TextBox
End Class
