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
        Me.lblCrustPrompt = New System.Windows.Forms.Label()
        Me.lblTop1Prompt = New System.Windows.Forms.Label()
        Me.txtCrust = New System.Windows.Forms.TextBox()
        Me.txtTop1 = New System.Windows.Forms.TextBox()
        Me.lblFinalOrder = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.txtTop2 = New System.Windows.Forms.TextBox()
        Me.lblTop2Prompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCrustPrompt
        '
        Me.lblCrustPrompt.AutoSize = True
        Me.lblCrustPrompt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblCrustPrompt.Location = New System.Drawing.Point(34, 34)
        Me.lblCrustPrompt.Name = "lblCrustPrompt"
        Me.lblCrustPrompt.Size = New System.Drawing.Size(142, 15)
        Me.lblCrustPrompt.TabIndex = 0
        Me.lblCrustPrompt.Text = "Enter your choice of crust"
        '
        'lblTop1Prompt
        '
        Me.lblTop1Prompt.AutoSize = True
        Me.lblTop1Prompt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblTop1Prompt.Location = New System.Drawing.Point(10, 57)
        Me.lblTop1Prompt.Name = "lblTop1Prompt"
        Me.lblTop1Prompt.Size = New System.Drawing.Size(166, 15)
        Me.lblTop1Prompt.TabIndex = 1
        Me.lblTop1Prompt.Text = "Enter your first topping choice"
        '
        'txtCrust
        '
        Me.txtCrust.Location = New System.Drawing.Point(182, 29)
        Me.txtCrust.Name = "txtCrust"
        Me.txtCrust.Size = New System.Drawing.Size(100, 20)
        Me.txtCrust.TabIndex = 2
        '
        'txtTop1
        '
        Me.txtTop1.Location = New System.Drawing.Point(182, 52)
        Me.txtTop1.Multiline = True
        Me.txtTop1.Name = "txtTop1"
        Me.txtTop1.Size = New System.Drawing.Size(100, 20)
        Me.txtTop1.TabIndex = 3
        '
        'lblFinalOrder
        '
        Me.lblFinalOrder.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblFinalOrder.Location = New System.Drawing.Point(11, 133)
        Me.lblFinalOrder.Name = "lblFinalOrder"
        Me.lblFinalOrder.Size = New System.Drawing.Size(260, 62)
        Me.lblFinalOrder.TabIndex = 0
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(90, 227)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(97, 23)
        Me.btnOrder.TabIndex = 5
        Me.btnOrder.Text = "Your Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'txtTop2
        '
        Me.txtTop2.Location = New System.Drawing.Point(182, 79)
        Me.txtTop2.Multiline = True
        Me.txtTop2.Name = "txtTop2"
        Me.txtTop2.Size = New System.Drawing.Size(100, 20)
        Me.txtTop2.TabIndex = 4
        '
        'lblTop2Prompt
        '
        Me.lblTop2Prompt.AutoSize = True
        Me.lblTop2Prompt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblTop2Prompt.Location = New System.Drawing.Point(-1, 84)
        Me.lblTop2Prompt.Name = "lblTop2Prompt"
        Me.lblTop2Prompt.Size = New System.Drawing.Size(177, 15)
        Me.lblTop2Prompt.TabIndex = 7
        Me.lblTop2Prompt.Text = "Enter your second topping choice"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblTop2Prompt)
        Me.Controls.Add(Me.txtTop2)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblFinalOrder)
        Me.Controls.Add(Me.txtTop1)
        Me.Controls.Add(Me.txtCrust)
        Me.Controls.Add(Me.lblTop1Prompt)
        Me.Controls.Add(Me.lblCrustPrompt)
        Me.Name = "Form1"
        Me.Text = "Pizza Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCrustPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTop1Prompt As System.Windows.Forms.Label
    Friend WithEvents txtCrust As System.Windows.Forms.TextBox
    Friend WithEvents txtTop1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalOrder As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents txtTop2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTop2Prompt As System.Windows.Forms.Label

End Class
