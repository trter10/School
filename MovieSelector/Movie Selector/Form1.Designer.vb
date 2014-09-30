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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMovieType3 = New System.Windows.Forms.RadioButton()
        Me.radMovieType2 = New System.Windows.Forms.RadioButton()
        Me.radMovieType1 = New System.Windows.Forms.RadioButton()
        Me.lblMovieTitle = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnQuantity1 = New System.Windows.Forms.Button()
        Me.btnQuantity2 = New System.Windows.Forms.Button()
        Me.btnQuantity3 = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.lblTitle.Location = New System.Drawing.Point(137, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(207, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Movie Selector"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.radMovieType3)
        Me.GroupBox1.Controls.Add(Me.radMovieType2)
        Me.GroupBox1.Controls.Add(Me.radMovieType1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'radMovieType3
        '
        Me.radMovieType3.AutoSize = True
        Me.radMovieType3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radMovieType3.Location = New System.Drawing.Point(187, 41)
        Me.radMovieType3.Name = "radMovieType3"
        Me.radMovieType3.Size = New System.Drawing.Size(58, 19)
        Me.radMovieType3.TabIndex = 2
        Me.radMovieType3.TabStop = True
        Me.radMovieType3.Text = "Drama"
        Me.radMovieType3.UseVisualStyleBackColor = True
        '
        'radMovieType2
        '
        Me.radMovieType2.AutoSize = True
        Me.radMovieType2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radMovieType2.Location = New System.Drawing.Point(98, 41)
        Me.radMovieType2.Name = "radMovieType2"
        Me.radMovieType2.Size = New System.Drawing.Size(64, 19)
        Me.radMovieType2.TabIndex = 1
        Me.radMovieType2.TabStop = True
        Me.radMovieType2.Text = "Comedy"
        Me.radMovieType2.UseVisualStyleBackColor = True
        '
        'radMovieType1
        '
        Me.radMovieType1.AutoSize = True
        Me.radMovieType1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.radMovieType1.Location = New System.Drawing.Point(6, 41)
        Me.radMovieType1.Name = "radMovieType1"
        Me.radMovieType1.Size = New System.Drawing.Size(59, 19)
        Me.radMovieType1.TabIndex = 0
        Me.radMovieType1.TabStop = True
        Me.radMovieType1.Text = "Action"
        Me.radMovieType1.UseVisualStyleBackColor = True
        '
        'lblMovieTitle
        '
        Me.lblMovieTitle.AutoSize = True
        Me.lblMovieTitle.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.lblMovieTitle.Location = New System.Drawing.Point(69, 206)
        Me.lblMovieTitle.Name = "lblMovieTitle"
        Me.lblMovieTitle.Size = New System.Drawing.Size(0, 15)
        Me.lblMovieTitle.TabIndex = 2
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Location = New System.Drawing.Point(157, 285)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(155, 13)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "How many movies do you rent?"
        '
        'btnQuantity1
        '
        Me.btnQuantity1.Location = New System.Drawing.Point(76, 327)
        Me.btnQuantity1.Name = "btnQuantity1"
        Me.btnQuantity1.Size = New System.Drawing.Size(75, 23)
        Me.btnQuantity1.TabIndex = 4
        Me.btnQuantity1.Text = "1"
        Me.btnQuantity1.UseVisualStyleBackColor = True
        '
        'btnQuantity2
        '
        Me.btnQuantity2.Location = New System.Drawing.Point(186, 327)
        Me.btnQuantity2.Name = "btnQuantity2"
        Me.btnQuantity2.Size = New System.Drawing.Size(75, 23)
        Me.btnQuantity2.TabIndex = 5
        Me.btnQuantity2.Text = "2"
        Me.btnQuantity2.UseVisualStyleBackColor = True
        '
        'btnQuantity3
        '
        Me.btnQuantity3.Location = New System.Drawing.Point(299, 327)
        Me.btnQuantity3.Name = "btnQuantity3"
        Me.btnQuantity3.Size = New System.Drawing.Size(75, 23)
        Me.btnQuantity3.TabIndex = 6
        Me.btnQuantity3.Text = "3"
        Me.btnQuantity3.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(252, 383)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(207, 383)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total: $"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(447, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(447, 513)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnQuantity3)
        Me.Controls.Add(Me.btnQuantity2)
        Me.Controls.Add(Me.btnQuantity1)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblMovieTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Movie Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radMovieType3 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType2 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblMovieTitle As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnQuantity1 As System.Windows.Forms.Button
    Friend WithEvents btnQuantity2 As System.Windows.Forms.Button
    Friend WithEvents btnQuantity3 As System.Windows.Forms.Button
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
