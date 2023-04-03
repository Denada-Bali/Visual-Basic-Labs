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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(132, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(132, 94)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(132, 144)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(182, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(132, 194)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(81, 23)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(132, 241)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(81, 23)
        TextBox5.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(39, 302)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 23)
        Button1.TabIndex = 6
        Button1.Text = "Process Order"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(239, 302)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 23)
        Button2.TabIndex = 7
        Button2.Text = "Clear Order Form"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(433, 302)
        Button3.Name = "Button3"
        Button3.Size = New Size(163, 23)
        Button3.TabIndex = 8
        Button3.Text = "Quit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(23, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 32)
        Label1.TabIndex = 9
        Label1.Text = "Customer Name (Last, First):"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 10
        Label2.Text = "Address:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 15)
        Label3.TabIndex = 11
        Label3.Text = "City, State, Zip:"' 
        ' Label4
        ' 
        Label4.Location = New Point(35, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 38)
        Label4.TabIndex = 12
        Label4.Text = "Number of Chairs Ordered:"' 
        ' Label5
        ' 
        Label5.Location = New Point(40, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 40)
        Label5.TabIndex = 13
        Label5.Text = "Number of Sofas Ordered:"' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 14
        ListBox1.Location = New Point(360, 48)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(225, 214)
        ListBox1.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(645, 356)
        Controls.Add(ListBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Furniture Order Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
