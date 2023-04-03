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
        person_lb = New ListBox()
        workplace_lb = New ListBox()
        Button1 = New Button()
        result_tb = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' person_lb
        ' 
        person_lb.FormattingEnabled = True
        person_lb.ItemHeight = 15
        person_lb.Items.AddRange(New Object() {"Bruce Wayne", "Clarck Kent", "Peter Parker", "Rick Blaine", "Willie Wonka"})
        person_lb.Location = New Point(49, 55)
        person_lb.Name = "person_lb"
        person_lb.Size = New Size(120, 94)
        person_lb.TabIndex = 0
        ' 
        ' workplace_lb
        ' 
        workplace_lb.FormattingEnabled = True
        workplace_lb.ItemHeight = 15
        workplace_lb.Items.AddRange(New Object() {"Wayne Enterprises", "Daily Planet", "Daily Bugle", "Rick's American Cafe", "Chocolate Factory"})
        workplace_lb.Location = New Point(248, 55)
        workplace_lb.Name = "workplace_lb"
        workplace_lb.Size = New Size(120, 94)
        workplace_lb.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(95, 165)
        Button1.Name = "Button1"
        Button1.Size = New Size(235, 30)
        Button1.TabIndex = 2
        Button1.Text = "Determine if Match is Correct"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' result_tb
        ' 
        result_tb.Location = New Point(206, 210)
        result_tb.Name = "result_tb"
        result_tb.ReadOnly = True
        result_tb.Size = New Size(77, 23)
        result_tb.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(151, 213)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 4
        Label1.Text = "Answer:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 5
        Label2.Text = "Person:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(243, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 6
        Label3.Text = "Workplace:"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(438, 268)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(result_tb)
        Controls.Add(Button1)
        Controls.Add(workplace_lb)
        Controls.Add(person_lb)
        Name = "Form1"
        Text = "Workplaces"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents person_lb As ListBox
    Friend WithEvents workplace_lb As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents result_tb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
