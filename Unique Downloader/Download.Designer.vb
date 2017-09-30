<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Download
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
        Me.components = New System.ComponentModel.Container()
        Me.Link = New System.Windows.Forms.Label()
        Me.filelength = New System.Windows.Forms.Label()
        Me.downloadedbytes = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.percentage = New System.Windows.Forms.Label()
        Me.target = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PB3 = New System.Windows.Forms.ProgressBar()
        Me.PB2 = New System.Windows.Forms.ProgressBar()
        Me.PB1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Downloadedpart1 = New System.Windows.Forms.Label()
        Me.Percentage1 = New System.Windows.Forms.Label()
        Me.Status1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.downloadedpart2 = New System.Windows.Forms.Label()
        Me.percentage2 = New System.Windows.Forms.Label()
        Me.Status2 = New System.Windows.Forms.Label()
        Me.downloadedpart3 = New System.Windows.Forms.Label()
        Me.percentage3 = New System.Windows.Forms.Label()
        Me.Status3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Status4 = New System.Windows.Forms.Label()
        Me.percentage4 = New System.Windows.Forms.Label()
        Me.downloadedpart4 = New System.Windows.Forms.Label()
        Me.Status5 = New System.Windows.Forms.Label()
        Me.percentage5 = New System.Windows.Forms.Label()
        Me.downloadedpart5 = New System.Windows.Forms.Label()
        Me.PB5 = New System.Windows.Forms.ProgressBar()
        Me.PB4 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Link
        '
        Me.Link.AutoSize = True
        Me.Link.Location = New System.Drawing.Point(12, 19)
        Me.Link.Name = "Link"
        Me.Link.Size = New System.Drawing.Size(29, 13)
        Me.Link.TabIndex = 1
        Me.Link.Text = "URL"
        '
        'filelength
        '
        Me.filelength.AutoSize = True
        Me.filelength.Location = New System.Drawing.Point(12, 59)
        Me.filelength.Name = "filelength"
        Me.filelength.Size = New System.Drawing.Size(44, 13)
        Me.filelength.TabIndex = 2
        Me.filelength.Text = "File size"
        '
        'downloadedbytes
        '
        Me.downloadedbytes.AutoSize = True
        Me.downloadedbytes.Location = New System.Drawing.Point(12, 134)
        Me.downloadedbytes.Name = "downloadedbytes"
        Me.downloadedbytes.Size = New System.Drawing.Size(67, 13)
        Me.downloadedbytes.TabIndex = 3
        Me.downloadedbytes.Text = "Downloaded"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 243)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(689, 20)
        Me.ProgressBar1.TabIndex = 6
        '
        'percentage
        '
        Me.percentage.AutoSize = True
        Me.percentage.Location = New System.Drawing.Point(12, 170)
        Me.percentage.Name = "percentage"
        Me.percentage.Size = New System.Drawing.Size(62, 13)
        Me.percentage.TabIndex = 7
        Me.percentage.Text = "Percentage"
        '
        'target
        '
        Me.target.AutoSize = True
        Me.target.Location = New System.Drawing.Point(12, 98)
        Me.target.Name = "target"
        Me.target.Size = New System.Drawing.Size(38, 13)
        Me.target.TabIndex = 8
        Me.target.Text = "Target"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "State"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(552, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Hide Details"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PB3
        '
        Me.PB3.Location = New System.Drawing.Point(282, 298)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(135, 20)
        Me.PB3.TabIndex = 24
        '
        'PB2
        '
        Me.PB2.Location = New System.Drawing.Point(147, 298)
        Me.PB2.Name = "PB2"
        Me.PB2.Size = New System.Drawing.Size(135, 20)
        Me.PB2.TabIndex = 25
        '
        'PB1
        '
        Me.PB1.Location = New System.Drawing.Point(12, 298)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(135, 20)
        Me.PB1.TabIndex = 26
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Sr.No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(147, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Downloaded"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Percentage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(588, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "1."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 383)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "2."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "3."
        '
        'Downloadedpart1
        '
        Me.Downloadedpart1.AutoSize = True
        Me.Downloadedpart1.Location = New System.Drawing.Point(147, 356)
        Me.Downloadedpart1.Name = "Downloadedpart1"
        Me.Downloadedpart1.Size = New System.Drawing.Size(0, 13)
        Me.Downloadedpart1.TabIndex = 38
        '
        'Percentage1
        '
        Me.Percentage1.AutoSize = True
        Me.Percentage1.Location = New System.Drawing.Point(388, 356)
        Me.Percentage1.Name = "Percentage1"
        Me.Percentage1.Size = New System.Drawing.Size(0, 13)
        Me.Percentage1.TabIndex = 39
        '
        'Status1
        '
        Me.Status1.AutoSize = True
        Me.Status1.Location = New System.Drawing.Point(588, 356)
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(0, 13)
        Me.Status1.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'downloadedpart2
        '
        Me.downloadedpart2.AutoSize = True
        Me.downloadedpart2.Location = New System.Drawing.Point(147, 383)
        Me.downloadedpart2.Name = "downloadedpart2"
        Me.downloadedpart2.Size = New System.Drawing.Size(0, 13)
        Me.downloadedpart2.TabIndex = 42
        '
        'percentage2
        '
        Me.percentage2.AutoSize = True
        Me.percentage2.Location = New System.Drawing.Point(388, 383)
        Me.percentage2.Name = "percentage2"
        Me.percentage2.Size = New System.Drawing.Size(0, 13)
        Me.percentage2.TabIndex = 43
        '
        'Status2
        '
        Me.Status2.AutoSize = True
        Me.Status2.Location = New System.Drawing.Point(588, 383)
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(0, 13)
        Me.Status2.TabIndex = 44
        '
        'downloadedpart3
        '
        Me.downloadedpart3.AutoSize = True
        Me.downloadedpart3.Location = New System.Drawing.Point(147, 414)
        Me.downloadedpart3.Name = "downloadedpart3"
        Me.downloadedpart3.Size = New System.Drawing.Size(0, 13)
        Me.downloadedpart3.TabIndex = 45
        '
        'percentage3
        '
        Me.percentage3.AutoSize = True
        Me.percentage3.Location = New System.Drawing.Point(388, 414)
        Me.percentage3.Name = "percentage3"
        Me.percentage3.Size = New System.Drawing.Size(0, 13)
        Me.percentage3.TabIndex = 46
        '
        'Status3
        '
        Me.Status3.AutoSize = True
        Me.Status3.Location = New System.Drawing.Point(588, 414)
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(0, 13)
        Me.Status3.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "4."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 471)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "5."
        '
        'Status4
        '
        Me.Status4.AutoSize = True
        Me.Status4.Location = New System.Drawing.Point(588, 442)
        Me.Status4.Name = "Status4"
        Me.Status4.Size = New System.Drawing.Size(0, 13)
        Me.Status4.TabIndex = 52
        '
        'percentage4
        '
        Me.percentage4.AutoSize = True
        Me.percentage4.Location = New System.Drawing.Point(388, 442)
        Me.percentage4.Name = "percentage4"
        Me.percentage4.Size = New System.Drawing.Size(0, 13)
        Me.percentage4.TabIndex = 51
        '
        'downloadedpart4
        '
        Me.downloadedpart4.AutoSize = True
        Me.downloadedpart4.Location = New System.Drawing.Point(147, 442)
        Me.downloadedpart4.Name = "downloadedpart4"
        Me.downloadedpart4.Size = New System.Drawing.Size(0, 13)
        Me.downloadedpart4.TabIndex = 50
        '
        'Status5
        '
        Me.Status5.AutoSize = True
        Me.Status5.Location = New System.Drawing.Point(588, 471)
        Me.Status5.Name = "Status5"
        Me.Status5.Size = New System.Drawing.Size(0, 13)
        Me.Status5.TabIndex = 55
        '
        'percentage5
        '
        Me.percentage5.AutoSize = True
        Me.percentage5.Location = New System.Drawing.Point(388, 471)
        Me.percentage5.Name = "percentage5"
        Me.percentage5.Size = New System.Drawing.Size(0, 13)
        Me.percentage5.TabIndex = 54
        '
        'downloadedpart5
        '
        Me.downloadedpart5.AutoSize = True
        Me.downloadedpart5.Location = New System.Drawing.Point(147, 471)
        Me.downloadedpart5.Name = "downloadedpart5"
        Me.downloadedpart5.Size = New System.Drawing.Size(0, 13)
        Me.downloadedpart5.TabIndex = 53
        '
        'PB5
        '
        Me.PB5.Location = New System.Drawing.Point(552, 298)
        Me.PB5.Name = "PB5"
        Me.PB5.Size = New System.Drawing.Size(149, 20)
        Me.PB5.TabIndex = 56
        '
        'PB4
        '
        Me.PB4.Location = New System.Drawing.Point(417, 298)
        Me.PB4.Name = "PB4"
        Me.PB4.Size = New System.Drawing.Size(135, 20)
        Me.PB4.TabIndex = 57
        '
        'Download
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(713, 493)
        Me.Controls.Add(Me.PB4)
        Me.Controls.Add(Me.PB5)
        Me.Controls.Add(Me.Status5)
        Me.Controls.Add(Me.percentage5)
        Me.Controls.Add(Me.downloadedpart5)
        Me.Controls.Add(Me.Status4)
        Me.Controls.Add(Me.percentage4)
        Me.Controls.Add(Me.downloadedpart4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Status3)
        Me.Controls.Add(Me.percentage3)
        Me.Controls.Add(Me.downloadedpart3)
        Me.Controls.Add(Me.Status2)
        Me.Controls.Add(Me.percentage2)
        Me.Controls.Add(Me.downloadedpart2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Status1)
        Me.Controls.Add(Me.Percentage1)
        Me.Controls.Add(Me.Downloadedpart1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.PB2)
        Me.Controls.Add(Me.PB3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.target)
        Me.Controls.Add(Me.percentage)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.downloadedbytes)
        Me.Controls.Add(Me.filelength)
        Me.Controls.Add(Me.Link)
        Me.MaximumSize = New System.Drawing.Size(729, 532)
        Me.MinimumSize = New System.Drawing.Size(729, 355)
        Me.Name = "Download"
        Me.Text = "Download"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Link As System.Windows.Forms.Label
    Friend WithEvents filelength As System.Windows.Forms.Label
    Friend WithEvents downloadedbytes As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents percentage As System.Windows.Forms.Label
    Friend WithEvents target As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PB3 As System.Windows.Forms.ProgressBar
    Friend WithEvents PB2 As System.Windows.Forms.ProgressBar
    Friend WithEvents PB1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Downloadedpart1 As System.Windows.Forms.Label
    Friend WithEvents Percentage1 As System.Windows.Forms.Label
    Friend WithEvents Status1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents downloadedpart2 As System.Windows.Forms.Label
    Friend WithEvents percentage2 As System.Windows.Forms.Label
    Friend WithEvents Status2 As System.Windows.Forms.Label
    Friend WithEvents downloadedpart3 As System.Windows.Forms.Label
    Friend WithEvents percentage3 As System.Windows.Forms.Label
    Friend WithEvents Status3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Status4 As System.Windows.Forms.Label
    Friend WithEvents percentage4 As System.Windows.Forms.Label
    Friend WithEvents downloadedpart4 As System.Windows.Forms.Label
    Friend WithEvents Status5 As System.Windows.Forms.Label
    Friend WithEvents percentage5 As System.Windows.Forms.Label
    Friend WithEvents downloadedpart5 As System.Windows.Forms.Label
    Friend WithEvents PB5 As System.Windows.Forms.ProgressBar
    Friend WithEvents PB4 As System.Windows.Forms.ProgressBar
End Class
