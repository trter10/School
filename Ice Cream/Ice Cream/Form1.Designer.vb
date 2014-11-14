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
        Me.lstFlavors = New System.Windows.Forms.ListBox()
        Me.cboCone = New System.Windows.Forms.ComboBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblFlavorPrompt = New System.Windows.Forms.Label()
        Me.lblContainerPrompt = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstFlavors
        '
        Me.lstFlavors.FormattingEnabled = True
        Me.lstFlavors.Items.AddRange(New Object() {"Chocolate", "Strawberry", "Vanilla"})
        Me.lstFlavors.Location = New System.Drawing.Point(12, 61)
        Me.lstFlavors.Name = "lstFlavors"
        Me.lstFlavors.Size = New System.Drawing.Size(120, 82)
        Me.lstFlavors.TabIndex = 0
        '
        'cboCone
        '
        Me.cboCone.FormattingEnabled = True
        Me.cboCone.Items.AddRange(New Object() {"Cup", "Sugar Cone", "Waffle Cone"})
        Me.cboCone.Location = New System.Drawing.Point(151, 61)
        Me.cboCone.Name = "cboCone"
        Me.cboCone.Size = New System.Drawing.Size(121, 21)
        Me.cboCone.TabIndex = 1
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(174, 103)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblFlavorPrompt
        '
        Me.lblFlavorPrompt.AutoSize = True
        Me.lblFlavorPrompt.Location = New System.Drawing.Point(12, 45)
        Me.lblFlavorPrompt.Name = "lblFlavorPrompt"
        Me.lblFlavorPrompt.Size = New System.Drawing.Size(36, 13)
        Me.lblFlavorPrompt.TabIndex = 3
        Me.lblFlavorPrompt.Text = "Flavor"
        '
        'lblContainerPrompt
        '
        Me.lblContainerPrompt.AutoSize = True
        Me.lblContainerPrompt.Location = New System.Drawing.Point(148, 45)
        Me.lblContainerPrompt.Name = "lblContainerPrompt"
        Me.lblContainerPrompt.Size = New System.Drawing.Size(56, 13)
        Me.lblContainerPrompt.TabIndex = 4
        Me.lblContainerPrompt.Text = "Cup/Cone"
        '
        'lblOrder
        '
        Me.lblOrder.Location = New System.Drawing.Point(9, 155)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(260, 89)
        Me.lblOrder.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblContainerPrompt)
        Me.Controls.Add(Me.lblFlavorPrompt)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.cboCone)
        Me.Controls.Add(Me.lstFlavors)
        Me.Name = "Form1"
        Me.Text = "Ice Cream"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFlavors As System.Windows.Forms.ListBox
    Friend WithEvents cboCone As System.Windows.Forms.ComboBox
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblFlavorPrompt As System.Windows.Forms.Label
    Friend WithEvents lblContainerPrompt As System.Windows.Forms.Label
    Friend WithEvents lblOrder As System.Windows.Forms.Label

End Class
