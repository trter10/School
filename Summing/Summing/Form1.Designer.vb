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
        Me.lblTest1Prompt = New System.Windows.Forms.Label()
        Me.lblTest2Prompt = New System.Windows.Forms.Label()
        Me.LalblTest3Promptbel3 = New System.Windows.Forms.Label()
        Me.lblTest4Prompt = New System.Windows.Forms.Label()
        Me.txtTest1 = New System.Windows.Forms.TextBox()
        Me.txtTest2 = New System.Windows.Forms.TextBox()
        Me.txtTest3 = New System.Windows.Forms.TextBox()
        Me.txtTest4 = New System.Windows.Forms.TextBox()
        Me.btnAvg = New System.Windows.Forms.Button()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTest1Prompt
        '
        Me.lblTest1Prompt.AutoSize = True
        Me.lblTest1Prompt.Location = New System.Drawing.Point(13, 30)
        Me.lblTest1Prompt.Name = "lblTest1Prompt"
        Me.lblTest1Prompt.Size = New System.Drawing.Size(61, 13)
        Me.lblTest1Prompt.TabIndex = 0
        Me.lblTest1Prompt.Text = "Enter test 1"
        '
        'lblTest2Prompt
        '
        Me.lblTest2Prompt.AutoSize = True
        Me.lblTest2Prompt.Location = New System.Drawing.Point(12, 53)
        Me.lblTest2Prompt.Name = "lblTest2Prompt"
        Me.lblTest2Prompt.Size = New System.Drawing.Size(61, 13)
        Me.lblTest2Prompt.TabIndex = 1
        Me.lblTest2Prompt.Text = "Enter test 2"
        '
        'LalblTest3Promptbel3
        '
        Me.LalblTest3Promptbel3.AutoSize = True
        Me.LalblTest3Promptbel3.Location = New System.Drawing.Point(12, 80)
        Me.LalblTest3Promptbel3.Name = "LalblTest3Promptbel3"
        Me.LalblTest3Promptbel3.Size = New System.Drawing.Size(61, 13)
        Me.LalblTest3Promptbel3.TabIndex = 2
        Me.LalblTest3Promptbel3.Text = "Enter test 3"
        '
        'lblTest4Prompt
        '
        Me.lblTest4Prompt.AutoSize = True
        Me.lblTest4Prompt.Location = New System.Drawing.Point(12, 104)
        Me.lblTest4Prompt.Name = "lblTest4Prompt"
        Me.lblTest4Prompt.Size = New System.Drawing.Size(61, 13)
        Me.lblTest4Prompt.TabIndex = 3
        Me.lblTest4Prompt.Text = "Enter test 4"
        '
        'txtTest1
        '
        Me.txtTest1.Location = New System.Drawing.Point(80, 27)
        Me.txtTest1.Name = "txtTest1"
        Me.txtTest1.Size = New System.Drawing.Size(100, 20)
        Me.txtTest1.TabIndex = 4
        '
        'txtTest2
        '
        Me.txtTest2.Location = New System.Drawing.Point(79, 50)
        Me.txtTest2.Name = "txtTest2"
        Me.txtTest2.Size = New System.Drawing.Size(100, 20)
        Me.txtTest2.TabIndex = 5
        '
        'txtTest3
        '
        Me.txtTest3.Location = New System.Drawing.Point(79, 77)
        Me.txtTest3.Name = "txtTest3"
        Me.txtTest3.Size = New System.Drawing.Size(100, 20)
        Me.txtTest3.TabIndex = 6
        '
        'txtTest4
        '
        Me.txtTest4.Location = New System.Drawing.Point(79, 101)
        Me.txtTest4.Name = "txtTest4"
        Me.txtTest4.Size = New System.Drawing.Size(100, 20)
        Me.txtTest4.TabIndex = 7
        '
        'btnAvg
        '
        Me.btnAvg.Location = New System.Drawing.Point(25, 159)
        Me.btnAvg.Name = "btnAvg"
        Me.btnAvg.Size = New System.Drawing.Size(143, 33)
        Me.btnAvg.TabIndex = 8
        Me.btnAvg.Text = "Get Average"
        Me.btnAvg.UseVisualStyleBackColor = True
        '
        'lblAvg
        '
        Me.lblAvg.Location = New System.Drawing.Point(25, 220)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(143, 41)
        Me.lblAvg.TabIndex = 9
        Me.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 305)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.btnAvg)
        Me.Controls.Add(Me.txtTest4)
        Me.Controls.Add(Me.txtTest3)
        Me.Controls.Add(Me.txtTest2)
        Me.Controls.Add(Me.txtTest1)
        Me.Controls.Add(Me.lblTest4Prompt)
        Me.Controls.Add(Me.LalblTest3Promptbel3)
        Me.Controls.Add(Me.lblTest2Prompt)
        Me.Controls.Add(Me.lblTest1Prompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTest1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblTest2Prompt As System.Windows.Forms.Label
    Friend WithEvents LalblTest3Promptbel3 As System.Windows.Forms.Label
    Friend WithEvents lblTest4Prompt As System.Windows.Forms.Label
    Friend WithEvents txtTest1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest4 As System.Windows.Forms.TextBox
    Friend WithEvents btnAvg As System.Windows.Forms.Button
    Friend WithEvents lblAvg As System.Windows.Forms.Label

End Class
