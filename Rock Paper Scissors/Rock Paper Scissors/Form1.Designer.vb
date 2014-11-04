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
        Me.grpThrow = New System.Windows.Forms.GroupBox()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.grpThrow.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpThrow
        '
        Me.grpThrow.Controls.Add(Me.radScissors)
        Me.grpThrow.Controls.Add(Me.radPaper)
        Me.grpThrow.Controls.Add(Me.radRock)
        Me.grpThrow.Location = New System.Drawing.Point(13, 22)
        Me.grpThrow.Name = "grpThrow"
        Me.grpThrow.Size = New System.Drawing.Size(259, 89)
        Me.grpThrow.TabIndex = 0
        Me.grpThrow.TabStop = False
        Me.grpThrow.Text = "Choose your throw"
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(16, 41)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(95, 41)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 1
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(171, 41)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 2
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.Location = New System.Drawing.Point(13, 129)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(259, 60)
        Me.lblCounter.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(77, 217)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(127, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "cumon step it up!!1!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.grpThrow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpThrow.ResumeLayout(False)
        Me.grpThrow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpThrow As System.Windows.Forms.GroupBox
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
