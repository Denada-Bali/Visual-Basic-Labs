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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtCard1 = New TextBox()
        txtCard2 = New TextBox()
        txtCard3 = New TextBox()
        txtCard4 = New TextBox()
        txtCard5 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtOutput = New TextBox()
        BindingSource1 = New BindingSource(components)
        txtSuit1 = New TextBox()
        txtSuit2 = New TextBox()
        txtSuit3 = New TextBox()
        txtSuit4 = New TextBox()
        txtSuit5 = New TextBox()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(54, 240)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 23)
        Button1.TabIndex = 0
        Button1.Text = "Display Type of Hand"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 1
        Label1.Text = "Rank:"' 
        ' Label2
        ' 
        Label2.Location = New Point(12, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 35)
        Label2.TabIndex = 2
        Label2.Text = "Ace =1, Jack =11, Queen =12, King =13"' 
        ' Label3
        ' 
        Label3.Location = New Point(187, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 50)
        Label3.TabIndex = 3
        Label3.Text = "Suit:   Diamonds =D, Hearts =H, Clubs =C, Spades =S"' 
        ' txtCard1
        ' 
        txtCard1.Location = New Point(103, 77)
        txtCard1.Name = "txtCard1"
        txtCard1.Size = New Size(58, 23)
        txtCard1.TabIndex = 4
        ' 
        ' txtCard2
        ' 
        txtCard2.Location = New Point(103, 106)
        txtCard2.Name = "txtCard2"
        txtCard2.Size = New Size(58, 23)
        txtCard2.TabIndex = 5
        ' 
        ' txtCard3
        ' 
        txtCard3.Location = New Point(103, 135)
        txtCard3.Name = "txtCard3"
        txtCard3.Size = New Size(58, 23)
        txtCard3.TabIndex = 6
        ' 
        ' txtCard4
        ' 
        txtCard4.Location = New Point(103, 164)
        txtCard4.Name = "txtCard4"
        txtCard4.Size = New Size(58, 23)
        txtCard4.TabIndex = 7
        ' 
        ' txtCard5
        ' 
        txtCard5.Location = New Point(103, 193)
        txtCard5.Name = "txtCard5"
        txtCard5.Size = New Size(58, 23)
        txtCard5.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 9
        Label4.Text = "Card #1:"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(28, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 10
        Label5.Text = "Card #2:"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(28, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 11
        Label6.Text = "Card #3:"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(28, 172)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 15)
        Label7.TabIndex = 12
        Label7.Text = "Card #4:"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(28, 201)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 15)
        Label8.TabIndex = 13
        Label8.Text = "Card #5:"' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(54, 282)
        txtOutput.Name = "txtOutput"
        txtOutput.ReadOnly = True
        txtOutput.Size = New Size(191, 23)
        txtOutput.TabIndex = 14
        ' 
        ' txtSuit1
        ' 
        txtSuit1.Location = New Point(240, 77)
        txtSuit1.Name = "txtSuit1"
        txtSuit1.Size = New Size(21, 23)
        txtSuit1.TabIndex = 20
        ' 
        ' txtSuit2
        ' 
        txtSuit2.Location = New Point(239, 106)
        txtSuit2.Name = "txtSuit2"
        txtSuit2.Size = New Size(22, 23)
        txtSuit2.TabIndex = 21
        ' 
        ' txtSuit3
        ' 
        txtSuit3.Location = New Point(240, 135)
        txtSuit3.Name = "txtSuit3"
        txtSuit3.Size = New Size(22, 23)
        txtSuit3.TabIndex = 22
        ' 
        ' txtSuit4
        ' 
        txtSuit4.Location = New Point(239, 164)
        txtSuit4.Name = "txtSuit4"
        txtSuit4.Size = New Size(22, 23)
        txtSuit4.TabIndex = 23
        ' 
        ' txtSuit5
        ' 
        txtSuit5.Location = New Point(239, 198)
        txtSuit5.Name = "txtSuit5"
        txtSuit5.Size = New Size(22, 23)
        txtSuit5.TabIndex = 24
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(316, 332)
        Controls.Add(txtSuit5)
        Controls.Add(txtSuit4)
        Controls.Add(txtSuit3)
        Controls.Add(txtSuit2)
        Controls.Add(txtSuit1)
        Controls.Add(txtOutput)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtCard5)
        Controls.Add(txtCard4)
        Controls.Add(txtCard3)
        Controls.Add(txtCard2)
        Controls.Add(txtCard1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Poker"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCard1 As TextBox
    Friend WithEvents txtCard2 As TextBox
    Friend WithEvents txtCard3 As TextBox
    Friend WithEvents txtCard4 As TextBox
    Friend WithEvents txtCard5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtSuit1 As TextBox
    Friend WithEvents txtSuit2 As TextBox
    Friend WithEvents txtSuit3 As TextBox
    Friend WithEvents txtSuit4 As TextBox
    Friend WithEvents txtSuit5 As TextBox
End Class
