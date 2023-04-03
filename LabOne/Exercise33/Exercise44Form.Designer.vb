<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise44Form
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(28, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(315, 23)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Less is more."' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(29, 88)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(314, 23)
        TextBox2.TabIndex = 1
        TextBox2.Text = "Less is more."' 
        ' Button6
        ' 
        Button6.Location = New Point(131, 126)
        Button6.Name = "Button6"
        Button6.Size = New Size(116, 23)
        Button6.TabIndex = 18
        Button6.Text = "Back to Exercise 43"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Exercise44Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(377, 161)
        Controls.Add(Button6)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Exercise44Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Exercise 44"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button6 As Button
End Class
