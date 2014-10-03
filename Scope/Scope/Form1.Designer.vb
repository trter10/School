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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnGlobal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblDisplay.Location = New System.Drawing.Point(64, 38)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(155, 55)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLocal
        '
        Me.btnLocal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnLocal.Location = New System.Drawing.Point(64, 117)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(155, 36)
        Me.btnLocal.TabIndex = 1
        Me.btnLocal.Text = "Local"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'btnGlobal
        '
        Me.btnGlobal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnGlobal.Location = New System.Drawing.Point(64, 184)
        Me.btnGlobal.Name = "btnGlobal"
        Me.btnGlobal.Size = New System.Drawing.Size(155, 36)
        Me.btnGlobal.TabIndex = 2
        Me.btnGlobal.Text = "Global"
        Me.btnGlobal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnGlobal)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.lblDisplay)
        Me.Name = "Form1"
        Me.Text = "Variable Scope"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnLocal As System.Windows.Forms.Button
    Friend WithEvents btnGlobal As System.Windows.Forms.Button

End Class
