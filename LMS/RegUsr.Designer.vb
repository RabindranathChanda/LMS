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
        rutype = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pass = New TextBox()
        rname = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        rph = New TextBox()
        runame = New TextBox()
        reset_btn = New Button()
        reg_btn = New Button()
        Label7 = New Label()
        cpass = New TextBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        Label4.Location = New Point(568, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(225, 44)
        Label4.TabIndex = 8
        Label4.Text = "REGISTER"
        ' 
        ' rutype
        ' 
        rutype.FormattingEnabled = True
        rutype.Items.AddRange(New Object() {"Admin", "Student"})
        rutype.Location = New Point(658, 241)
        rutype.Name = "rutype"
        rutype.Size = New Size(173, 23)
        rutype.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Magenta
        Label3.Location = New Point(542, 346)
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
        Label2.Location = New Point(537, 282)
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
        Label1.Location = New Point(537, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 22)
        Label1.TabIndex = 11
        Label1.Text = "User Type"
        ' 
        ' pass
        ' 
        pass.Font = New Font("Bookman Old Style", 9F)
        pass.Location = New Point(658, 326)
        pass.Multiline = True
        pass.Name = "pass"
        pass.PlaceholderText = "Enter Password"
        pass.Size = New Size(173, 23)
        pass.TabIndex = 10
        pass.UseSystemPasswordChar = True
        ' 
        ' rname
        ' 
        rname.Font = New Font("Bookman Old Style", 9F)
        rname.Location = New Point(658, 157)
        rname.Multiline = True
        rname.Name = "rname"
        rname.Size = New Size(173, 23)
        rname.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Magenta
        Label5.Location = New Point(537, 201)
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
        Label6.Location = New Point(537, 158)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 22)
        Label6.TabIndex = 16
        Label6.Text = "Name"
        ' 
        ' rph
        ' 
        rph.Font = New Font("Bookman Old Style", 9F)
        rph.Location = New Point(658, 200)
        rph.Multiline = True
        rph.Name = "rph"
        rph.PlaceholderText = "+91 "
        rph.Size = New Size(173, 23)
        rph.TabIndex = 17
        ' 
        ' runame
        ' 
        runame.Font = New Font("Bookman Old Style", 9F)
        runame.Location = New Point(658, 281)
        runame.Multiline = True
        runame.Name = "runame"
        runame.Size = New Size(173, 23)
        runame.TabIndex = 18
        ' 
        ' reset_btn
        ' 
        reset_btn.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        reset_btn.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold)
        reset_btn.ForeColor = Color.Magenta
        reset_btn.Location = New Point(694, 409)
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
        reg_btn.Location = New Point(568, 409)
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
        Label7.Font = New Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Magenta
        Label7.Location = New Point(529, 460)
        Label7.Name = "Label7"
        Label7.Size = New Size(310, 19)
        Label7.TabIndex = 21
        Label7.Text = "Already a User ? Click hare to Login."
        ' 
        ' cpass
        ' 
        cpass.Font = New Font("Bookman Old Style", 9F)
        cpass.Location = New Point(658, 364)
        cpass.Multiline = True
        cpass.Name = "cpass"
        cpass.PlaceholderText = "Confirm Password"
        cpass.Size = New Size(173, 23)
        cpass.TabIndex = 22
        cpass.UseSystemPasswordChar = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.passC_icon1
        PictureBox2.Location = New Point(580, 371)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(22, 19)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' RegUsr
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 531)
        Controls.Add(PictureBox2)
        Controls.Add(cpass)
        Controls.Add(Label7)
        Controls.Add(reset_btn)
        Controls.Add(reg_btn)
        Controls.Add(runame)
        Controls.Add(rph)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(rutype)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pass)
        Controls.Add(rname)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegUsr"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rutype As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents rname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rph As TextBox
    Friend WithEvents runame As TextBox
    Friend WithEvents reset_btn As Button
    Friend WithEvents reg_btn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cpass As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
