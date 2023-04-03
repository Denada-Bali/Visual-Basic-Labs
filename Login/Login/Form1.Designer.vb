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
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        LinkLabel2 = New LinkLabel()
        loginBTN = New Button()
        Label4 = New Label()
        CheckBox1 = New CheckBox()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(244, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 17)
        Label1.TabIndex = 0
        Label1.Text = "Username"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(249, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 17)
        Label2.TabIndex = 1
        Label2.Text = "Password"' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(318, 171)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(224, 24)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(318, 222)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(224, 24)
        TextBox2.TabIndex = 3
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(442, 253)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(100, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(385, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 32)
        Label3.TabIndex = 5
        Label3.Text = "Login"' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 51)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(LinkLabel2)
        Panel2.Location = New Point(1, 398)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(799, 51)
        Panel2.TabIndex = 7
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(548, 19)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(205, 15)
        LinkLabel2.TabIndex = 0
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Don't have an account? Register here."' 
        ' loginBTN
        ' 
        loginBTN.BackColor = SystemColors.InactiveCaption
        loginBTN.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point)
        loginBTN.Location = New Point(369, 297)
        loginBTN.Name = "loginBTN"
        loginBTN.Size = New Size(129, 29)
        loginBTN.TabIndex = 8
        loginBTN.Text = "Login"
        loginBTN.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(459, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 17)
        Label4.TabIndex = 9
        Label4.Text = "Clear"' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(318, 252)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckBox1)
        Controls.Add(Label4)
        Controls.Add(loginBTN)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents loginBTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
