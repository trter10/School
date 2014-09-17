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
        Me.btnHello = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.radGerman = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.grpChoices2 = New System.Windows.Forms.GroupBox()
        Me.chkGerman = New System.Windows.Forms.CheckBox()
        Me.chkFrench = New System.Windows.Forms.CheckBox()
        Me.chkEnglish = New System.Windows.Forms.CheckBox()
        Me.grpChoices.SuspendLayout()
        Me.grpChoices2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(111, 36)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(97, 23)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(19, 215)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(295, 56)
        Me.lblMessage.TabIndex = 1
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.radGerman)
        Me.grpChoices.Controls.Add(Me.radFrench)
        Me.grpChoices.Controls.Add(Me.radEnglish)
        Me.grpChoices.Location = New System.Drawing.Point(12, 90)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(131, 100)
        Me.grpChoices.TabIndex = 2
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Language Hello"
        '
        'radGerman
        '
        Me.radGerman.AutoSize = True
        Me.radGerman.Location = New System.Drawing.Point(7, 68)
        Me.radGerman.Name = "radGerman"
        Me.radGerman.Size = New System.Drawing.Size(62, 17)
        Me.radGerman.TabIndex = 2
        Me.radGerman.TabStop = True
        Me.radGerman.Text = "German"
        Me.radGerman.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(7, 44)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 1
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(7, 20)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 0
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'grpChoices2
        '
        Me.grpChoices2.Controls.Add(Me.chkGerman)
        Me.grpChoices2.Controls.Add(Me.chkFrench)
        Me.grpChoices2.Controls.Add(Me.chkEnglish)
        Me.grpChoices2.Location = New System.Drawing.Point(179, 91)
        Me.grpChoices2.Name = "grpChoices2"
        Me.grpChoices2.Size = New System.Drawing.Size(135, 99)
        Me.grpChoices2.TabIndex = 3
        Me.grpChoices2.TabStop = False
        Me.grpChoices2.Text = "Language Goodbye"
        '
        'chkGerman
        '
        Me.chkGerman.AutoSize = True
        Me.chkGerman.Location = New System.Drawing.Point(7, 69)
        Me.chkGerman.Name = "chkGerman"
        Me.chkGerman.Size = New System.Drawing.Size(63, 17)
        Me.chkGerman.TabIndex = 2
        Me.chkGerman.Text = "German"
        Me.chkGerman.UseVisualStyleBackColor = True
        '
        'chkFrench
        '
        Me.chkFrench.AutoSize = True
        Me.chkFrench.Location = New System.Drawing.Point(7, 45)
        Me.chkFrench.Name = "chkFrench"
        Me.chkFrench.Size = New System.Drawing.Size(59, 17)
        Me.chkFrench.TabIndex = 1
        Me.chkFrench.Text = "French"
        Me.chkFrench.UseVisualStyleBackColor = True
        '
        'chkEnglish
        '
        Me.chkEnglish.AutoSize = True
        Me.chkEnglish.Location = New System.Drawing.Point(7, 20)
        Me.chkEnglish.Name = "chkEnglish"
        Me.chkEnglish.Size = New System.Drawing.Size(60, 17)
        Me.chkEnglish.TabIndex = 0
        Me.chkEnglish.Text = "English"
        Me.chkEnglish.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 307)
        Me.Controls.Add(Me.grpChoices2)
        Me.Controls.Add(Me.grpChoices)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.grpChoices2.ResumeLayout(False)
        Me.grpChoices2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHello As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents grpChoices As System.Windows.Forms.GroupBox
    Friend WithEvents radGerman As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents grpChoices2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkGerman As System.Windows.Forms.CheckBox
    Friend WithEvents chkFrench As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnglish As System.Windows.Forms.CheckBox

End Class
