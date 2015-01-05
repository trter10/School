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
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnConcat = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnIndexOf = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnToUpper = New System.Windows.Forms.Button()
        Me.btnToLower = New System.Windows.Forms.Button()
        Me.btnTrim = New System.Windows.Forms.Button()
        Me.btnTrimEnd = New System.Windows.Forms.Button()
        Me.btnTrimStart = New System.Windows.Forms.Button()
        Me.lblString1Prompt = New System.Windows.Forms.Label()
        Me.lblString2Prompt = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(81, 68)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(97, 37)
        Me.btnCompare.TabIndex = 0
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnConcat
        '
        Me.btnConcat.Location = New System.Drawing.Point(81, 111)
        Me.btnConcat.Name = "btnConcat"
        Me.btnConcat.Size = New System.Drawing.Size(97, 37)
        Me.btnConcat.TabIndex = 1
        Me.btnConcat.Text = "Concat"
        Me.btnConcat.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(81, 154)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(97, 37)
        Me.btnEquals.TabIndex = 2
        Me.btnEquals.Text = "Equals"
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnIndexOf
        '
        Me.btnIndexOf.Location = New System.Drawing.Point(81, 197)
        Me.btnIndexOf.Name = "btnIndexOf"
        Me.btnIndexOf.Size = New System.Drawing.Size(97, 37)
        Me.btnIndexOf.TabIndex = 3
        Me.btnIndexOf.Text = "IndexOf"
        Me.btnIndexOf.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(81, 240)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(97, 37)
        Me.btnInsert.TabIndex = 4
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(81, 283)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(97, 37)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(184, 68)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(97, 37)
        Me.btnReplace.TabIndex = 6
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnToUpper
        '
        Me.btnToUpper.Location = New System.Drawing.Point(184, 154)
        Me.btnToUpper.Name = "btnToUpper"
        Me.btnToUpper.Size = New System.Drawing.Size(97, 37)
        Me.btnToUpper.TabIndex = 7
        Me.btnToUpper.Text = "ToUpper"
        Me.btnToUpper.UseVisualStyleBackColor = True
        '
        'btnToLower
        '
        Me.btnToLower.Location = New System.Drawing.Point(184, 111)
        Me.btnToLower.Name = "btnToLower"
        Me.btnToLower.Size = New System.Drawing.Size(97, 37)
        Me.btnToLower.TabIndex = 8
        Me.btnToLower.Text = "ToLower"
        Me.btnToLower.UseVisualStyleBackColor = True
        '
        'btnTrim
        '
        Me.btnTrim.Location = New System.Drawing.Point(184, 197)
        Me.btnTrim.Name = "btnTrim"
        Me.btnTrim.Size = New System.Drawing.Size(97, 37)
        Me.btnTrim.TabIndex = 9
        Me.btnTrim.Text = "Trim"
        Me.btnTrim.UseVisualStyleBackColor = True
        '
        'btnTrimEnd
        '
        Me.btnTrimEnd.Location = New System.Drawing.Point(184, 240)
        Me.btnTrimEnd.Name = "btnTrimEnd"
        Me.btnTrimEnd.Size = New System.Drawing.Size(97, 37)
        Me.btnTrimEnd.TabIndex = 10
        Me.btnTrimEnd.Text = "TrimEnd"
        Me.btnTrimEnd.UseVisualStyleBackColor = True
        '
        'btnTrimStart
        '
        Me.btnTrimStart.Location = New System.Drawing.Point(184, 283)
        Me.btnTrimStart.Name = "btnTrimStart"
        Me.btnTrimStart.Size = New System.Drawing.Size(97, 37)
        Me.btnTrimStart.TabIndex = 11
        Me.btnTrimStart.Text = "TrimStart"
        Me.btnTrimStart.UseVisualStyleBackColor = True
        '
        'lblString1Prompt
        '
        Me.lblString1Prompt.AutoSize = True
        Me.lblString1Prompt.Location = New System.Drawing.Point(94, 9)
        Me.lblString1Prompt.Name = "lblString1Prompt"
        Me.lblString1Prompt.Size = New System.Drawing.Size(69, 13)
        Me.lblString1Prompt.TabIndex = 12
        Me.lblString1Prompt.Text = "Enter a string"
        '
        'lblString2Prompt
        '
        Me.lblString2Prompt.AutoSize = True
        Me.lblString2Prompt.Location = New System.Drawing.Point(94, 42)
        Me.lblString2Prompt.Name = "lblString2Prompt"
        Me.lblString2Prompt.Size = New System.Drawing.Size(69, 13)
        Me.lblString2Prompt.TabIndex = 13
        Me.lblString2Prompt.Text = "Enter a string"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(169, 6)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 14
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(169, 39)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 15
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(12, 323)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(350, 92)
        Me.lblOutput.TabIndex = 16
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 424)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lblString2Prompt)
        Me.Controls.Add(Me.lblString1Prompt)
        Me.Controls.Add(Me.btnTrimStart)
        Me.Controls.Add(Me.btnTrimEnd)
        Me.Controls.Add(Me.btnTrim)
        Me.Controls.Add(Me.btnToLower)
        Me.Controls.Add(Me.btnToUpper)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnIndexOf)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnConcat)
        Me.Controls.Add(Me.btnCompare)
        Me.Name = "Form1"
        Me.Text = "String Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Friend WithEvents btnConcat As System.Windows.Forms.Button
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents btnIndexOf As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnToUpper As System.Windows.Forms.Button
    Friend WithEvents btnToLower As System.Windows.Forms.Button
    Friend WithEvents btnTrim As System.Windows.Forms.Button
    Friend WithEvents btnTrimEnd As System.Windows.Forms.Button
    Friend WithEvents btnTrimStart As System.Windows.Forms.Button
    Friend WithEvents lblString1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblString2Prompt As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label

End Class
