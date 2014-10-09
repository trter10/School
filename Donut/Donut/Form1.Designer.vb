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
        Me.lblDoughnutsPrompt = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.grpTypes = New System.Windows.Forms.GroupBox()
        Me.radLemon = New System.Windows.Forms.RadioButton()
        Me.radBlueberry = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDoughnutsPrompt
        '
        Me.lblDoughnutsPrompt.AutoSize = True
        Me.lblDoughnutsPrompt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblDoughnutsPrompt.Location = New System.Drawing.Point(50, 26)
        Me.lblDoughnutsPrompt.Name = "lblDoughnutsPrompt"
        Me.lblDoughnutsPrompt.Size = New System.Drawing.Size(193, 15)
        Me.lblDoughnutsPrompt.TabIndex = 0
        Me.lblDoughnutsPrompt.Text = "How many doughnuts would you like?"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.txtQuantity.Location = New System.Drawing.Point(249, 23)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(31, 23)
        Me.txtQuantity.TabIndex = 1
        '
        'grpTypes
        '
        Me.grpTypes.Controls.Add(Me.radLemon)
        Me.grpTypes.Controls.Add(Me.radBlueberry)
        Me.grpTypes.Controls.Add(Me.radChocolate)
        Me.grpTypes.Controls.Add(Me.radGlazed)
        Me.grpTypes.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.grpTypes.Location = New System.Drawing.Point(35, 58)
        Me.grpTypes.Name = "grpTypes"
        Me.grpTypes.Size = New System.Drawing.Size(255, 102)
        Me.grpTypes.TabIndex = 2
        Me.grpTypes.TabStop = False
        Me.grpTypes.Text = "Types of Doughnuts"
        '
        'radLemon
        '
        Me.radLemon.AutoSize = True
        Me.radLemon.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radLemon.Location = New System.Drawing.Point(133, 56)
        Me.radLemon.Name = "radLemon"
        Me.radLemon.Size = New System.Drawing.Size(92, 19)
        Me.radLemon.TabIndex = 3
        Me.radLemon.Text = "Lemon $0.60"
        Me.radLemon.UseVisualStyleBackColor = True
        '
        'radBlueberry
        '
        Me.radBlueberry.AutoSize = True
        Me.radBlueberry.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radBlueberry.Location = New System.Drawing.Point(133, 33)
        Me.radBlueberry.Name = "radBlueberry"
        Me.radBlueberry.Size = New System.Drawing.Size(110, 19)
        Me.radBlueberry.TabIndex = 2
        Me.radBlueberry.Text = "Blueberry $0.75"
        Me.radBlueberry.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radChocolate.Location = New System.Drawing.Point(18, 56)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(110, 19)
        Me.radChocolate.TabIndex = 1
        Me.radChocolate.Text = "Chocolate $0.65"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radGlazed.Location = New System.Drawing.Point(18, 33)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(95, 19)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.Text = "Glazed $0.50"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblOutput.Location = New System.Drawing.Point(35, 177)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(255, 66)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnOrder.Location = New System.Drawing.Point(35, 259)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(83, 31)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Your Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblTotal.Location = New System.Drawing.Point(133, 259)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(157, 31)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 302)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.grpTypes)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblDoughnutsPrompt)
        Me.Name = "Form1"
        Me.Text = "Donut Delight"
        Me.grpTypes.ResumeLayout(False)
        Me.grpTypes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDoughnutsPrompt As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents grpTypes As System.Windows.Forms.GroupBox
    Friend WithEvents radLemon As System.Windows.Forms.RadioButton
    Friend WithEvents radBlueberry As System.Windows.Forms.RadioButton
    Friend WithEvents radChocolate As System.Windows.Forms.RadioButton
    Friend WithEvents radGlazed As System.Windows.Forms.RadioButton
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
