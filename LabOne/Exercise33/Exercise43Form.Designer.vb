<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise43Form
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
        Button6 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(25, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(221, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(11, 94)
        Button6.Name = "Button6"
        Button6.Size = New Size(116, 23)
        Button6.TabIndex = 16
        Button6.Text = "Back to Exercise 35"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(146, 94)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 23)
        Button1.TabIndex = 17
        Button1.Text = "Exercise 44"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(39, 52)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 23)
        Button2.TabIndex = 18
        Button2.Text = "Button One"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(146, 52)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 23)
        Button3.TabIndex = 19
        Button3.Text = "Button Two"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Exeercise43Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(300, 149)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Button6)
        Controls.Add(TextBox1)
        Name = "Exeercise43Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Exeercise 43"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
