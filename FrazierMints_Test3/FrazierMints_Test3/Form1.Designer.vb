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
        Me.grpFlavors = New System.Windows.Forms.GroupBox()
        Me.radCinnamon = New System.Windows.Forms.RadioButton()
        Me.radWintergreen = New System.Windows.Forms.RadioButton()
        Me.radPeppermint = New System.Windows.Forms.RadioButton()
        Me.btnChoices = New System.Windows.Forms.Button()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.grpFlavors.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFlavors
        '
        Me.grpFlavors.BackColor = System.Drawing.Color.Transparent
        Me.grpFlavors.Controls.Add(Me.radCinnamon)
        Me.grpFlavors.Controls.Add(Me.radWintergreen)
        Me.grpFlavors.Controls.Add(Me.radPeppermint)
        Me.grpFlavors.Location = New System.Drawing.Point(48, 12)
        Me.grpFlavors.Name = "grpFlavors"
        Me.grpFlavors.Size = New System.Drawing.Size(139, 113)
        Me.grpFlavors.TabIndex = 0
        Me.grpFlavors.TabStop = False
        Me.grpFlavors.Text = "Flavors"
        '
        'radCinnamon
        '
        Me.radCinnamon.AutoSize = True
        Me.radCinnamon.Location = New System.Drawing.Point(20, 72)
        Me.radCinnamon.Name = "radCinnamon"
        Me.radCinnamon.Size = New System.Drawing.Size(74, 19)
        Me.radCinnamon.TabIndex = 2
        Me.radCinnamon.TabStop = True
        Me.radCinnamon.Text = "Cinnamon"
        Me.radCinnamon.UseVisualStyleBackColor = True
        '
        'radWintergreen
        '
        Me.radWintergreen.AutoSize = True
        Me.radWintergreen.Location = New System.Drawing.Point(22, 47)
        Me.radWintergreen.Name = "radWintergreen"
        Me.radWintergreen.Size = New System.Drawing.Size(91, 19)
        Me.radWintergreen.TabIndex = 1
        Me.radWintergreen.TabStop = True
        Me.radWintergreen.Text = "Wintergreen"
        Me.radWintergreen.UseVisualStyleBackColor = True
        '
        'radPeppermint
        '
        Me.radPeppermint.AutoSize = True
        Me.radPeppermint.Location = New System.Drawing.Point(22, 22)
        Me.radPeppermint.Name = "radPeppermint"
        Me.radPeppermint.Size = New System.Drawing.Size(82, 19)
        Me.radPeppermint.TabIndex = 0
        Me.radPeppermint.TabStop = True
        Me.radPeppermint.Text = "Peppermint"
        Me.radPeppermint.UseVisualStyleBackColor = True
        '
        'btnChoices
        '
        Me.btnChoices.Location = New System.Drawing.Point(48, 153)
        Me.btnChoices.Name = "btnChoices"
        Me.btnChoices.Size = New System.Drawing.Size(139, 33)
        Me.btnChoices.TabIndex = 1
        Me.btnChoices.Text = "Choices"
        Me.btnChoices.UseVisualStyleBackColor = True
        '
        'lblChoice
        '
        Me.lblChoice.BackColor = System.Drawing.Color.Transparent
        Me.lblChoice.Location = New System.Drawing.Point(48, 203)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(139, 87)
        Me.lblChoice.TabIndex = 2
        Me.lblChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(234, 312)
        Me.Controls.Add(Me.lblChoice)
        Me.Controls.Add(Me.btnChoices)
        Me.Controls.Add(Me.grpFlavors)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Mints!"
        Me.grpFlavors.ResumeLayout(False)
        Me.grpFlavors.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpFlavors As System.Windows.Forms.GroupBox
    Friend WithEvents radCinnamon As System.Windows.Forms.RadioButton
    Friend WithEvents radWintergreen As System.Windows.Forms.RadioButton
    Friend WithEvents radPeppermint As System.Windows.Forms.RadioButton
    Friend WithEvents btnChoices As System.Windows.Forms.Button
    Friend WithEvents lblChoice As System.Windows.Forms.Label

End Class
