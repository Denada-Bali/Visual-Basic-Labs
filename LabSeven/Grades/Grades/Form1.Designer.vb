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
        Label3 = New Label()
        Label4 = New Label()
        reportTextBox = New TextBox()
        nameTextBox = New TextBox()
        exam1TextBox = New TextBox()
        exam2TextBox = New TextBox()
        exam3TextBox = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(179, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 1
        Label2.Text = "Exam 1:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(179, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 2
        Label3.Text = "Exam 2:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(179, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 3
        Label4.Text = "Exam 3:"' 
        ' reportTextBox
        ' 
        reportTextBox.Location = New Point(23, 129)
        reportTextBox.Multiline = True
        reportTextBox.Name = "reportTextBox"
        reportTextBox.Size = New Size(268, 172)
        reportTextBox.TabIndex = 4
        ' 
        ' nameTextBox
        ' 
        nameTextBox.Location = New Point(56, 27)
        nameTextBox.Name = "nameTextBox"
        nameTextBox.Size = New Size(105, 23)
        nameTextBox.TabIndex = 5
        ' 
        ' exam1TextBox
        ' 
        exam1TextBox.Location = New Point(233, 24)
        exam1TextBox.Name = "exam1TextBox"
        exam1TextBox.Size = New Size(37, 23)
        exam1TextBox.TabIndex = 6
        ' 
        ' exam2TextBox
        ' 
        exam2TextBox.Location = New Point(233, 55)
        exam2TextBox.Name = "exam2TextBox"
        exam2TextBox.Size = New Size(37, 23)
        exam2TextBox.TabIndex = 7
        ' 
        ' exam3TextBox
        ' 
        exam3TextBox.Location = New Point(233, 91)
        exam3TextBox.Name = "exam3TextBox"
        exam3TextBox.Size = New Size(37, 23)
        exam3TextBox.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(56, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 23)
        Button1.TabIndex = 9
        Button1.Text = "Add Student"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(56, 91)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 23)
        Button2.TabIndex = 10
        Button2.Text = "Display Report"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(179, 307)
        Button3.Name = "Button3"
        Button3.Size = New Size(126, 23)
        Button3.TabIndex = 11
        Button3.Text = "Start a New Session"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(317, 340)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(exam3TextBox)
        Controls.Add(exam2TextBox)
        Controls.Add(exam1TextBox)
        Controls.Add(nameTextBox)
        Controls.Add(reportTextBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Grades"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents reportTextBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents exam1TextBox As TextBox
    Friend WithEvents exam2TextBox As TextBox
    Friend WithEvents exam3TextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
