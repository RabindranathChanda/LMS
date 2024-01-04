<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegUsr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        RegUsr_Pass_TBX = New TextBox()
        RegUsr_LName_TBX = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        RegUsr_Phone_TBX = New TextBox()
        RegUsr_UName_TBX = New TextBox()
        reset_btn = New Button()
        reg_btn = New Button()
        Label7 = New Label()
        RegUsr_CPass_TBX = New TextBox()
        RegUsr_Add_TBX = New TextBox()
        RegUsr_FName_TBX = New TextBox()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.Login_Form1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(870, 531)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bookman Old Style", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Magenta
        Label4.Location = New Point(568, 55)
        Label4.Name = "Label4"
        Label4.Size = New Size(225, 44)
        Label4.TabIndex = 8
        Label4.Text = "REGISTER"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Magenta
        Label3.Location = New Point(532, 346)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 22)
        Label3.TabIndex = 13
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Magenta
        Label2.Location = New Point(532, 294)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 22)
        Label2.TabIndex = 12
        Label2.Text = "User Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Magenta
        Label1.Location = New Point(532, 244)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 22)
        Label1.TabIndex = 11
        Label1.Text = "Address"
        ' 
        ' RegUsr_Pass_TBX
        ' 
        RegUsr_Pass_TBX.Font = New Font("Bookman Old Style", 9.0F)
        RegUsr_Pass_TBX.Location = New Point(658, 326)
        RegUsr_Pass_TBX.Multiline = True
        RegUsr_Pass_TBX.Name = "RegUsr_Pass_TBX"
        RegUsr_Pass_TBX.PlaceholderText = "Enter Password"
        RegUsr_Pass_TBX.Size = New Size(173, 23)
        RegUsr_Pass_TBX.TabIndex = 10
        RegUsr_Pass_TBX.UseSystemPasswordChar = True
        ' 
        ' RegUsr_LName_TBX
        ' 
        RegUsr_LName_TBX.Font = New Font("Bookman Old Style", 9.0F)
        RegUsr_LName_TBX.Location = New Point(658, 157)
        RegUsr_LName_TBX.Multiline = True
        RegUsr_LName_TBX.Name = "RegUsr_LName_TBX"
        RegUsr_LName_TBX.Size = New Size(173, 23)
        RegUsr_LName_TBX.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Magenta
        Label5.Location = New Point(532, 192)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 22)
        Label5.TabIndex = 15
        Label5.Text = "Phone No."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Magenta
        Label6.Location = New Point(532, 158)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 22)
        Label6.TabIndex = 16
        Label6.Text = "Last Name"
        ' 
        ' RegUsr_Phone_TBX
        ' 
        RegUsr_Phone_TBX.Font = New Font("Bookman Old Style", 9.0F)
        RegUsr_Phone_TBX.Location = New Point(658, 191)
        RegUsr_Phone_TBX.Multiline = True
        RegUsr_Phone_TBX.Name = "RegUsr_Phone_TBX"
        RegUsr_Phone_TBX.PlaceholderText = "+91 "
        RegUsr_Phone_TBX.Size = New Size(173, 23)
        RegUsr_Phone_TBX.TabIndex = 17
        ' 
        ' RegUsr_UName_TBX
        ' 
        RegUsr_UName_TBX.Font = New Font("Bookman Old Style", 9.0F)
        RegUsr_UName_TBX.Location = New Point(658, 293)
        RegUsr_UName_TBX.Multiline = True
        RegUsr_UName_TBX.Name = "RegUsr_UName_TBX"
        RegUsr_UName_TBX.PlaceholderText = "e.x.  rabindra@lms.in"
        RegUsr_UName_TBX.Size = New Size(173, 23)
        RegUsr_UName_TBX.TabIndex = 18
        ' 
        ' reset_btn
        ' 
        reset_btn.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        reset_btn.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        reset_btn.ForeColor = Color.Magenta
        reset_btn.Location = New Point(705, 410)
        reset_btn.Name = "reset_btn"
        reset_btn.Size = New Size(88, 32)
        reset_btn.TabIndex = 20
        reset_btn.Text = "Reset"
        reset_btn.UseVisualStyleBackColor = False
        ' 
        ' reg_btn
        ' 
        reg_btn.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        reg_btn.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        reg_btn.ForeColor = Color.Magenta
        reg_btn.Location = New Point(574, 410)
        reg_btn.Name = "reg_btn"
        reg_btn.Size = New Size(103, 32)
        reg_btn.TabIndex = 19
        reg_btn.Text = "Register"
        reg_btn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Magenta
        Label7.Location = New Point(535, 460)
        Label7.Name = "Label7"
        Label7.Size = New Size(295, 18)
        Label7.TabIndex = 21
        Label7.Text = "Already a User ? Click hare to Login."
        ' 
        ' RegUsr_CPass_TBX
        ' 
        RegUsr_CPass_TBX.Font = New Font("Bookman Old Style", 9.0F)
        RegUsr_CPass_TBX.Location = New Point(658, 364)
        RegUsr_CPass_TBX.Multiline = True
        RegUsr_CPass_TBX.Name = "RegUsr_CPass_TBX"
        RegUsr_CPass_TBX.PlaceholderText = "Confirm Password"
        RegUsr_CPass_TBX.Size = New Size(173, 23)
        RegUsr_CPass_TBX.TabIndex = 22
        RegUsr_CPass_TBX.UseSystemPasswordChar = True
        ' 
        ' RegUsr_Add_TBX
        ' 
        RegUsr_Add_TBX.Font = New Font("Bookman Old Style", 9.0F)
        RegUsr_Add_TBX.Location = New Point(658, 226)
        RegUsr_Add_TBX.Multiline = True
        RegUsr_Add_TBX.Name = "RegUsr_Add_TBX"
        RegUsr_Add_TBX.Size = New Size(173, 61)
        RegUsr_Add_TBX.TabIndex = 24
        ' 
        ' RegUsr_FName_TBX
        ' 
        RegUsr_FName_TBX.Font = New Font("Bookman Old Style", 9.0F)
        RegUsr_FName_TBX.Location = New Point(658, 128)
        RegUsr_FName_TBX.Multiline = True
        RegUsr_FName_TBX.Name = "RegUsr_FName_TBX"
        RegUsr_FName_TBX.Size = New Size(173, 23)
        RegUsr_FName_TBX.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label8.ForeColor = Color.Magenta
        Label8.Location = New Point(532, 129)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 22)
        Label8.TabIndex = 26
        Label8.Text = "First Name"
        ' 
        ' RegUsr
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 531)
        Controls.Add(Label8)
        Controls.Add(RegUsr_FName_TBX)
        Controls.Add(RegUsr_Add_TBX)
        Controls.Add(RegUsr_CPass_TBX)
        Controls.Add(Label7)
        Controls.Add(reset_btn)
        Controls.Add(reg_btn)
        Controls.Add(RegUsr_UName_TBX)
        Controls.Add(RegUsr_Phone_TBX)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RegUsr_Pass_TBX)
        Controls.Add(RegUsr_LName_TBX)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegUsr"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RegUsr_Pass_TBX As TextBox
    Friend WithEvents RegUsr_LName_TBX As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RegUsr_Phone_TBX As TextBox
    Friend WithEvents RegUsr_UName_TBX As TextBox
    Friend WithEvents reset_btn As Button
    Friend WithEvents reg_btn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents RegUsr_CPass_TBX As TextBox
    Friend WithEvents RegUsr_Add_TBX As TextBox
    Friend WithEvents RegUsr_FName_TBX As TextBox
    Friend WithEvents Label8 As Label
End Class
