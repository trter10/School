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
        Me.webAmeno = New System.Windows.Forms.WebBrowser()
        Me.picDoge = New System.Windows.Forms.PictureBox()
        Me.lblClick = New System.Windows.Forms.Label()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JosesCrustToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSettings = New System.Windows.Forms.GroupBox()
        Me.chkLog = New System.Windows.Forms.CheckBox()
        Me.chkCrazy = New System.Windows.Forms.CheckBox()
        Me.chkMusic = New System.Windows.Forms.CheckBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picDoge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'webAmeno
        '
        Me.webAmeno.Location = New System.Drawing.Point(552, 27)
        Me.webAmeno.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webAmeno.Name = "webAmeno"
        Me.webAmeno.Size = New System.Drawing.Size(20, 20)
        Me.webAmeno.TabIndex = 0
        Me.webAmeno.Url = New System.Uri("http://www.youtube.com/embed/RkZkekS8NQU?autoplay=1&loop=1", System.UriKind.Absolute)
        Me.webAmeno.Visible = False
        '
        'picDoge
        '
        Me.picDoge.Image = Global.Proyecto_tres.My.Resources.Resources.doge
        Me.picDoge.Location = New System.Drawing.Point(246, 153)
        Me.picDoge.Name = "picDoge"
        Me.picDoge.Size = New System.Drawing.Size(108, 108)
        Me.picDoge.TabIndex = 1
        Me.picDoge.TabStop = False
        '
        'lblClick
        '
        Me.lblClick.AutoSize = True
        Me.lblClick.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblClick.Location = New System.Drawing.Point(276, 264)
        Me.lblClick.Name = "lblClick"
        Me.lblClick.Size = New System.Drawing.Size(49, 15)
        Me.lblClick.TabIndex = 2
        Me.lblClick.Text = "click me"
        '
        'lblTimes
        '
        Me.lblTimes.AutoSize = True
        Me.lblTimes.BackColor = System.Drawing.Color.Transparent
        Me.lblTimes.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblTimes.Location = New System.Drawing.Point(12, 438)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(83, 15)
        Me.lblTimes.TabIndex = 3
        Me.lblTimes.Text = "Times doged: 0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.JosesCrustToolStripMenuItem, Me.NoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'JosesCrustToolStripMenuItem
        '
        Me.JosesCrustToolStripMenuItem.Name = "JosesCrustToolStripMenuItem"
        Me.JosesCrustToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.JosesCrustToolStripMenuItem.Text = "break everything"
        '
        'grpSettings
        '
        Me.grpSettings.BackColor = System.Drawing.Color.Transparent
        Me.grpSettings.Controls.Add(Me.chkLog)
        Me.grpSettings.Controls.Add(Me.chkCrazy)
        Me.grpSettings.Controls.Add(Me.chkMusic)
        Me.grpSettings.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.grpSettings.Location = New System.Drawing.Point(431, 379)
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.Size = New System.Drawing.Size(141, 74)
        Me.grpSettings.TabIndex = 5
        Me.grpSettings.TabStop = False
        Me.grpSettings.Text = "Settings"
        '
        'chkLog
        '
        Me.chkLog.AutoSize = True
        Me.chkLog.Location = New System.Drawing.Point(16, 48)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(44, 19)
        Me.chkLog.TabIndex = 2
        Me.chkLog.Text = "Log"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'chkCrazy
        '
        Me.chkCrazy.AutoSize = True
        Me.chkCrazy.Location = New System.Drawing.Point(80, 24)
        Me.chkCrazy.Name = "chkCrazy"
        Me.chkCrazy.Size = New System.Drawing.Size(56, 19)
        Me.chkCrazy.TabIndex = 1
        Me.chkCrazy.Text = "Crazy"
        Me.chkCrazy.UseVisualStyleBackColor = True
        '
        'chkMusic
        '
        Me.chkMusic.AutoSize = True
        Me.chkMusic.Checked = True
        Me.chkMusic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMusic.Location = New System.Drawing.Point(16, 23)
        Me.chkMusic.Name = "chkMusic"
        Me.chkMusic.Size = New System.Drawing.Size(57, 19)
        Me.chkMusic.TabIndex = 0
        Me.chkMusic.Text = "Music"
        Me.chkMusic.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.txtLog.Location = New System.Drawing.Point(279, 386)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(137, 67)
        Me.txtLog.TabIndex = 6
        Me.txtLog.Visible = False
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(33, 20)
        Me.NoToolStripMenuItem.Text = "no"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.grpSettings)
        Me.Controls.Add(Me.lblTimes)
        Me.Controls.Add(Me.lblClick)
        Me.Controls.Add(Me.webAmeno)
        Me.Controls.Add(Me.picDoge)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "doge"
        CType(Me.picDoge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents webAmeno As System.Windows.Forms.WebBrowser
    Friend WithEvents picDoge As System.Windows.Forms.PictureBox
    Friend WithEvents lblClick As System.Windows.Forms.Label
    Friend WithEvents lblTimes As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpSettings As System.Windows.Forms.GroupBox
    Friend WithEvents chkMusic As System.Windows.Forms.CheckBox
    Friend WithEvents chkCrazy As System.Windows.Forms.CheckBox
    Friend WithEvents chkLog As System.Windows.Forms.CheckBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents JosesCrustToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
