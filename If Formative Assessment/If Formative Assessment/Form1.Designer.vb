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
        Me.lblGuessPrompt = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGuessPrompt
        '
        Me.lblGuessPrompt.AutoSize = True
        Me.lblGuessPrompt.Location = New System.Drawing.Point(12, 49)
        Me.lblGuessPrompt.Name = "lblGuessPrompt"
        Me.lblGuessPrompt.Size = New System.Drawing.Size(123, 13)
        Me.lblGuessPrompt.TabIndex = 0
        Me.lblGuessPrompt.Text = "Please enter your guess:"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(141, 46)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(36, 20)
        Me.txtGuess.TabIndex = 1
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(197, 44)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 2
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.Location = New System.Drawing.Point(48, 130)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(181, 88)
        Me.lblResponse.TabIndex = 3
        Me.lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblGuessPrompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGuessPrompt As System.Windows.Forms.Label
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents lblResponse As System.Windows.Forms.Label

End Class
