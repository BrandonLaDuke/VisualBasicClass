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
        Me.lstStates = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstLastTen = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "States"
        '
        'lstStates
        '
        Me.lstStates.FormattingEnabled = True
        Me.lstStates.Items.AddRange(New Object() {"Delaware", "Pennsylvania", "New Jersey", "Georgia", "Connecticut", "Massechusetts", "Maryland", "South Carolina", "New Hampshire", "Virginia", "New York", "North Carolina", "Rhode Island", "Vermont", "Kentucky", "Tennessee", "Ohio ", "Louisiana", "Indiana", "Mississippi", "Illinois", "Alabama", "Maine", "Missouri", "Arkansas", "Michighan", "Florida", "Texas", "Iowa", "Wisconsin", "California", "Minnesota", "Oregon", "Kansas", "West Virginia", "Nevada", "Nebraska", "Colorodo", "North Dakota", "South Dakota", "Montana", "Washington", "Idaho", "Wyoming", "Utah", "Oklahoma", "New Mexica", "Arizona", "Alaska", "Hawaii"})
        Me.lstStates.Location = New System.Drawing.Point(16, 30)
        Me.lstStates.Name = "lstStates"
        Me.lstStates.Size = New System.Drawing.Size(88, 173)
        Me.lstStates.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Display Last 10 States"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstLastTen
        '
        Me.lstLastTen.FormattingEnabled = True
        Me.lstLastTen.Location = New System.Drawing.Point(171, 69)
        Me.lstLastTen.Name = "lstLastTen"
        Me.lstLastTen.Size = New System.Drawing.Size(101, 134)
        Me.lstLastTen.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 224)
        Me.Controls.Add(Me.lstLastTen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstStates)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstStates As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lstLastTen As ListBox
End Class
