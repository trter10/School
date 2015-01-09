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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.picDiceOne = New System.Windows.Forms.PictureBox()
        Me.picDiceTwo = New System.Windows.Forms.PictureBox()
        Me.picDiceThree = New System.Windows.Forms.PictureBox()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picDiceOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiceTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiceThree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(77, 37)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(121, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(77, 37)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'picDiceOne
        '
        Me.picDiceOne.Location = New System.Drawing.Point(12, 72)
        Me.picDiceOne.Name = "picDiceOne"
        Me.picDiceOne.Size = New System.Drawing.Size(209, 194)
        Me.picDiceOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceOne.TabIndex = 2
        Me.picDiceOne.TabStop = False
        '
        'picDiceTwo
        '
        Me.picDiceTwo.Location = New System.Drawing.Point(273, 72)
        Me.picDiceTwo.Name = "picDiceTwo"
        Me.picDiceTwo.Size = New System.Drawing.Size(209, 194)
        Me.picDiceTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceTwo.TabIndex = 3
        Me.picDiceTwo.TabStop = False
        '
        'picDiceThree
        '
        Me.picDiceThree.Location = New System.Drawing.Point(536, 72)
        Me.picDiceThree.Name = "picDiceThree"
        Me.picDiceThree.Size = New System.Drawing.Size(209, 194)
        Me.picDiceThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceThree.TabIndex = 4
        Me.picDiceThree.TabStop = False
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 316)
        Me.Controls.Add(Me.picDiceThree)
        Me.Controls.Add(Me.picDiceTwo)
        Me.Controls.Add(Me.picDiceOne)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Dice Roll"
        CType(Me.picDiceOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiceTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiceThree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents picDiceOne As System.Windows.Forms.PictureBox
    Friend WithEvents picDiceTwo As System.Windows.Forms.PictureBox
    Friend WithEvents picDiceThree As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTime As System.Windows.Forms.Timer

End Class
