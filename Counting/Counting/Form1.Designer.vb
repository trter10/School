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
        Me.btnDim = New System.Windows.Forms.Button()
        Me.btnStatic = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDim
        '
        Me.btnDim.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnDim.Location = New System.Drawing.Point(34, 50)
        Me.btnDim.Name = "btnDim"
        Me.btnDim.Size = New System.Drawing.Size(105, 35)
        Me.btnDim.TabIndex = 0
        Me.btnDim.Text = "Dim Variable"
        Me.btnDim.UseVisualStyleBackColor = True
        '
        'btnStatic
        '
        Me.btnStatic.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnStatic.Location = New System.Drawing.Point(145, 50)
        Me.btnStatic.Name = "btnStatic"
        Me.btnStatic.Size = New System.Drawing.Size(105, 35)
        Me.btnStatic.TabIndex = 1
        Me.btnStatic.Text = "Static Variable"
        Me.btnStatic.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblDisplay.Location = New System.Drawing.Point(34, 140)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(216, 51)
        Me.lblDisplay.TabIndex = 2
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnStatic)
        Me.Controls.Add(Me.btnDim)
        Me.Name = "Form1"
        Me.Text = "Counting"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDim As System.Windows.Forms.Button
    Friend WithEvents btnStatic As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
