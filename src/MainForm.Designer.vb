<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CodeList = New System.Windows.Forms.TextBox()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.LinkSlimjet = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'CodeList
        '
        Me.CodeList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodeList.Location = New System.Drawing.Point(13, 39)
        Me.CodeList.Margin = New System.Windows.Forms.Padding(4)
        Me.CodeList.MaxLength = 999999999
        Me.CodeList.Multiline = True
        Me.CodeList.Name = "CodeList"
        Me.CodeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CodeList.Size = New System.Drawing.Size(476, 314)
        Me.CodeList.TabIndex = 0
        '
        'StopBtn
        '
        Me.StopBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopBtn.Location = New System.Drawing.Point(389, 361)
        Me.StopBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(100, 28)
        Me.StopBtn.TabIndex = 1
        Me.StopBtn.Text = "Stop"
        Me.StopBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ASIN List"
        '
        'StartBtn
        '
        Me.StartBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Location = New System.Drawing.Point(389, 361)
        Me.StartBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(100, 28)
        Me.StartBtn.TabIndex = 3
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = False
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.InfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoLabel.Location = New System.Drawing.Point(81, 18)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(41, 17)
        Me.InfoLabel.TabIndex = 4
        Me.InfoLabel.Text = "[0/0]"
        '
        'LinkSlimjet
        '
        Me.LinkSlimjet.AutoSize = True
        Me.LinkSlimjet.LinkColor = System.Drawing.Color.Red
        Me.LinkSlimjet.Location = New System.Drawing.Point(10, 367)
        Me.LinkSlimjet.Name = "LinkSlimjet"
        Me.LinkSlimjet.Size = New System.Drawing.Size(49, 17)
        Me.LinkSlimjet.TabIndex = 5
        Me.LinkSlimjet.TabStop = True
        Me.LinkSlimjet.Text = "Slimjet"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 402)
        Me.Controls.Add(Me.LinkSlimjet)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StopBtn)
        Me.Controls.Add(Me.CodeList)
        Me.Controls.Add(Me.InfoLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amazon Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CodeList As TextBox
    Friend WithEvents StopBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents StartBtn As Button
    Friend WithEvents InfoLabel As Label
    Friend WithEvents LinkSlimjet As LinkLabel
End Class
