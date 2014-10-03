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
        Me.lblRadiusPrompt = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRadiusPrompt
        '
        Me.lblRadiusPrompt.AutoSize = True
        Me.lblRadiusPrompt.Location = New System.Drawing.Point(40, 26)
        Me.lblRadiusPrompt.Name = "lblRadiusPrompt"
        Me.lblRadiusPrompt.Size = New System.Drawing.Size(43, 13)
        Me.lblRadiusPrompt.TabIndex = 0
        Me.lblRadiusPrompt.Text = "Radius:"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(89, 23)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 1
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(36, 56)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(153, 51)
        Me.lblArea.TabIndex = 2
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(73, 128)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 163)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.lblRadiusPrompt)
        Me.Name = "Form1"
        Me.Text = "Area of a Circle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRadiusPrompt As System.Windows.Forms.Label
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
