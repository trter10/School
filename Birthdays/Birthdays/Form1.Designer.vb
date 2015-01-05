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
        Me.lstDates = New System.Windows.Forms.ListBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDates
        '
        Me.lstDates.FormattingEnabled = True
        Me.lstDates.Location = New System.Drawing.Point(12, 75)
        Me.lstDates.Name = "lstDates"
        Me.lstDates.Size = New System.Drawing.Size(153, 95)
        Me.lstDates.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(27, 12)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(120, 53)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Birthdates"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(177, 182)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lstDates)
        Me.Name = "Form1"
        Me.Text = "Birthdates"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstDates As System.Windows.Forms.ListBox
    Friend WithEvents btnShow As System.Windows.Forms.Button

End Class
