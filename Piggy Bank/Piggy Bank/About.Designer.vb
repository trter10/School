﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAbout
        '
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(12, 9)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(260, 68)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = "A puggy bunk is a way to save money."
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(59, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(170, 53)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 146)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAbout)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
