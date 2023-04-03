<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        add_btn = New Button()
        mul_btn = New Button()
        sub_btn = New Button()
        div_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter the First Number"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(276, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter the Second Number"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(43, 91)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(102, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(292, 91)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(108, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(104, 176)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(242, 23)
        TextBox3.TabIndex = 4
        ' 
        ' add_btn
        ' 
        add_btn.Location = New Point(177, 21)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(75, 23)
        add_btn.TabIndex = 5
        add_btn.Text = "Add"
        add_btn.UseVisualStyleBackColor = True
        ' 
        ' mul_btn
        ' 
        mul_btn.Location = New Point(177, 58)
        mul_btn.Name = "mul_btn"
        mul_btn.Size = New Size(75, 23)
        mul_btn.TabIndex = 6
        mul_btn.Text = "Multiply"
        mul_btn.UseVisualStyleBackColor = True
        ' 
        ' sub_btn
        ' 
        sub_btn.Location = New Point(177, 91)
        sub_btn.Name = "sub_btn"
        sub_btn.Size = New Size(75, 23)
        sub_btn.TabIndex = 7
        sub_btn.Text = "Substract"
        sub_btn.UseVisualStyleBackColor = True
        ' 
        ' div_btn
        ' 
        div_btn.Location = New Point(177, 129)
        div_btn.Name = "div_btn"
        div_btn.Size = New Size(75, 23)
        div_btn.TabIndex = 8
        div_btn.Text = "Divide"
        div_btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 233)
        Controls.Add(div_btn)
        Controls.Add(sub_btn)
        Controls.Add(mul_btn)
        Controls.Add(add_btn)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents add_btn As Button
    Friend WithEvents mul_btn As Button
    Friend WithEvents sub_btn As Button
    Friend WithEvents div_btn As Button
End Class
