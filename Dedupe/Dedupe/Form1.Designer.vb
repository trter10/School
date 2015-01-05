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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.btnDedupe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(182, 50)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(76, 23)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "Select Dir"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblSelected
        '
        Me.lblSelected.AutoEllipsis = True
        Me.lblSelected.Location = New System.Drawing.Point(12, 55)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(164, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Text = "No directory selected"
        '
        'btnDedupe
        '
        Me.btnDedupe.Enabled = False
        Me.btnDedupe.Location = New System.Drawing.Point(101, 173)
        Me.btnDedupe.Name = "btnDedupe"
        Me.btnDedupe.Size = New System.Drawing.Size(75, 23)
        Me.btnDedupe.TabIndex = 2
        Me.btnDedupe.Text = "dedupe"
        Me.btnDedupe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDedupe)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.btnSelect)
        Me.Name = "Form1"
        Me.Text = "dedupe"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents btnDedupe As System.Windows.Forms.Button

End Class
