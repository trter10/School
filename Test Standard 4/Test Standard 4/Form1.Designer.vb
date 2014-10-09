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
        Me.lblSizePrompt = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSizePrompt
        '
        Me.lblSizePrompt.AutoSize = True
        Me.lblSizePrompt.Location = New System.Drawing.Point(59, 24)
        Me.lblSizePrompt.Name = "lblSizePrompt"
        Me.lblSizePrompt.Size = New System.Drawing.Size(176, 13)
        Me.lblSizePrompt.TabIndex = 0
        Me.lblSizePrompt.Text = "Enter the size of the pizza in inches:"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(241, 21)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(36, 20)
        Me.txtSize.TabIndex = 1
        '
        'lblCost
        '
        Me.lblCost.Location = New System.Drawing.Point(62, 68)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(215, 63)
        Me.lblCost.TabIndex = 2
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(137, 158)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 193)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.lblSizePrompt)
        Me.Name = "Form1"
        Me.Text = "Pizza Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSizePrompt As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
