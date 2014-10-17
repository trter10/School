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
        Me.lblNumberPrompt = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.lblRemainder = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumberPrompt
        '
        Me.lblNumberPrompt.AutoSize = True
        Me.lblNumberPrompt.Location = New System.Drawing.Point(30, 22)
        Me.lblNumberPrompt.Name = "lblNumberPrompt"
        Me.lblNumberPrompt.Size = New System.Drawing.Size(177, 13)
        Me.lblNumberPrompt.TabIndex = 0
        Me.lblNumberPrompt.Text = "Enter the number of mints in the bag"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(213, 19)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(36, 20)
        Me.txtNumber.TabIndex = 1
        '
        'lblServings
        '
        Me.lblServings.AutoSize = True
        Me.lblServings.Location = New System.Drawing.Point(55, 83)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(0, 13)
        Me.lblServings.TabIndex = 2
        '
        'lblRemainder
        '
        Me.lblRemainder.AutoSize = True
        Me.lblRemainder.Location = New System.Drawing.Point(55, 112)
        Me.lblRemainder.Name = "lblRemainder"
        Me.lblRemainder.Size = New System.Drawing.Size(0, 13)
        Me.lblRemainder.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(106, 183)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblRemainder)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumberPrompt)
        Me.Name = "Form1"
        Me.Text = "Mints"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumberPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblServings As System.Windows.Forms.Label
    Friend WithEvents lblRemainder As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
