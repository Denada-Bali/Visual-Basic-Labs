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
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        GroupBox1 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        GroupBox3 = New GroupBox()
        RadioButton9 = New RadioButton()
        RadioButton8 = New RadioButton()
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(72, 93)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(66, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Burgers"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(72, 226)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(50, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Fries"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(72, 342)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(59, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Drinks"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(178, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 128)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Choices for Burgers"
        GroupBox1.Visible = False
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(20, 97)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(169, 19)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "w/ bacon and cheese (5.39)"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(20, 72)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(107, 19)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "w/ bacon (4.79)"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(20, 47)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(110, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "w/ cheese (4.79)"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(20, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Regular (4.19)"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton7)
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Controls.Add(RadioButton5)
        GroupBox2.Location = New Point(180, 179)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(198, 112)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Choices for Fries"
        GroupBox2.Visible = False
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(33, 72)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(86, 19)
        RadioButton7.TabIndex = 2
        RadioButton7.TabStop = True
        RadioButton7.Text = "Large (4.99)"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(33, 47)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(102, 19)
        RadioButton6.TabIndex = 1
        RadioButton6.TabStop = True
        RadioButton6.Text = "Medium (3.09)"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(33, 22)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(86, 19)
        RadioButton5.TabIndex = 0
        RadioButton5.TabStop = True
        RadioButton5.Text = "Small (2.39)"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton9)
        GroupBox3.Controls.Add(RadioButton8)
        GroupBox3.Location = New Point(178, 323)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(200, 81)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Choices for Drink"
        GroupBox3.Visible = False
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AutoSize = True
        RadioButton9.Location = New Point(20, 47)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(129, 19)
        RadioButton9.TabIndex = 4
        RadioButton9.TabStop = True
        RadioButton9.Text = "Bottled Water (1.49)"
        RadioButton9.TextAlign = ContentAlignment.MiddleCenter
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(20, 22)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(83, 19)
        RadioButton8.TabIndex = 3
        RadioButton8.TabStop = True
        RadioButton8.Text = "Soda (1.69)"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(422, 339)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 23)
        Button1.TabIndex = 6
        Button1.Text = "Compute Cost of Meal"
        Button1.UseVisualStyleBackColor = True
        Button1.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(398, 382)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 7
        Label1.Text = "Cost of meal"
        Label1.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(478, 379)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(88, 23)
        TextBox1.TabIndex = 8
        TextBox1.Visible = False
        TextBox1.WordWrap = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(515, 452)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "New Order"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(602, 487)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Name = "Form1"
        Text = "Menu"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
End Class
