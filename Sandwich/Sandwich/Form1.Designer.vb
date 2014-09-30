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
        Me.lblMainChoice = New System.Windows.Forms.Label()
        Me.lblChoice1 = New System.Windows.Forms.Label()
        Me.lblChoice2 = New System.Windows.Forms.Label()
        Me.lblChoice3 = New System.Windows.Forms.Label()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.radHam = New System.Windows.Forms.RadioButton()
        Me.radTurkey = New System.Windows.Forms.RadioButton()
        Me.grpChoice = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.grpMain.SuspendLayout()
        Me.grpChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMainChoice
        '
        Me.lblMainChoice.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblMainChoice.Location = New System.Drawing.Point(12, 247)
        Me.lblMainChoice.Name = "lblMainChoice"
        Me.lblMainChoice.Size = New System.Drawing.Size(125, 25)
        Me.lblMainChoice.TabIndex = 0
        '
        'lblChoice1
        '
        Me.lblChoice1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblChoice1.Location = New System.Drawing.Point(12, 293)
        Me.lblChoice1.Name = "lblChoice1"
        Me.lblChoice1.Size = New System.Drawing.Size(125, 25)
        Me.lblChoice1.TabIndex = 1
        '
        'lblChoice2
        '
        Me.lblChoice2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblChoice2.Location = New System.Drawing.Point(155, 247)
        Me.lblChoice2.Name = "lblChoice2"
        Me.lblChoice2.Size = New System.Drawing.Size(125, 25)
        Me.lblChoice2.TabIndex = 2
        '
        'lblChoice3
        '
        Me.lblChoice3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblChoice3.Location = New System.Drawing.Point(155, 293)
        Me.lblChoice3.Name = "lblChoice3"
        Me.lblChoice3.Size = New System.Drawing.Size(125, 25)
        Me.lblChoice3.TabIndex = 3
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.radHam)
        Me.grpMain.Controls.Add(Me.radTurkey)
        Me.grpMain.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.grpMain.Location = New System.Drawing.Point(198, 12)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(152, 75)
        Me.grpMain.TabIndex = 4
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "MAYNE CHOICE"
        '
        'radHam
        '
        Me.radHam.AutoSize = True
        Me.radHam.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radHam.Location = New System.Drawing.Point(15, 33)
        Me.radHam.Name = "radHam"
        Me.radHam.Size = New System.Drawing.Size(47, 19)
        Me.radHam.TabIndex = 1
        Me.radHam.Text = "Ham"
        Me.radHam.UseVisualStyleBackColor = True
        '
        'radTurkey
        '
        Me.radTurkey.AutoSize = True
        Me.radTurkey.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radTurkey.Location = New System.Drawing.Point(84, 33)
        Me.radTurkey.Name = "radTurkey"
        Me.radTurkey.Size = New System.Drawing.Size(61, 19)
        Me.radTurkey.TabIndex = 0
        Me.radTurkey.Text = "Turkey"
        Me.radTurkey.UseVisualStyleBackColor = True
        '
        'grpChoice
        '
        Me.grpChoice.Controls.Add(Me.chkCheese)
        Me.grpChoice.Controls.Add(Me.chkMustard)
        Me.grpChoice.Controls.Add(Me.chkMayo)
        Me.grpChoice.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.grpChoice.Location = New System.Drawing.Point(29, 133)
        Me.grpChoice.Name = "grpChoice"
        Me.grpChoice.Size = New System.Drawing.Size(200, 100)
        Me.grpChoice.TabIndex = 5
        Me.grpChoice.TabStop = False
        Me.grpChoice.Text = "Condiments"
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.chkCheese.Location = New System.Drawing.Point(113, 77)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(70, 19)
        Me.chkCheese.TabIndex = 2
        Me.chkCheese.Text = "CHEESE"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.chkMustard.Location = New System.Drawing.Point(64, 39)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(68, 19)
        Me.chkMustard.TabIndex = 1
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.chkMayo.Location = New System.Drawing.Point(3, 16)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(87, 19)
        Me.chkMayo.TabIndex = 0
        Me.chkMayo.Text = "Mayonnaise"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Sandwich.My.Resources.Resources.download
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(370, 374)
        Me.Controls.Add(Me.grpChoice)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.lblChoice3)
        Me.Controls.Add(Me.lblChoice2)
        Me.Controls.Add(Me.lblChoice1)
        Me.Controls.Add(Me.lblMainChoice)
        Me.Name = "Form1"
        Me.Text = "Sandwich Shop"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.grpChoice.ResumeLayout(False)
        Me.grpChoice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMainChoice As System.Windows.Forms.Label
    Friend WithEvents lblChoice1 As System.Windows.Forms.Label
    Friend WithEvents lblChoice2 As System.Windows.Forms.Label
    Friend WithEvents lblChoice3 As System.Windows.Forms.Label
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents radHam As System.Windows.Forms.RadioButton
    Friend WithEvents radTurkey As System.Windows.Forms.RadioButton
    Friend WithEvents grpChoice As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox

End Class
