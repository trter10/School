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
        Me.lblFirstOperandPrompt = New System.Windows.Forms.Label()
        Me.lblSecondOperandPrompt = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.grpOperators = New System.Windows.Forms.GroupBox()
        Me.radSubtract = New System.Windows.Forms.RadioButton()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.radMod = New System.Windows.Forms.RadioButton()
        Me.radIntDivide = New System.Windows.Forms.RadioButton()
        Me.radDivide = New System.Windows.Forms.RadioButton()
        Me.radMultiply = New System.Windows.Forms.RadioButton()
        Me.radPow = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblFinalResult = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpOperators.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstOperandPrompt
        '
        Me.lblFirstOperandPrompt.AutoSize = True
        Me.lblFirstOperandPrompt.Location = New System.Drawing.Point(20, 34)
        Me.lblFirstOperandPrompt.Name = "lblFirstOperandPrompt"
        Me.lblFirstOperandPrompt.Size = New System.Drawing.Size(70, 13)
        Me.lblFirstOperandPrompt.TabIndex = 0
        Me.lblFirstOperandPrompt.Text = "First Operand"
        '
        'lblSecondOperandPrompt
        '
        Me.lblSecondOperandPrompt.AutoSize = True
        Me.lblSecondOperandPrompt.Location = New System.Drawing.Point(215, 34)
        Me.lblSecondOperandPrompt.Name = "lblSecondOperandPrompt"
        Me.lblSecondOperandPrompt.Size = New System.Drawing.Size(88, 13)
        Me.lblSecondOperandPrompt.TabIndex = 1
        Me.lblSecondOperandPrompt.Text = "Second Operand"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(96, 31)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 2
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(309, 31)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(100, 20)
        Me.txtSecond.TabIndex = 3
        '
        'grpOperators
        '
        Me.grpOperators.Controls.Add(Me.radSubtract)
        Me.grpOperators.Controls.Add(Me.radAdd)
        Me.grpOperators.Controls.Add(Me.radMod)
        Me.grpOperators.Controls.Add(Me.radIntDivide)
        Me.grpOperators.Controls.Add(Me.radDivide)
        Me.grpOperators.Controls.Add(Me.radMultiply)
        Me.grpOperators.Controls.Add(Me.radPow)
        Me.grpOperators.Location = New System.Drawing.Point(23, 112)
        Me.grpOperators.Name = "grpOperators"
        Me.grpOperators.Size = New System.Drawing.Size(386, 111)
        Me.grpOperators.TabIndex = 4
        Me.grpOperators.TabStop = False
        Me.grpOperators.Text = "Select an Operator"
        '
        'radSubtract
        '
        Me.radSubtract.AutoSize = True
        Me.radSubtract.Location = New System.Drawing.Point(297, 48)
        Me.radSubtract.Name = "radSubtract"
        Me.radSubtract.Size = New System.Drawing.Size(28, 17)
        Me.radSubtract.TabIndex = 6
        Me.radSubtract.TabStop = True
        Me.radSubtract.Text = "-"
        Me.radSubtract.UseVisualStyleBackColor = True
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(260, 48)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(31, 17)
        Me.radAdd.TabIndex = 5
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "+"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'radMod
        '
        Me.radMod.AutoSize = True
        Me.radMod.Location = New System.Drawing.Point(208, 48)
        Me.radMod.Name = "radMod"
        Me.radMod.Size = New System.Drawing.Size(46, 17)
        Me.radMod.TabIndex = 4
        Me.radMod.TabStop = True
        Me.radMod.Text = "Mod"
        Me.radMod.UseVisualStyleBackColor = True
        '
        'radIntDivide
        '
        Me.radIntDivide.AutoSize = True
        Me.radIntDivide.Location = New System.Drawing.Point(172, 48)
        Me.radIntDivide.Name = "radIntDivide"
        Me.radIntDivide.Size = New System.Drawing.Size(30, 17)
        Me.radIntDivide.TabIndex = 3
        Me.radIntDivide.TabStop = True
        Me.radIntDivide.Text = "\"
        Me.radIntDivide.UseVisualStyleBackColor = True
        '
        'radDivide
        '
        Me.radDivide.AutoSize = True
        Me.radDivide.Location = New System.Drawing.Point(136, 48)
        Me.radDivide.Name = "radDivide"
        Me.radDivide.Size = New System.Drawing.Size(30, 17)
        Me.radDivide.TabIndex = 2
        Me.radDivide.TabStop = True
        Me.radDivide.Text = "/"
        Me.radDivide.UseVisualStyleBackColor = True
        '
        'radMultiply
        '
        Me.radMultiply.AutoSize = True
        Me.radMultiply.Location = New System.Drawing.Point(101, 48)
        Me.radMultiply.Name = "radMultiply"
        Me.radMultiply.Size = New System.Drawing.Size(29, 17)
        Me.radMultiply.TabIndex = 1
        Me.radMultiply.TabStop = True
        Me.radMultiply.Text = "*"
        Me.radMultiply.UseVisualStyleBackColor = True
        '
        'radPow
        '
        Me.radPow.AutoSize = True
        Me.radPow.Location = New System.Drawing.Point(64, 48)
        Me.radPow.Name = "radPow"
        Me.radPow.Size = New System.Drawing.Size(31, 17)
        Me.radPow.TabIndex = 0
        Me.radPow.TabStop = True
        Me.radPow.Text = "^"
        Me.radPow.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(50, 291)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(40, 13)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Result:"
        '
        'lblFinalResult
        '
        Me.lblFinalResult.Location = New System.Drawing.Point(114, 244)
        Me.lblFinalResult.Name = "lblFinalResult"
        Me.lblFinalResult.Size = New System.Drawing.Size(295, 105)
        Me.lblFinalResult.TabIndex = 6
        Me.lblFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(436, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 367)
        Me.Controls.Add(Me.lblFinalResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.grpOperators)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblSecondOperandPrompt)
        Me.Controls.Add(Me.lblFirstOperandPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.grpOperators.ResumeLayout(False)
        Me.grpOperators.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstOperandPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSecondOperandPrompt As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents grpOperators As System.Windows.Forms.GroupBox
    Friend WithEvents radSubtract As System.Windows.Forms.RadioButton
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents radMod As System.Windows.Forms.RadioButton
    Friend WithEvents radIntDivide As System.Windows.Forms.RadioButton
    Friend WithEvents radDivide As System.Windows.Forms.RadioButton
    Friend WithEvents radMultiply As System.Windows.Forms.RadioButton
    Friend WithEvents radPow As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblFinalResult As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
