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
        Me.lblChoicesPrompt = New System.Windows.Forms.Label()
        Me.lstChoices = New System.Windows.Forms.ListBox()
        Me.lblDrinksPrompt = New System.Windows.Forms.Label()
        Me.lblSizePrompt = New System.Windows.Forms.Label()
        Me.cboDrink = New System.Windows.Forms.ComboBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChoicesPrompt
        '
        Me.lblChoicesPrompt.AutoSize = True
        Me.lblChoicesPrompt.Location = New System.Drawing.Point(9, 39)
        Me.lblChoicesPrompt.Name = "lblChoicesPrompt"
        Me.lblChoicesPrompt.Size = New System.Drawing.Size(85, 13)
        Me.lblChoicesPrompt.TabIndex = 0
        Me.lblChoicesPrompt.Text = "Today's Choices"
        '
        'lstChoices
        '
        Me.lstChoices.FormattingEnabled = True
        Me.lstChoices.Items.AddRange(New Object() {"Chef Salad", "Garden Salad", "Hamburger", "Cheeseburger", "Chicken Sandwich"})
        Me.lstChoices.Location = New System.Drawing.Point(12, 55)
        Me.lstChoices.Name = "lstChoices"
        Me.lstChoices.Size = New System.Drawing.Size(120, 95)
        Me.lstChoices.TabIndex = 1
        '
        'lblDrinksPrompt
        '
        Me.lblDrinksPrompt.AutoSize = True
        Me.lblDrinksPrompt.Location = New System.Drawing.Point(163, 39)
        Me.lblDrinksPrompt.Name = "lblDrinksPrompt"
        Me.lblDrinksPrompt.Size = New System.Drawing.Size(32, 13)
        Me.lblDrinksPrompt.TabIndex = 2
        Me.lblDrinksPrompt.Text = "Drink"
        '
        'lblSizePrompt
        '
        Me.lblSizePrompt.AutoSize = True
        Me.lblSizePrompt.Location = New System.Drawing.Point(163, 79)
        Me.lblSizePrompt.Name = "lblSizePrompt"
        Me.lblSizePrompt.Size = New System.Drawing.Size(55, 13)
        Me.lblSizePrompt.TabIndex = 3
        Me.lblSizePrompt.Text = "Drink Size"
        '
        'cboDrink
        '
        Me.cboDrink.FormattingEnabled = True
        Me.cboDrink.Items.AddRange(New Object() {"Soda", "Tea", "Water"})
        Me.cboDrink.Location = New System.Drawing.Point(166, 55)
        Me.cboDrink.Name = "cboDrink"
        Me.cboDrink.Size = New System.Drawing.Size(121, 21)
        Me.cboDrink.TabIndex = 4
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cboSize.Location = New System.Drawing.Point(166, 95)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 21)
        Me.cboSize.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(166, 126)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(121, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate Cost"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(297, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblOrder
        '
        Me.lblOrder.Location = New System.Drawing.Point(12, 157)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(273, 82)
        Me.lblOrder.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 248)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboDrink)
        Me.Controls.Add(Me.lblSizePrompt)
        Me.Controls.Add(Me.lblDrinksPrompt)
        Me.Controls.Add(Me.lstChoices)
        Me.Controls.Add(Me.lblChoicesPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Lunch Time"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChoicesPrompt As System.Windows.Forms.Label
    Friend WithEvents lstChoices As System.Windows.Forms.ListBox
    Friend WithEvents lblDrinksPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSizePrompt As System.Windows.Forms.Label
    Friend WithEvents cboDrink As System.Windows.Forms.ComboBox
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
