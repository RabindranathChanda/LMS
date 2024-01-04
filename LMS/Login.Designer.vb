<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Label4 = New Label()
        Login_UName_TBX = New TextBox()
        Login_Pass_TBX = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        login_btn = New Button()
        cancel_btn = New Button()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Login_ShowPass_ChkBx = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bookman Old Style", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Magenta
        Label4.Location = New Point(614, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 44)
        Label4.TabIndex = 7
        Label4.Text = "LOGIN"
        ' 
        ' Login_UName_TBX
        ' 
        Login_UName_TBX.Font = New Font("Bookman Old Style", 9F)
        Login_UName_TBX.Location = New Point(543, 216)
        Login_UName_TBX.Multiline = True
        Login_UName_TBX.Name = "Login_UName_TBX"
        Login_UName_TBX.PlaceholderText = "e.x.  admin@lms.in"
        Login_UName_TBX.Size = New Size(269, 23)
        Login_UName_TBX.TabIndex = 1
        ' 
        ' Login_Pass_TBX
        ' 
        Login_Pass_TBX.Font = New Font("Bookman Old Style", 9F)
        Login_Pass_TBX.Location = New Point(543, 289)
        Login_Pass_TBX.Multiline = True
        Login_Pass_TBX.Name = "Login_Pass_TBX"
        Login_Pass_TBX.PasswordChar = "*"c
        Login_Pass_TBX.PlaceholderText = "Enter Password"
        Login_Pass_TBX.Size = New Size(269, 23)
        Login_Pass_TBX.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Magenta
        Label2.Location = New Point(543, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 22)
        Label2.TabIndex = 4
        Label2.Text = "User Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Silver
        Label3.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Magenta
        Label3.Location = New Point(543, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 22)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' login_btn
        ' 
        login_btn.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        login_btn.Cursor = Cursors.Hand
        login_btn.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        login_btn.ForeColor = Color.Magenta
        login_btn.Location = New Point(577, 352)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(88, 32)
        login_btn.TabIndex = 11
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = False
        ' 
        ' cancel_btn
        ' 
        cancel_btn.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cancel_btn.Cursor = Cursors.Hand
        cancel_btn.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        cancel_btn.ForeColor = Color.Magenta
        cancel_btn.Location = New Point(703, 352)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(88, 32)
        cancel_btn.TabIndex = 12
        cancel_btn.Text = "Cancel"
        cancel_btn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Login_Form1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(871, 529)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Magenta
        Label5.Location = New Point(538, 430)
        Label5.Name = "Label5"
        Label5.Size = New Size(290, 19)
        Label5.TabIndex = 14
        Label5.Text = "New User ? Click hare to Register."
        ' 
        ' Login_ShowPass_ChkBx
        ' 
        Login_ShowPass_ChkBx.AutoSize = True
        Login_ShowPass_ChkBx.Font = New Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login_ShowPass_ChkBx.ForeColor = Color.Indigo
        Login_ShowPass_ChkBx.Location = New Point(543, 318)
        Login_ShowPass_ChkBx.Name = "Login_ShowPass_ChkBx"
        Login_ShowPass_ChkBx.Size = New Size(113, 21)
        Login_ShowPass_ChkBx.TabIndex = 15
        Login_ShowPass_ChkBx.Text = "Show Password"
        Login_ShowPass_ChkBx.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 529)
        Controls.Add(Login_ShowPass_ChkBx)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(cancel_btn)
        Controls.Add(Label2)
        Controls.Add(login_btn)
        Controls.Add(Login_Pass_TBX)
        Controls.Add(Label4)
        Controls.Add(Login_UName_TBX)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Login_UName_TBX As TextBox
    Friend WithEvents Login_Pass_TBX As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents login_btn As Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Login_ShowPass_ChkBx As CheckBox

End Class
