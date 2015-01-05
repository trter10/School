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
        Me.txtQ1 = New System.Windows.Forms.TextBox()
        Me.txtQ2 = New System.Windows.Forms.TextBox()
        Me.txtQ3 = New System.Windows.Forms.TextBox()
        Me.txtQ4 = New System.Windows.Forms.TextBox()
        Me.lblQ1Prompt = New System.Windows.Forms.Label()
        Me.lblQ2Prompt = New System.Windows.Forms.Label()
        Me.lblQ3Prompt = New System.Windows.Forms.Label()
        Me.lblQ4Prompt = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtQ1
        '
        Me.txtQ1.Location = New System.Drawing.Point(162, 16)
        Me.txtQ1.Name = "txtQ1"
        Me.txtQ1.Size = New System.Drawing.Size(39, 20)
        Me.txtQ1.TabIndex = 0
        '
        'txtQ2
        '
        Me.txtQ2.Location = New System.Drawing.Point(162, 42)
        Me.txtQ2.Name = "txtQ2"
        Me.txtQ2.Size = New System.Drawing.Size(39, 20)
        Me.txtQ2.TabIndex = 1
        '
        'txtQ3
        '
        Me.txtQ3.Location = New System.Drawing.Point(162, 68)
        Me.txtQ3.Name = "txtQ3"
        Me.txtQ3.Size = New System.Drawing.Size(39, 20)
        Me.txtQ3.TabIndex = 2
        '
        'txtQ4
        '
        Me.txtQ4.Location = New System.Drawing.Point(162, 94)
        Me.txtQ4.Name = "txtQ4"
        Me.txtQ4.Size = New System.Drawing.Size(39, 20)
        Me.txtQ4.TabIndex = 3
        '
        'lblQ1Prompt
        '
        Me.lblQ1Prompt.AutoSize = True
        Me.lblQ1Prompt.Location = New System.Drawing.Point(38, 19)
        Me.lblQ1Prompt.Name = "lblQ1Prompt"
        Me.lblQ1Prompt.Size = New System.Drawing.Size(118, 13)
        Me.lblQ1Prompt.TabIndex = 4
        Me.lblQ1Prompt.Text = "Enter first quarter points"
        '
        'lblQ2Prompt
        '
        Me.lblQ2Prompt.AutoSize = True
        Me.lblQ2Prompt.Location = New System.Drawing.Point(19, 45)
        Me.lblQ2Prompt.Name = "lblQ2Prompt"
        Me.lblQ2Prompt.Size = New System.Drawing.Size(137, 13)
        Me.lblQ2Prompt.TabIndex = 5
        Me.lblQ2Prompt.Text = "Enter second quarter points"
        '
        'lblQ3Prompt
        '
        Me.lblQ3Prompt.AutoSize = True
        Me.lblQ3Prompt.Location = New System.Drawing.Point(34, 71)
        Me.lblQ3Prompt.Name = "lblQ3Prompt"
        Me.lblQ3Prompt.Size = New System.Drawing.Size(122, 13)
        Me.lblQ3Prompt.TabIndex = 6
        Me.lblQ3Prompt.Text = "Enter third quarter points"
        '
        'lblQ4Prompt
        '
        Me.lblQ4Prompt.AutoSize = True
        Me.lblQ4Prompt.Location = New System.Drawing.Point(27, 97)
        Me.lblQ4Prompt.Name = "lblQ4Prompt"
        Me.lblQ4Prompt.Size = New System.Drawing.Size(129, 13)
        Me.lblQ4Prompt.TabIndex = 7
        Me.lblQ4Prompt.Text = "Enter fourth quarter points"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(22, 120)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(179, 37)
        Me.btnCompute.TabIndex = 8
        Me.btnCompute.Text = "Compute total"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(22, 160)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(179, 54)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 223)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblQ4Prompt)
        Me.Controls.Add(Me.lblQ3Prompt)
        Me.Controls.Add(Me.lblQ2Prompt)
        Me.Controls.Add(Me.lblQ1Prompt)
        Me.Controls.Add(Me.txtQ4)
        Me.Controls.Add(Me.txtQ3)
        Me.Controls.Add(Me.txtQ2)
        Me.Controls.Add(Me.txtQ1)
        Me.Name = "Form1"
        Me.Text = "Football Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQ1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ3 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ4 As System.Windows.Forms.TextBox
    Friend WithEvents lblQ1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblQ2Prompt As System.Windows.Forms.Label
    Friend WithEvents lblQ3Prompt As System.Windows.Forms.Label
    Friend WithEvents lblQ4Prompt As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
