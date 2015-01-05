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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.cboOpponent = New System.Windows.Forms.ComboBox()
        Me.lblOpponentPrompt = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkMusic = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTickerTitles = New System.Windows.Forms.Label()
        Me.lblTickerValues = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 250)
        Me.Panel1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(172, 172)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(60, 60)
        Me.Button6.TabIndex = 8
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(95, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 60)
        Me.Button7.TabIndex = 7
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(17, 172)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 60)
        Me.Button8.TabIndex = 6
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(172, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 60)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(95, 95)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 60)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(17, 95)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 60)
        Me.Button5.TabIndex = 3
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(172, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(17, 17)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(60, 60)
        Me.btn1.TabIndex = 0
        Me.btn1.UseVisualStyleBackColor = True
        '
        'cboOpponent
        '
        Me.cboOpponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpponent.FormattingEnabled = True
        Me.cboOpponent.Items.AddRange(New Object() {"Computer", "Human"})
        Me.cboOpponent.Location = New System.Drawing.Point(97, 28)
        Me.cboOpponent.Name = "cboOpponent"
        Me.cboOpponent.Size = New System.Drawing.Size(81, 21)
        Me.cboOpponent.TabIndex = 1
        '
        'lblOpponentPrompt
        '
        Me.lblOpponentPrompt.AutoSize = True
        Me.lblOpponentPrompt.Location = New System.Drawing.Point(27, 31)
        Me.lblOpponentPrompt.Name = "lblOpponentPrompt"
        Me.lblOpponentPrompt.Size = New System.Drawing.Size(64, 13)
        Me.lblOpponentPrompt.TabIndex = 2
        Me.lblOpponentPrompt.Text = "Play against"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkMusic)
        Me.grpOptions.Controls.Add(Me.btnClear)
        Me.grpOptions.Controls.Add(Me.lblOpponentPrompt)
        Me.grpOptions.Controls.Add(Me.cboOpponent)
        Me.grpOptions.Location = New System.Drawing.Point(268, 12)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(254, 155)
        Me.grpOptions.TabIndex = 3
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkMusic
        '
        Me.chkMusic.AutoSize = True
        Me.chkMusic.Location = New System.Drawing.Point(30, 69)
        Me.chkMusic.Name = "chkMusic"
        Me.chkMusic.Size = New System.Drawing.Size(54, 17)
        Me.chkMusic.TabIndex = 4
        Me.chkMusic.Text = "Music"
        Me.chkMusic.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(87, 114)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear board"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTickerTitles
        '
        Me.lblTickerTitles.AutoSize = True
        Me.lblTickerTitles.Location = New System.Drawing.Point(295, 195)
        Me.lblTickerTitles.Name = "lblTickerTitles"
        Me.lblTickerTitles.Size = New System.Drawing.Size(85, 39)
        Me.lblTickerTitles.TabIndex = 4
        Me.lblTickerTitles.Text = "Computer wins:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "X/Player 1 wins:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O/Player 2 wins:"
        Me.lblTickerTitles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTickerValues
        '
        Me.lblTickerValues.Location = New System.Drawing.Point(376, 196)
        Me.lblTickerValues.Name = "lblTickerValues"
        Me.lblTickerValues.Size = New System.Drawing.Size(24, 39)
        Me.lblTickerValues.TabIndex = 5
        Me.lblTickerValues.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 272)
        Me.Controls.Add(Me.lblTickerValues)
        Me.Controls.Add(Me.lblTickerTitles)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = ","
        Me.Panel1.ResumeLayout(False)
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents cboOpponent As System.Windows.Forms.ComboBox
    Friend WithEvents lblOpponentPrompt As System.Windows.Forms.Label
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents chkMusic As System.Windows.Forms.CheckBox
    Friend WithEvents lblTickerTitles As System.Windows.Forms.Label
    Friend WithEvents lblTickerValues As System.Windows.Forms.Label

End Class
