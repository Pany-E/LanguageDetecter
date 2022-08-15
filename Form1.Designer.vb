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
        Me.lblWhatLanguage = New System.Windows.Forms.Label()
        Me.TxtLanguage = New System.Windows.Forms.TextBox()
        Me.BtnGreet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWhatLanguage
        '
        Me.lblWhatLanguage.AutoSize = True
        Me.lblWhatLanguage.Location = New System.Drawing.Point(115, 88)
        Me.lblWhatLanguage.Name = "lblWhatLanguage"
        Me.lblWhatLanguage.Size = New System.Drawing.Size(207, 17)
        Me.lblWhatLanguage.TabIndex = 0
        Me.lblWhatLanguage.Text = "Which language do you speak?"
        '
        'TxtLanguage
        '
        Me.TxtLanguage.Location = New System.Drawing.Point(394, 95)
        Me.TxtLanguage.Name = "TxtLanguage"
        Me.TxtLanguage.Size = New System.Drawing.Size(316, 22)
        Me.TxtLanguage.TabIndex = 1
        '
        'BtnGreet
        '
        Me.BtnGreet.Location = New System.Drawing.Point(393, 165)
        Me.BtnGreet.Name = "BtnGreet"
        Me.BtnGreet.Size = New System.Drawing.Size(173, 81)
        Me.BtnGreet.TabIndex = 2
        Me.BtnGreet.Text = "Greeting"
        Me.BtnGreet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnGreet)
        Me.Controls.Add(Me.TxtLanguage)
        Me.Controls.Add(Me.lblWhatLanguage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWhatLanguage As Label
    Friend WithEvents TxtLanguage As TextBox
    Friend WithEvents BtnGreet As Button
End Class
