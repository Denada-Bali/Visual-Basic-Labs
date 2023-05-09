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
        Button1 = New Button()
        dgvOutput = New DataGridView()
        Button2 = New Button()
        CType(dgvOutput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(97, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 23)
        Button1.TabIndex = 0
        Button1.Text = "Display Standings"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dgvOutput
        ' 
        dgvOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOutput.Location = New Point(24, 64)
        dgvOutput.Name = "dgvOutput"
        dgvOutput.RowTemplate.Height = 25
        dgvOutput.Size = New Size(249, 173)
        dgvOutput.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(224, 304)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(319, 339)
        Controls.Add(Button2)
        Controls.Add(dgvOutput)
        Controls.Add(Button1)
        Name = "Form1"
        Text = " Soccer League "
        CType(dgvOutput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dgvOutput As DataGridView
    Friend WithEvents Button2 As Button
End Class
