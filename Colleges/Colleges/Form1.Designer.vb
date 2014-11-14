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
        Me.cboHours = New System.Windows.Forms.ComboBox()
        Me.lstCollege = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboHours
        '
        Me.cboHours.FormattingEnabled = True
        Me.cboHours.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.cboHours.Location = New System.Drawing.Point(141, 167)
        Me.cboHours.Name = "cboHours"
        Me.cboHours.Size = New System.Drawing.Size(121, 21)
        Me.cboHours.TabIndex = 0
        '
        'lstCollege
        '
        Me.lstCollege.FormattingEnabled = True
        Me.lstCollege.Items.AddRange(New Object() {"North Carolina State University", "University of North Carolina at Charlotte", "University of Michigan Ann Arbor"})
        Me.lstCollege.Location = New System.Drawing.Point(13, 12)
        Me.lstCollege.Name = "lstCollege"
        Me.lstCollege.Size = New System.Drawing.Size(260, 95)
        Me.lstCollege.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(33, 165)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lstCollege)
        Me.Controls.Add(Me.cboHours)
        Me.Name = "Form1"
        Me.Text = "College Tuition"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboHours As System.Windows.Forms.ComboBox
    Friend WithEvents lstCollege As System.Windows.Forms.ListBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
