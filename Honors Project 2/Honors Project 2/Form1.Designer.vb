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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBernersLee = New System.Windows.Forms.RadioButton()
        Me.btnLinus = New System.Windows.Forms.RadioButton()
        Me.radRMS = New System.Windows.Forms.RadioButton()
        Me.radGaben = New System.Windows.Forms.RadioButton()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.webAmeno = New System.Windows.Forms.WebBrowser()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnBernersLee)
        Me.GroupBox1.Controls.Add(Me.btnLinus)
        Me.GroupBox1.Controls.Add(Me.radRMS)
        Me.GroupBox1.Controls.Add(Me.radGaben)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnBernersLee
        '
        Me.btnBernersLee.AutoSize = True
        Me.btnBernersLee.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnBernersLee.Location = New System.Drawing.Point(324, 19)
        Me.btnBernersLee.Name = "btnBernersLee"
        Me.btnBernersLee.Size = New System.Drawing.Size(109, 19)
        Me.btnBernersLee.TabIndex = 3
        Me.btnBernersLee.Text = "Tim Berners-Lee"
        Me.btnBernersLee.UseVisualStyleBackColor = True
        '
        'btnLinus
        '
        Me.btnLinus.AutoSize = True
        Me.btnLinus.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnLinus.Location = New System.Drawing.Point(219, 19)
        Me.btnLinus.Name = "btnLinus"
        Me.btnLinus.Size = New System.Drawing.Size(99, 19)
        Me.btnLinus.TabIndex = 2
        Me.btnLinus.Text = "Linus Torvalds"
        Me.btnLinus.UseVisualStyleBackColor = True
        '
        'radRMS
        '
        Me.radRMS.AutoSize = True
        Me.radRMS.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radRMS.Location = New System.Drawing.Point(101, 19)
        Me.radRMS.Name = "radRMS"
        Me.radRMS.Size = New System.Drawing.Size(112, 19)
        Me.radRMS.TabIndex = 1
        Me.radRMS.Text = "Richard Stallman"
        Me.radRMS.UseVisualStyleBackColor = True
        '
        'radGaben
        '
        Me.radGaben.AutoSize = True
        Me.radGaben.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radGaben.Location = New System.Drawing.Point(6, 19)
        Me.radGaben.Name = "radGaben"
        Me.radGaben.Size = New System.Drawing.Size(89, 19)
        Me.radGaben.TabIndex = 0
        Me.radGaben.Text = "Gabe Newell"
        Me.radGaben.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblInfo.Location = New System.Drawing.Point(70, 89)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(443, 128)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'webAmeno
        '
        Me.webAmeno.Location = New System.Drawing.Point(552, 295)
        Me.webAmeno.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webAmeno.Name = "webAmeno"
        Me.webAmeno.Size = New System.Drawing.Size(20, 20)
        Me.webAmeno.TabIndex = 3
        Me.webAmeno.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 327)
        Me.Controls.Add(Me.webAmeno)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Famous Computer Scientists"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBernersLee As System.Windows.Forms.RadioButton
    Friend WithEvents btnLinus As System.Windows.Forms.RadioButton
    Friend WithEvents radRMS As System.Windows.Forms.RadioButton
    Friend WithEvents radGaben As System.Windows.Forms.RadioButton
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents webAmeno As System.Windows.Forms.WebBrowser

End Class
