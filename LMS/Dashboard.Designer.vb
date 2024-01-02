<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        icon_img = New PictureBox()
        Close_img = New PictureBox()
        Main_panel = New Panel()
        Help_Panel = New Panel()
        Creds_btn = New Button()
        User_Panel = New Panel()
        AllUsr_btn = New Button()
        Profile_btn = New Button()
        Cust_Panel = New Panel()
        BKReturn_btn = New Button()
        CustSearch_btn = New Button()
        Book_Panel = New Panel()
        BKSearch_btn = New Button()
        BKIssue_btn = New Button()
        AddBK_btn = New Button()
        Admin_Panel = New Panel()
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Admin_login_showPass_chkbx = New CheckBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Admin_Fname_TBX = New TextBox()
        Customer_Panel = New Panel()
        BkIssue_panel = New Panel()
        BkSearch_Panel = New Panel()
        SearchCustomer_Panel = New Panel()
        CurrentProfile_Panel = New Panel()
        AllUsers_Panel = New Panel()
        Credits_Panel = New Panel()
        BkReturn_Panel = New Panel()
        Reg_panel = New Panel()
        Customer_btn = New Button()
        Admin_btn = New Button()
        Menu = New Panel()
        Help_btn = New Button()
        Usr_btn = New Button()
        Cust_btn = New Button()
        BK_btn = New Button()
        Reg_btn = New Button()
        CType(icon_img, ComponentModel.ISupportInitialize).BeginInit()
        CType(Close_img, ComponentModel.ISupportInitialize).BeginInit()
        Main_panel.SuspendLayout()
        Help_Panel.SuspendLayout()
        User_Panel.SuspendLayout()
        Cust_Panel.SuspendLayout()
        Book_Panel.SuspendLayout()
        Admin_Panel.SuspendLayout()
        Customer_Panel.SuspendLayout()
        BkIssue_panel.SuspendLayout()
        BkSearch_Panel.SuspendLayout()
        SearchCustomer_Panel.SuspendLayout()
        CurrentProfile_Panel.SuspendLayout()
        AllUsers_Panel.SuspendLayout()
        Credits_Panel.SuspendLayout()
        Reg_panel.SuspendLayout()
        Menu.SuspendLayout()
        SuspendLayout()
        ' 
        ' icon_img
        ' 
        icon_img.Image = My.Resources.Resources.Setup_Icon
        icon_img.Location = New Point(0, 0)
        icon_img.Name = "icon_img"
        icon_img.Size = New Size(35, 32)
        icon_img.SizeMode = PictureBoxSizeMode.StretchImage
        icon_img.TabIndex = 0
        icon_img.TabStop = False
        ' 
        ' Close_img
        ' 
        Close_img.Image = My.Resources.Resources.close
        Close_img.Location = New Point(1069, 0)
        Close_img.Name = "Close_img"
        Close_img.Size = New Size(37, 32)
        Close_img.SizeMode = PictureBoxSizeMode.StretchImage
        Close_img.TabIndex = 2
        Close_img.TabStop = False
        ' 
        ' Main_panel
        ' 
        Main_panel.BackColor = Color.White
        Main_panel.BackgroundImage = My.Resources.Resources.Dashboard1
        Main_panel.BackgroundImageLayout = ImageLayout.Stretch
        Main_panel.Controls.Add(Help_Panel)
        Main_panel.Controls.Add(User_Panel)
        Main_panel.Controls.Add(Cust_Panel)
        Main_panel.Controls.Add(Book_Panel)
        Main_panel.Controls.Add(Admin_Panel)
        Main_panel.Controls.Add(Reg_panel)
        Main_panel.Controls.Add(Menu)
        Main_panel.Dock = DockStyle.Fill
        Main_panel.Location = New Point(0, 0)
        Main_panel.Name = "Main_panel"
        Main_panel.Size = New Size(1106, 697)
        Main_panel.TabIndex = 0
        ' 
        ' Help_Panel
        ' 
        Help_Panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Help_Panel.Controls.Add(Creds_btn)
        Help_Panel.Location = New Point(1, 29)
        Help_Panel.Name = "Help_Panel"
        Help_Panel.Size = New Size(1106, 30)
        Help_Panel.TabIndex = 7
        ' 
        ' Creds_btn
        ' 
        Creds_btn.BackColor = Color.White
        Creds_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        Creds_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Creds_btn.Location = New Point(11, 3)
        Creds_btn.Name = "Creds_btn"
        Creds_btn.Size = New Size(75, 23)
        Creds_btn.TabIndex = 0
        Creds_btn.Text = "Credits"
        Creds_btn.UseVisualStyleBackColor = False
        ' 
        ' User_Panel
        ' 
        User_Panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        User_Panel.Controls.Add(AllUsr_btn)
        User_Panel.Controls.Add(Profile_btn)
        User_Panel.Location = New Point(1, 29)
        User_Panel.Name = "User_Panel"
        User_Panel.Size = New Size(1106, 30)
        User_Panel.TabIndex = 6
        ' 
        ' AllUsr_btn
        ' 
        AllUsr_btn.BackColor = Color.White
        AllUsr_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        AllUsr_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        AllUsr_btn.Location = New Point(92, 4)
        AllUsr_btn.Name = "AllUsr_btn"
        AllUsr_btn.Size = New Size(75, 23)
        AllUsr_btn.TabIndex = 1
        AllUsr_btn.Text = "All Users"
        AllUsr_btn.UseVisualStyleBackColor = False
        ' 
        ' Profile_btn
        ' 
        Profile_btn.BackColor = Color.White
        Profile_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        Profile_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Profile_btn.Location = New Point(11, 4)
        Profile_btn.Name = "Profile_btn"
        Profile_btn.Size = New Size(75, 23)
        Profile_btn.TabIndex = 0
        Profile_btn.Text = "Profile"
        Profile_btn.UseVisualStyleBackColor = False
        ' 
        ' Cust_Panel
        ' 
        Cust_Panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Cust_Panel.Controls.Add(BKReturn_btn)
        Cust_Panel.Controls.Add(CustSearch_btn)
        Cust_Panel.Location = New Point(1, 29)
        Cust_Panel.Name = "Cust_Panel"
        Cust_Panel.Size = New Size(1106, 30)
        Cust_Panel.TabIndex = 5
        ' 
        ' BKReturn_btn
        ' 
        BKReturn_btn.BackColor = Color.White
        BKReturn_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        BKReturn_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        BKReturn_btn.Location = New Point(11, 4)
        BKReturn_btn.Name = "BKReturn_btn"
        BKReturn_btn.Size = New Size(86, 23)
        BKReturn_btn.TabIndex = 1
        BKReturn_btn.Text = "Return Book"
        BKReturn_btn.UseVisualStyleBackColor = False
        ' 
        ' CustSearch_btn
        ' 
        CustSearch_btn.BackColor = Color.White
        CustSearch_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        CustSearch_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        CustSearch_btn.Location = New Point(103, 4)
        CustSearch_btn.Name = "CustSearch_btn"
        CustSearch_btn.Size = New Size(115, 23)
        CustSearch_btn.TabIndex = 0
        CustSearch_btn.Text = "Search Customer"
        CustSearch_btn.UseVisualStyleBackColor = False
        ' 
        ' Book_Panel
        ' 
        Book_Panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Book_Panel.Controls.Add(BKSearch_btn)
        Book_Panel.Controls.Add(BKIssue_btn)
        Book_Panel.Controls.Add(AddBK_btn)
        Book_Panel.Location = New Point(0, 29)
        Book_Panel.Name = "Book_Panel"
        Book_Panel.Size = New Size(1106, 30)
        Book_Panel.TabIndex = 4
        ' 
        ' BKSearch_btn
        ' 
        BKSearch_btn.BackColor = Color.White
        BKSearch_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        BKSearch_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        BKSearch_btn.Location = New Point(174, 4)
        BKSearch_btn.Name = "BKSearch_btn"
        BKSearch_btn.Size = New Size(75, 23)
        BKSearch_btn.TabIndex = 5
        BKSearch_btn.Text = "Search"
        BKSearch_btn.UseVisualStyleBackColor = False
        ' 
        ' BKIssue_btn
        ' 
        BKIssue_btn.BackColor = Color.White
        BKIssue_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        BKIssue_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        BKIssue_btn.Location = New Point(93, 4)
        BKIssue_btn.Name = "BKIssue_btn"
        BKIssue_btn.Size = New Size(75, 23)
        BKIssue_btn.TabIndex = 4
        BKIssue_btn.Text = "Issue"
        BKIssue_btn.UseVisualStyleBackColor = False
        ' 
        ' AddBK_btn
        ' 
        AddBK_btn.BackColor = Color.White
        AddBK_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        AddBK_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        AddBK_btn.Location = New Point(12, 4)
        AddBK_btn.Name = "AddBK_btn"
        AddBK_btn.Size = New Size(75, 23)
        AddBK_btn.TabIndex = 3
        AddBK_btn.Text = "Add Book"
        AddBK_btn.UseVisualStyleBackColor = False
        ' 
        ' Admin_Panel
        ' 
        Admin_Panel.BackgroundImage = My.Resources.Resources.Reg_Panel_Admin
        Admin_Panel.BackgroundImageLayout = ImageLayout.Stretch
        Admin_Panel.Controls.Add(Label1)
        Admin_Panel.Controls.Add(Button3)
        Admin_Panel.Controls.Add(Button2)
        Admin_Panel.Controls.Add(Button1)
        Admin_Panel.Controls.Add(Admin_login_showPass_chkbx)
        Admin_Panel.Controls.Add(TextBox7)
        Admin_Panel.Controls.Add(TextBox6)
        Admin_Panel.Controls.Add(TextBox5)
        Admin_Panel.Controls.Add(TextBox4)
        Admin_Panel.Controls.Add(TextBox3)
        Admin_Panel.Controls.Add(TextBox2)
        Admin_Panel.Controls.Add(Admin_Fname_TBX)
        Admin_Panel.Controls.Add(Customer_Panel)
        Admin_Panel.Dock = DockStyle.Fill
        Admin_Panel.Location = New Point(0, 60)
        Admin_Panel.Name = "Admin_Panel"
        Admin_Panel.Size = New Size(1106, 637)
        Admin_Panel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Cyan
        Label1.Location = New Point(870, 400)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 21)
        Label1.TabIndex = 12
        Label1.Text = "Label1"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(599, 502)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 35)
        Button3.TabIndex = 11
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(367, 502)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 35)
        Button2.TabIndex = 10
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(137, 502)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 35)
        Button1.TabIndex = 9
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Admin_login_showPass_chkbx
        ' 
        Admin_login_showPass_chkbx.AutoSize = True
        Admin_login_showPass_chkbx.BackColor = Color.Transparent
        Admin_login_showPass_chkbx.Font = New Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Admin_login_showPass_chkbx.ForeColor = Color.Cyan
        Admin_login_showPass_chkbx.Location = New Point(83, 407)
        Admin_login_showPass_chkbx.Name = "Admin_login_showPass_chkbx"
        Admin_login_showPass_chkbx.Size = New Size(121, 21)
        Admin_login_showPass_chkbx.TabIndex = 8
        Admin_login_showPass_chkbx.Text = "Show Password"
        Admin_login_showPass_chkbx.UseVisualStyleBackColor = False
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.MidnightBlue
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.ForeColor = Color.Turquoise
        TextBox7.Location = New Point(193, 365)
        TextBox7.Name = "TextBox7"
        TextBox7.PasswordChar = "*"c
        TextBox7.Size = New Size(178, 23)
        TextBox7.TabIndex = 7
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.MidnightBlue
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.ForeColor = Color.Turquoise
        TextBox6.Location = New Point(595, 365)
        TextBox6.Name = "TextBox6"
        TextBox6.PasswordChar = "*"c
        TextBox6.Size = New Size(178, 23)
        TextBox6.TabIndex = 6
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.MidnightBlue
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.ForeColor = Color.Turquoise
        TextBox5.Location = New Point(207, 325)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(178, 23)
        TextBox5.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.MidnightBlue
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.ForeColor = Color.Turquoise
        TextBox4.Location = New Point(180, 280)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(350, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.MidnightBlue
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.ForeColor = Color.Turquoise
        TextBox3.Location = New Point(206, 244)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "+91"
        TextBox3.Size = New Size(178, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.MidnightBlue
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.ForeColor = Color.Turquoise
        TextBox2.Location = New Point(517, 200)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "e.x. Das"
        TextBox2.Size = New Size(181, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Admin_Fname_TBX
        ' 
        Admin_Fname_TBX.BackColor = Color.MidnightBlue
        Admin_Fname_TBX.BorderStyle = BorderStyle.FixedSingle
        Admin_Fname_TBX.ForeColor = Color.Turquoise
        Admin_Fname_TBX.Location = New Point(207, 200)
        Admin_Fname_TBX.Name = "Admin_Fname_TBX"
        Admin_Fname_TBX.PlaceholderText = "e.x. Abir"
        Admin_Fname_TBX.Size = New Size(178, 23)
        Admin_Fname_TBX.TabIndex = 1
        ' 
        ' Customer_Panel
        ' 
        Customer_Panel.BackgroundImage = My.Resources.Resources.Reg_Panel_Cust
        Customer_Panel.BackgroundImageLayout = ImageLayout.Stretch
        Customer_Panel.Controls.Add(BkIssue_panel)
        Customer_Panel.Location = New Point(0, 585)
        Customer_Panel.Name = "Customer_Panel"
        Customer_Panel.Size = New Size(464, 52)
        Customer_Panel.TabIndex = 0
        ' 
        ' BkIssue_panel
        ' 
        BkIssue_panel.Controls.Add(BkSearch_Panel)
        BkIssue_panel.Location = New Point(0, 274)
        BkIssue_panel.Name = "BkIssue_panel"
        BkIssue_panel.Size = New Size(923, 352)
        BkIssue_panel.TabIndex = 0
        ' 
        ' BkSearch_Panel
        ' 
        BkSearch_Panel.Controls.Add(SearchCustomer_Panel)
        BkSearch_Panel.Location = New Point(0, 247)
        BkSearch_Panel.Name = "BkSearch_Panel"
        BkSearch_Panel.Size = New Size(948, 379)
        BkSearch_Panel.TabIndex = 0
        ' 
        ' SearchCustomer_Panel
        ' 
        SearchCustomer_Panel.Controls.Add(CurrentProfile_Panel)
        SearchCustomer_Panel.Location = New Point(0, 168)
        SearchCustomer_Panel.Name = "SearchCustomer_Panel"
        SearchCustomer_Panel.Size = New Size(977, 458)
        SearchCustomer_Panel.TabIndex = 0
        ' 
        ' CurrentProfile_Panel
        ' 
        CurrentProfile_Panel.Controls.Add(AllUsers_Panel)
        CurrentProfile_Panel.Location = New Point(0, 209)
        CurrentProfile_Panel.Name = "CurrentProfile_Panel"
        CurrentProfile_Panel.Size = New Size(978, 417)
        CurrentProfile_Panel.TabIndex = 0
        ' 
        ' AllUsers_Panel
        ' 
        AllUsers_Panel.Controls.Add(Credits_Panel)
        AllUsers_Panel.Location = New Point(0, 58)
        AllUsers_Panel.Name = "AllUsers_Panel"
        AllUsers_Panel.Size = New Size(1036, 568)
        AllUsers_Panel.TabIndex = 0
        ' 
        ' Credits_Panel
        ' 
        Credits_Panel.Controls.Add(BkReturn_Panel)
        Credits_Panel.Location = New Point(0, 193)
        Credits_Panel.Name = "Credits_Panel"
        Credits_Panel.Size = New Size(838, 433)
        Credits_Panel.TabIndex = 0
        ' 
        ' BkReturn_Panel
        ' 
        BkReturn_Panel.Location = New Point(0, 17)
        BkReturn_Panel.Name = "BkReturn_Panel"
        BkReturn_Panel.Size = New Size(819, 609)
        BkReturn_Panel.TabIndex = 0
        ' 
        ' Reg_panel
        ' 
        Reg_panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Reg_panel.Controls.Add(Customer_btn)
        Reg_panel.Controls.Add(Admin_btn)
        Reg_panel.Dock = DockStyle.Top
        Reg_panel.Location = New Point(0, 30)
        Reg_panel.Name = "Reg_panel"
        Reg_panel.Size = New Size(1106, 30)
        Reg_panel.TabIndex = 3
        ' 
        ' Customer_btn
        ' 
        Customer_btn.BackColor = Color.White
        Customer_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        Customer_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Customer_btn.Location = New Point(93, 3)
        Customer_btn.Name = "Customer_btn"
        Customer_btn.Size = New Size(75, 23)
        Customer_btn.TabIndex = 5
        Customer_btn.Text = "Customer"
        Customer_btn.UseVisualStyleBackColor = False
        ' 
        ' Admin_btn
        ' 
        Admin_btn.BackColor = Color.White
        Admin_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        Admin_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Admin_btn.Location = New Point(12, 4)
        Admin_btn.Name = "Admin_btn"
        Admin_btn.Size = New Size(75, 23)
        Admin_btn.TabIndex = 4
        Admin_btn.Text = "Admin"
        Admin_btn.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        Menu.BackColor = Color.Indigo
        Menu.Controls.Add(Help_btn)
        Menu.Controls.Add(Usr_btn)
        Menu.Controls.Add(Cust_btn)
        Menu.Controls.Add(BK_btn)
        Menu.Controls.Add(Reg_btn)
        Menu.Controls.Add(Close_img)
        Menu.Controls.Add(icon_img)
        Menu.Dock = DockStyle.Top
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Size = New Size(1106, 30)
        Menu.TabIndex = 2
        ' 
        ' Help_btn
        ' 
        Help_btn.BackColor = Color.White
        Help_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        Help_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Help_btn.Location = New Point(367, 4)
        Help_btn.Name = "Help_btn"
        Help_btn.Size = New Size(75, 23)
        Help_btn.TabIndex = 7
        Help_btn.Text = "Help"
        Help_btn.UseVisualStyleBackColor = False
        ' 
        ' Usr_btn
        ' 
        Usr_btn.BackColor = Color.White
        Usr_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        Usr_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Usr_btn.Location = New Point(286, 4)
        Usr_btn.Name = "Usr_btn"
        Usr_btn.Size = New Size(75, 23)
        Usr_btn.TabIndex = 6
        Usr_btn.Text = "Users"
        Usr_btn.UseVisualStyleBackColor = False
        ' 
        ' Cust_btn
        ' 
        Cust_btn.BackColor = Color.White
        Cust_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        Cust_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Cust_btn.Location = New Point(205, 4)
        Cust_btn.Name = "Cust_btn"
        Cust_btn.Size = New Size(75, 23)
        Cust_btn.TabIndex = 5
        Cust_btn.Text = "Customer"
        Cust_btn.UseVisualStyleBackColor = False
        ' 
        ' BK_btn
        ' 
        BK_btn.BackColor = Color.White
        BK_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        BK_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        BK_btn.Location = New Point(124, 4)
        BK_btn.Name = "BK_btn"
        BK_btn.Size = New Size(75, 23)
        BK_btn.TabIndex = 4
        BK_btn.Text = "Books"
        BK_btn.UseVisualStyleBackColor = False
        ' 
        ' Reg_btn
        ' 
        Reg_btn.BackColor = Color.White
        Reg_btn.Font = New Font("Book Antiqua", 9F, FontStyle.Bold)
        Reg_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Reg_btn.Location = New Point(43, 4)
        Reg_btn.Name = "Reg_btn"
        Reg_btn.Size = New Size(75, 23)
        Reg_btn.TabIndex = 3
        Reg_btn.Text = "Register"
        Reg_btn.UseVisualStyleBackColor = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1106, 697)
        Controls.Add(Main_panel)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        CType(icon_img, ComponentModel.ISupportInitialize).EndInit()
        CType(Close_img, ComponentModel.ISupportInitialize).EndInit()
        Main_panel.ResumeLayout(False)
        Help_Panel.ResumeLayout(False)
        User_Panel.ResumeLayout(False)
        Cust_Panel.ResumeLayout(False)
        Book_Panel.ResumeLayout(False)
        Admin_Panel.ResumeLayout(False)
        Admin_Panel.PerformLayout()
        Customer_Panel.ResumeLayout(False)
        BkIssue_panel.ResumeLayout(False)
        BkSearch_Panel.ResumeLayout(False)
        SearchCustomer_Panel.ResumeLayout(False)
        CurrentProfile_Panel.ResumeLayout(False)
        AllUsers_Panel.ResumeLayout(False)
        Credits_Panel.ResumeLayout(False)
        Reg_panel.ResumeLayout(False)
        Menu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents icon_img As PictureBox
    Friend WithEvents Close_img As PictureBox
    Friend WithEvents Main_panel As Panel
    Friend WithEvents Menu As Panel
    Friend WithEvents Admin_Panel As Panel
    Friend WithEvents Customer_Panel As Panel
    Friend WithEvents BkIssue_panel As Panel
    Friend WithEvents BkSearch_Panel As Panel
    Friend WithEvents SearchCustomer_Panel As Panel
    Friend WithEvents CurrentProfile_Panel As Panel
    Friend WithEvents AllUsers_Panel As Panel
    Friend WithEvents Credits_Panel As Panel
    Friend WithEvents BkReturn_Panel As Panel
    Friend WithEvents Reg_btn As Button
    Friend WithEvents Cust_btn As Button
    Friend WithEvents BK_btn As Button
    Friend WithEvents Help_btn As Button
    Friend WithEvents Usr_btn As Button
    Friend WithEvents Reg_panel As Panel
    Friend WithEvents Customer_btn As Button
    Friend WithEvents Admin_btn As Button
    Friend WithEvents Book_Panel As Panel
    Friend WithEvents Cust_Panel As Panel
    Friend WithEvents User_Panel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Profile_btn As Button
    Friend WithEvents AllUsr_btn As Button
    Friend WithEvents Help_Panel As Panel
    Friend WithEvents Creds_btn As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents CustSearch_btn As Button
    Friend WithEvents AddBK_btn As Button
    Friend WithEvents BKIssue_btn As Button
    Friend WithEvents BKReturn_btn As Button
    Friend WithEvents BKSearch_btn As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Admin_Fname_TBX As TextBox
    Friend WithEvents Admin_login_showPass_chkbx As CheckBox
    Friend WithEvents Label1 As Label
End Class
