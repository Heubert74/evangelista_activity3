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
        txtFirstnum = New TextBox()
        txtSecondnum = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblResult = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(48, 50)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(100, 23)
        txtFirstnum.TabIndex = 0
        txtFirstnum.Text = "label1"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(48, 123)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(100, 23)
        txtSecondnum.TabIndex = 1
        txtSecondnum.Text = "label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 2
        Label1.Text = "firstnum"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 3
        Label2.Text = "secondsum"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(148, 182)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(39, 15)
        lblResult.TabIndex = 4
        lblResult.Text = "Result"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(48, 160)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Enter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(226, 220)
        Controls.Add(Button1)
        Controls.Add(lblResult)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSecondnum)
        Controls.Add(txtFirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents Button1 As Button
End Class
