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
        Me.btnAbs = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WellMetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.webWellMet = New System.Windows.Forms.WebBrowser()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInputPrompt = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAbs
        '
        Me.btnAbs.Location = New System.Drawing.Point(90, 64)
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.Size = New System.Drawing.Size(91, 23)
        Me.btnAbs.TabIndex = 0
        Me.btnAbs.Text = "Absolute Value"
        Me.btnAbs.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Location = New System.Drawing.Point(90, 93)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(91, 23)
        Me.btnSqrt.TabIndex = 1
        Me.btnSqrt.Text = "Square Root"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(90, 122)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(91, 23)
        Me.btnSign.TabIndex = 2
        Me.btnSign.Text = "Sign"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnRound
        '
        Me.btnRound.Location = New System.Drawing.Point(90, 151)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(91, 23)
        Me.btnRound.TabIndex = 3
        Me.btnRound.Text = "Round"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WellMetToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WellMetToolStripMenuItem
        '
        Me.WellMetToolStripMenuItem.Name = "WellMetToolStripMenuItem"
        Me.WellMetToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.WellMetToolStripMenuItem.Text = "Well Met."
        '
        'webWellMet
        '
        Me.webWellMet.Location = New System.Drawing.Point(221, 201)
        Me.webWellMet.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webWellMet.Name = "webWellMet"
        Me.webWellMet.Size = New System.Drawing.Size(250, 250)
        Me.webWellMet.TabIndex = 5
        Me.webWellMet.Visible = False
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(12, 177)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(260, 76)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(136, 38)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 7
        '
        'lblInputPrompt
        '
        Me.lblInputPrompt.AutoSize = True
        Me.lblInputPrompt.Location = New System.Drawing.Point(49, 41)
        Me.lblInputPrompt.Name = "lblInputPrompt"
        Me.lblInputPrompt.Size = New System.Drawing.Size(81, 13)
        Me.lblInputPrompt.TabIndex = 8
        Me.lblInputPrompt.Text = "Put in a number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblInputPrompt)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.webWellMet)
        Me.Controls.Add(Me.btnRound)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnAbs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Maths"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAbs As System.Windows.Forms.Button
    Friend WithEvents btnSqrt As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents btnRound As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents WellMetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents webWellMet As System.Windows.Forms.WebBrowser
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblInputPrompt As System.Windows.Forms.Label

End Class
