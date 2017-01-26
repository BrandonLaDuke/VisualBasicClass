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
        Me.btnRates = New System.Windows.Forms.Button()
        Me.lstRentalRates = New System.Windows.Forms.ListBox()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDur = New System.Windows.Forms.TextBox()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRates
        '
        Me.btnRates.Location = New System.Drawing.Point(19, 25)
        Me.btnRates.Name = "btnRates"
        Me.btnRates.Size = New System.Drawing.Size(235, 82)
        Me.btnRates.TabIndex = 0
        Me.btnRates.Text = "Display Rental Rates"
        Me.btnRates.UseVisualStyleBackColor = True
        '
        'lstRentalRates
        '
        Me.lstRentalRates.FormattingEnabled = True
        Me.lstRentalRates.Location = New System.Drawing.Point(261, 25)
        Me.lstRentalRates.Name = "lstRentalRates"
        Me.lstRentalRates.Size = New System.Drawing.Size(366, 82)
        Me.lstRentalRates.TabIndex = 1
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.Location = New System.Drawing.Point(261, 114)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(366, 147)
        Me.lstBill.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select an item (1, 2, or 3):"
        '
        'itemNum
        '
        Me.itemNum.Location = New System.Drawing.Point(158, 112)
        Me.itemNum.Name = "itemNum"
        Me.itemNum.Size = New System.Drawing.Size(19, 20)
        Me.itemNum.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select a duration (H or F):"
        '
        'txtDur
        '
        Me.txtDur.Location = New System.Drawing.Point(158, 138)
        Me.txtDur.Name = "txtDur"
        Me.txtDur.Size = New System.Drawing.Size(19, 20)
        Me.txtDur.TabIndex = 6
        '
        'btnBill
        '
        Me.btnBill.Location = New System.Drawing.Point(22, 164)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(232, 97)
        Me.btnBill.TabIndex = 7
        Me.btnBill.Text = "Display Customer Bill"
        Me.btnBill.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 324)
        Me.Controls.Add(Me.btnBill)
        Me.Controls.Add(Me.txtDur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.itemNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.lstRentalRates)
        Me.Controls.Add(Me.btnRates)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRates As Button
    Friend WithEvents lstRentalRates As ListBox
    Friend WithEvents lstBill As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents itemNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDur As TextBox
    Friend WithEvents btnBill As Button
End Class
