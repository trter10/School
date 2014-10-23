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
        Me.chkHomework = New System.Windows.Forms.CheckBox()
        Me.chkTeeth = New System.Windows.Forms.CheckBox()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnReady = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkHomework
        '
        Me.chkHomework.AutoSize = True
        Me.chkHomework.Location = New System.Drawing.Point(26, 33)
        Me.chkHomework.Name = "chkHomework"
        Me.chkHomework.Size = New System.Drawing.Size(104, 17)
        Me.chkHomework.TabIndex = 0
        Me.chkHomework.Text = "Homework done"
        Me.chkHomework.UseVisualStyleBackColor = True
        '
        'chkTeeth
        '
        Me.chkTeeth.AutoSize = True
        Me.chkTeeth.Location = New System.Drawing.Point(26, 112)
        Me.chkTeeth.Name = "chkTeeth"
        Me.chkTeeth.Size = New System.Drawing.Size(80, 17)
        Me.chkTeeth.TabIndex = 1
        Me.chkTeeth.Text = "Brush teeth"
        Me.chkTeeth.UseVisualStyleBackColor = True
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Location = New System.Drawing.Point(26, 71)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(89, 17)
        Me.chkBreakfast.TabIndex = 2
        Me.chkBreakfast.Text = "Eat breakfast"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(23, 153)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(169, 141)
        Me.lblOutput.TabIndex = 3
        '
        'btnReady
        '
        Me.btnReady.Location = New System.Drawing.Point(57, 352)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(105, 27)
        Me.btnReady.TabIndex = 4
        Me.btnReady.Text = "Ready"
        Me.btnReady.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 391)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.chkBreakfast)
        Me.Controls.Add(Me.chkTeeth)
        Me.Controls.Add(Me.chkHomework)
        Me.Name = "Form1"
        Me.Text = "Ready for school"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkHomework As System.Windows.Forms.CheckBox
    Friend WithEvents chkTeeth As System.Windows.Forms.CheckBox
    Friend WithEvents chkBreakfast As System.Windows.Forms.CheckBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnReady As System.Windows.Forms.Button

End Class
