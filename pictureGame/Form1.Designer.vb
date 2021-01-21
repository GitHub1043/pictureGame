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
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.radOption1 = New System.Windows.Forms.RadioButton()
        Me.radOption2 = New System.Windows.Forms.RadioButton()
        Me.radOption3 = New System.Windows.Forms.RadioButton()
        Me.radOption4 = New System.Windows.Forms.RadioButton()
        Me.btnCheck = New System.Windows.Forms.Button()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(319, 20)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(522, 245)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 0
        Me.picImage.TabStop = False
        '
        'radOption1
        '
        Me.radOption1.AutoSize = True
        Me.radOption1.Location = New System.Drawing.Point(251, 291)
        Me.radOption1.Name = "radOption1"
        Me.radOption1.Size = New System.Drawing.Size(65, 17)
        Me.radOption1.TabIndex = 1
        Me.radOption1.TabStop = True
        Me.radOption1.Text = "Option 1"
        Me.radOption1.UseVisualStyleBackColor = True
        '
        'radOption2
        '
        Me.radOption2.AutoSize = True
        Me.radOption2.Location = New System.Drawing.Point(435, 291)
        Me.radOption2.Name = "radOption2"
        Me.radOption2.Size = New System.Drawing.Size(65, 17)
        Me.radOption2.TabIndex = 2
        Me.radOption2.TabStop = True
        Me.radOption2.Text = "Option 2"
        Me.radOption2.UseVisualStyleBackColor = True
        '
        'radOption3
        '
        Me.radOption3.AutoSize = True
        Me.radOption3.Location = New System.Drawing.Point(619, 291)
        Me.radOption3.Name = "radOption3"
        Me.radOption3.Size = New System.Drawing.Size(65, 17)
        Me.radOption3.TabIndex = 3
        Me.radOption3.TabStop = True
        Me.radOption3.Text = "Option 3"
        Me.radOption3.UseVisualStyleBackColor = True
        '
        'radOption4
        '
        Me.radOption4.AutoSize = True
        Me.radOption4.Location = New System.Drawing.Point(803, 291)
        Me.radOption4.Name = "radOption4"
        Me.radOption4.Size = New System.Drawing.Size(65, 17)
        Me.radOption4.TabIndex = 4
        Me.radOption4.TabStop = True
        Me.radOption4.Text = "Option 4"
        Me.radOption4.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(543, 395)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "Check Guess"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 450)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.radOption4)
        Me.Controls.Add(Me.radOption3)
        Me.Controls.Add(Me.radOption2)
        Me.Controls.Add(Me.radOption1)
        Me.Controls.Add(Me.picImage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents radOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents radOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents radOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents radOption4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnCheck As System.Windows.Forms.Button

End Class
