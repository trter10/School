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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgrumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTypePrompt = New System.Windows.Forms.Label()
        Me.lblAmountPrompt = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lstBank = New System.Windows.Forms.ListBox()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.NameUrPuggyBunkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrumToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgrumToolStripMenuItem
        '
        Me.ProgrumToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetBalanceToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ProgrumToolStripMenuItem.Name = "ProgrumToolStripMenuItem"
        Me.ProgrumToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgrumToolStripMenuItem.Text = "Program"
        '
        'GetBalanceToolStripMenuItem
        '
        Me.GetBalanceToolStripMenuItem.Name = "GetBalanceToolStripMenuItem"
        Me.GetBalanceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GetBalanceToolStripMenuItem.Text = "Get Balance"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.NameUrPuggyBunkToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lblTypePrompt
        '
        Me.lblTypePrompt.AutoSize = True
        Me.lblTypePrompt.Location = New System.Drawing.Point(12, 45)
        Me.lblTypePrompt.Name = "lblTypePrompt"
        Me.lblTypePrompt.Size = New System.Drawing.Size(124, 13)
        Me.lblTypePrompt.TabIndex = 1
        Me.lblTypePrompt.Text = "Choose transaction type:"
        '
        'lblAmountPrompt
        '
        Me.lblAmountPrompt.AutoSize = True
        Me.lblAmountPrompt.Location = New System.Drawing.Point(63, 71)
        Me.lblAmountPrompt.Name = "lblAmountPrompt"
        Me.lblAmountPrompt.Size = New System.Drawing.Size(73, 13)
        Me.lblAmountPrompt.TabIndex = 2
        Me.lblAmountPrompt.Text = "Enter amount:"
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Deposit", "Withdrawal"})
        Me.cboType.Location = New System.Drawing.Point(143, 42)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 3
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(143, 68)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtAmount.TabIndex = 4
        '
        'lstBank
        '
        Me.lstBank.FormattingEnabled = True
        Me.lstBank.Location = New System.Drawing.Point(16, 110)
        Me.lstBank.Name = "lstBank"
        Me.lstBank.Size = New System.Drawing.Size(121, 134)
        Me.lstBank.TabIndex = 5
        '
        'btnTransaction
        '
        Me.btnTransaction.Location = New System.Drawing.Point(151, 110)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(121, 52)
        Me.btnTransaction.TabIndex = 6
        Me.btnTransaction.Text = "Make transaction"
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(151, 169)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(121, 75)
        Me.lblName.TabIndex = 7
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameUrPuggyBunkToolStripMenuItem
        '
        Me.NameUrPuggyBunkToolStripMenuItem.Name = "NameUrPuggyBunkToolStripMenuItem"
        Me.NameUrPuggyBunkToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.NameUrPuggyBunkToolStripMenuItem.Text = "Name your piggy bank"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.lstBank)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.lblAmountPrompt)
        Me.Controls.Add(Me.lblTypePrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Piggy Bank"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgrumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetBalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTypePrompt As System.Windows.Forms.Label
    Friend WithEvents lblAmountPrompt As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lstBank As System.Windows.Forms.ListBox
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents NameUrPuggyBunkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
