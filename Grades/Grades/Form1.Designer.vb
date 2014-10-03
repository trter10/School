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
        Me.lblQ1Prompt = New System.Windows.Forms.Label()
        Me.lblQ2Prompt = New System.Windows.Forms.Label()
        Me.lblFEPrompt = New System.Windows.Forms.Label()
        Me.txtQ1Grade = New System.Windows.Forms.TextBox()
        Me.txtQ2Grade = New System.Windows.Forms.TextBox()
        Me.txtFEGrade = New System.Windows.Forms.TextBox()
        Me.lblFinalGrade = New System.Windows.Forms.Label()
        Me.btnShowGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQ1Prompt
        '
        Me.lblQ1Prompt.AutoSize = True
        Me.lblQ1Prompt.Location = New System.Drawing.Point(37, 35)
        Me.lblQ1Prompt.Name = "lblQ1Prompt"
        Me.lblQ1Prompt.Size = New System.Drawing.Size(114, 13)
        Me.lblQ1Prompt.TabIndex = 0
        Me.lblQ1Prompt.Text = "Enter your Q1 average"
        '
        'lblQ2Prompt
        '
        Me.lblQ2Prompt.AutoSize = True
        Me.lblQ2Prompt.Location = New System.Drawing.Point(37, 61)
        Me.lblQ2Prompt.Name = "lblQ2Prompt"
        Me.lblQ2Prompt.Size = New System.Drawing.Size(114, 13)
        Me.lblQ2Prompt.TabIndex = 1
        Me.lblQ2Prompt.Text = "Enter your Q2 average"
        '
        'lblFEPrompt
        '
        Me.lblFEPrompt.AutoSize = True
        Me.lblFEPrompt.Location = New System.Drawing.Point(16, 87)
        Me.lblFEPrompt.Name = "lblFEPrompt"
        Me.lblFEPrompt.Size = New System.Drawing.Size(135, 13)
        Me.lblFEPrompt.TabIndex = 2
        Me.lblFEPrompt.Text = "Enter your final exam grade"
        '
        'txtQ1Grade
        '
        Me.txtQ1Grade.Location = New System.Drawing.Point(173, 28)
        Me.txtQ1Grade.Name = "txtQ1Grade"
        Me.txtQ1Grade.Size = New System.Drawing.Size(100, 20)
        Me.txtQ1Grade.TabIndex = 3
        '
        'txtQ2Grade
        '
        Me.txtQ2Grade.Location = New System.Drawing.Point(173, 54)
        Me.txtQ2Grade.Name = "txtQ2Grade"
        Me.txtQ2Grade.Size = New System.Drawing.Size(100, 20)
        Me.txtQ2Grade.TabIndex = 4
        '
        'txtFEGrade
        '
        Me.txtFEGrade.Location = New System.Drawing.Point(173, 80)
        Me.txtFEGrade.Name = "txtFEGrade"
        Me.txtFEGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtFEGrade.TabIndex = 5
        '
        'lblFinalGrade
        '
        Me.lblFinalGrade.Location = New System.Drawing.Point(19, 124)
        Me.lblFinalGrade.Name = "lblFinalGrade"
        Me.lblFinalGrade.Size = New System.Drawing.Size(253, 66)
        Me.lblFinalGrade.TabIndex = 6
        Me.lblFinalGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowGrade
        '
        Me.btnShowGrade.Location = New System.Drawing.Point(85, 227)
        Me.btnShowGrade.Name = "btnShowGrade"
        Me.btnShowGrade.Size = New System.Drawing.Size(107, 23)
        Me.btnShowGrade.TabIndex = 7
        Me.btnShowGrade.Text = "Calculate Grade"
        Me.btnShowGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnShowGrade)
        Me.Controls.Add(Me.lblFinalGrade)
        Me.Controls.Add(Me.txtFEGrade)
        Me.Controls.Add(Me.txtQ2Grade)
        Me.Controls.Add(Me.txtQ1Grade)
        Me.Controls.Add(Me.lblFEPrompt)
        Me.Controls.Add(Me.lblQ2Prompt)
        Me.Controls.Add(Me.lblQ1Prompt)
        Me.Name = "Form1"
        Me.Text = "Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQ1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblQ2Prompt As System.Windows.Forms.Label
    Friend WithEvents lblFEPrompt As System.Windows.Forms.Label
    Friend WithEvents txtQ1Grade As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2Grade As System.Windows.Forms.TextBox
    Friend WithEvents txtFEGrade As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalGrade As System.Windows.Forms.Label
    Friend WithEvents btnShowGrade As System.Windows.Forms.Button

End Class
