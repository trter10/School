﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnInsult = New System.Windows.Forms.Button()
        Me.lblInsult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInsult
        '
        Me.btnInsult.Location = New System.Drawing.Point(12, 12)
        Me.btnInsult.Name = "btnInsult"
        Me.btnInsult.Size = New System.Drawing.Size(260, 30)
        Me.btnInsult.TabIndex = 0
        Me.btnInsult.Text = "Insult me"
        Me.btnInsult.UseVisualStyleBackColor = True
        '
        'lblInsult
        '
        Me.lblInsult.Location = New System.Drawing.Point(12, 59)
        Me.lblInsult.Name = "lblInsult"
        Me.lblInsult.Size = New System.Drawing.Size(260, 103)
        Me.lblInsult.TabIndex = 1
        Me.lblInsult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 171)
        Me.Controls.Add(Me.lblInsult)
        Me.Controls.Add(Me.btnInsult)
        Me.Name = "Form1"
        Me.Text = "Shakespearean Insults"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsult As System.Windows.Forms.Button
    Friend WithEvents lblInsult As System.Windows.Forms.Label

End Class
