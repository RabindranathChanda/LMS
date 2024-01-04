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
        Book_Panel = New Panel()
        Cust_Panel = New Panel()
        BKReturn_btn = New Button()
        CustSearch_btn = New Button()
        BKSearch_btn = New Button()
        BKIssue_btn = New Button()
        AddBK_btn = New Button()
        Reg_panel = New Panel()
        Admin_btn = New Button()
        Admin_Panel = New Panel()
        BkIssue_panel = New Panel()
        BkSearch_Panel = New Panel()
        SearchCustomer_Panel = New Panel()
        CurrentProfile_Panel = New Panel()
        AllUsers_Panel = New Panel()
        Credits_Panel = New Panel()
        BkReturn_Panel = New Panel()
        Add_BK_Panel = New Panel()
        AddBK_Close_btn = New Button()
        AddBK_Submit_btn = New Button()
        AddBK_DateTimePicker = New DateTimePicker()
        AddBK_PubName_TBX = New TextBox()
        AddBK_Qnt_TBX = New TextBox()
        AddBK_Authname_TBX = New TextBox()
        AddBK_BKID_TBX = New TextBox()
        AddBK_BKName_TBX = New TextBox()
        Admin_Pass_TBX = New TextBox()
        Admin_CPass_TBX = New TextBox()
        Admin_UName_TBX = New TextBox()
        Admin_Add_TBX = New TextBox()
        Admin_Phone_TBX = New TextBox()
        Admin_Lname_TBX = New TextBox()
        Admin_Fname_TBX = New TextBox()
        Admin_Cancel_btn = New Button()
        Admin_Reset_btn = New Button()
        Admin_Submit_btn = New Button()
        Admin_login_showPass_chkbx = New CheckBox()
        Menu = New Panel()
        Dash_LogOut_btn = New Button()
        Label2 = New Label()
        Label1 = New Label()
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
        Book_Panel.SuspendLayout()
        Cust_Panel.SuspendLayout()
        Reg_panel.SuspendLayout()
        Admin_Panel.SuspendLayout()
        BkIssue_panel.SuspendLayout()
        BkSearch_Panel.SuspendLayout()
        SearchCustomer_Panel.SuspendLayout()
        CurrentProfile_Panel.SuspendLayout()
        AllUsers_Panel.SuspendLayout()
        Credits_Panel.SuspendLayout()
        Add_BK_Panel.SuspendLayout()
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
        Main_panel.Controls.Add(Book_Panel)
        Main_panel.Controls.Add(Reg_panel)
        Main_panel.Controls.Add(Admin_Panel)
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
        Help_Panel.Location = New Point(1, 31)
        Help_Panel.Name = "Help_Panel"
        Help_Panel.Size = New Size(1106, 30)
        Help_Panel.TabIndex = 7
        ' 
        ' Creds_btn
        ' 
        Creds_btn.BackColor = Color.White
        Creds_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        User_Panel.Location = New Point(1, 31)
        User_Panel.Name = "User_Panel"
        User_Panel.Size = New Size(1106, 30)
        User_Panel.TabIndex = 6
        ' 
        ' AllUsr_btn
        ' 
        AllUsr_btn.BackColor = Color.White
        AllUsr_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        Profile_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
        Profile_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Profile_btn.Location = New Point(11, 4)
        Profile_btn.Name = "Profile_btn"
        Profile_btn.Size = New Size(75, 23)
        Profile_btn.TabIndex = 0
        Profile_btn.Text = "Profile"
        Profile_btn.UseVisualStyleBackColor = False
        ' 
        ' Book_Panel
        ' 
        Book_Panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Book_Panel.Controls.Add(Cust_Panel)
        Book_Panel.Controls.Add(BKSearch_btn)
        Book_Panel.Controls.Add(BKIssue_btn)
        Book_Panel.Controls.Add(AddBK_btn)
        Book_Panel.Location = New Point(0, 30)
        Book_Panel.Name = "Book_Panel"
        Book_Panel.Size = New Size(1106, 30)
        Book_Panel.TabIndex = 4
        ' 
        ' Cust_Panel
        ' 
        Cust_Panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Cust_Panel.Controls.Add(BKReturn_btn)
        Cust_Panel.Controls.Add(CustSearch_btn)
        Cust_Panel.Location = New Point(2, -1)
        Cust_Panel.Name = "Cust_Panel"
        Cust_Panel.Size = New Size(1106, 30)
        Cust_Panel.TabIndex = 5
        ' 
        ' BKReturn_btn
        ' 
        BKReturn_btn.BackColor = Color.White
        BKReturn_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        CustSearch_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
        CustSearch_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        CustSearch_btn.Location = New Point(103, 4)
        CustSearch_btn.Name = "CustSearch_btn"
        CustSearch_btn.Size = New Size(115, 23)
        CustSearch_btn.TabIndex = 0
        CustSearch_btn.Text = "Search Customer"
        CustSearch_btn.UseVisualStyleBackColor = False
        ' 
        ' BKSearch_btn
        ' 
        BKSearch_btn.BackColor = Color.White
        BKSearch_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        BKIssue_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        AddBK_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
        AddBK_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        AddBK_btn.Location = New Point(12, 4)
        AddBK_btn.Name = "AddBK_btn"
        AddBK_btn.Size = New Size(75, 23)
        AddBK_btn.TabIndex = 3
        AddBK_btn.Text = "Add Book"
        AddBK_btn.UseVisualStyleBackColor = False
        ' 
        ' Reg_panel
        ' 
        Reg_panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Reg_panel.Controls.Add(Admin_btn)
        Reg_panel.Location = New Point(0, 31)
        Reg_panel.Name = "Reg_panel"
        Reg_panel.Size = New Size(1106, 30)
        Reg_panel.TabIndex = 3
        ' 
        ' Admin_btn
        ' 
        Admin_btn.BackColor = Color.White
        Admin_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
        Admin_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Admin_btn.Location = New Point(12, 4)
        Admin_btn.Name = "Admin_btn"
        Admin_btn.Size = New Size(75, 23)
        Admin_btn.TabIndex = 4
        Admin_btn.Text = "Admin"
        Admin_btn.UseVisualStyleBackColor = False
        ' 
        ' Admin_Panel
        ' 
        Admin_Panel.BackgroundImage = My.Resources.Resources.Reg_Panel_Admin
        Admin_Panel.BackgroundImageLayout = ImageLayout.Stretch
        Admin_Panel.Controls.Add(BkIssue_panel)
        Admin_Panel.Controls.Add(Add_BK_Panel)
        Admin_Panel.Controls.Add(Admin_Pass_TBX)
        Admin_Panel.Controls.Add(Admin_CPass_TBX)
        Admin_Panel.Controls.Add(Admin_UName_TBX)
        Admin_Panel.Controls.Add(Admin_Add_TBX)
        Admin_Panel.Controls.Add(Admin_Phone_TBX)
        Admin_Panel.Controls.Add(Admin_Lname_TBX)
        Admin_Panel.Controls.Add(Admin_Fname_TBX)
        Admin_Panel.Controls.Add(Admin_Cancel_btn)
        Admin_Panel.Controls.Add(Admin_Reset_btn)
        Admin_Panel.Controls.Add(Admin_Submit_btn)
        Admin_Panel.Controls.Add(Admin_login_showPass_chkbx)
        Admin_Panel.Location = New Point(0, 56)
        Admin_Panel.Name = "Admin_Panel"
        Admin_Panel.Size = New Size(1108, 642)
        Admin_Panel.TabIndex = 1
        ' 
        ' BkIssue_panel
        ' 
        BkIssue_panel.Controls.Add(BkSearch_Panel)
        BkIssue_panel.Location = New Point(0, 597)
        BkIssue_panel.Name = "BkIssue_panel"
        BkIssue_panel.Size = New Size(616, 40)
        BkIssue_panel.TabIndex = 0
        ' 
        ' BkSearch_Panel
        ' 
        BkSearch_Panel.Controls.Add(SearchCustomer_Panel)
        BkSearch_Panel.Location = New Point(0, 591)
        BkSearch_Panel.Name = "BkSearch_Panel"
        BkSearch_Panel.Size = New Size(773, 35)
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
        ' Add_BK_Panel
        ' 
        Add_BK_Panel.BackgroundImage = My.Resources.Resources.Add_Books
        Add_BK_Panel.BackgroundImageLayout = ImageLayout.Stretch
        Add_BK_Panel.Controls.Add(AddBK_Close_btn)
        Add_BK_Panel.Controls.Add(AddBK_Submit_btn)
        Add_BK_Panel.Controls.Add(AddBK_DateTimePicker)
        Add_BK_Panel.Controls.Add(AddBK_PubName_TBX)
        Add_BK_Panel.Controls.Add(AddBK_Qnt_TBX)
        Add_BK_Panel.Controls.Add(AddBK_Authname_TBX)
        Add_BK_Panel.Controls.Add(AddBK_BKID_TBX)
        Add_BK_Panel.Controls.Add(AddBK_BKName_TBX)
        Add_BK_Panel.Dock = DockStyle.Fill
        Add_BK_Panel.Location = New Point(0, 0)
        Add_BK_Panel.Name = "Add_BK_Panel"
        Add_BK_Panel.Size = New Size(1108, 642)
        Add_BK_Panel.TabIndex = 14
        ' 
        ' AddBK_Close_btn
        ' 
        AddBK_Close_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddBK_Close_btn.ForeColor = Color.Indigo
        AddBK_Close_btn.Location = New Point(458, 498)
        AddBK_Close_btn.Name = "AddBK_Close_btn"
        AddBK_Close_btn.Size = New Size(115, 35)
        AddBK_Close_btn.TabIndex = 7
        AddBK_Close_btn.Text = "Close"
        AddBK_Close_btn.UseVisualStyleBackColor = True
        ' 
        ' AddBK_Submit_btn
        ' 
        AddBK_Submit_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddBK_Submit_btn.ForeColor = Color.Indigo
        AddBK_Submit_btn.Location = New Point(215, 498)
        AddBK_Submit_btn.Name = "AddBK_Submit_btn"
        AddBK_Submit_btn.Size = New Size(115, 35)
        AddBK_Submit_btn.TabIndex = 6
        AddBK_Submit_btn.Text = "Submit"
        AddBK_Submit_btn.UseVisualStyleBackColor = True
        ' 
        ' AddBK_DateTimePicker
        ' 
        AddBK_DateTimePicker.CalendarForeColor = Color.White
        AddBK_DateTimePicker.CalendarMonthBackground = Color.MidnightBlue
        AddBK_DateTimePicker.Format = DateTimePickerFormat.Short
        AddBK_DateTimePicker.Location = New Point(150, 283)
        AddBK_DateTimePicker.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        AddBK_DateTimePicker.Name = "AddBK_DateTimePicker"
        AddBK_DateTimePicker.Size = New Size(213, 23)
        AddBK_DateTimePicker.TabIndex = 5
        ' 
        ' AddBK_PubName_TBX
        ' 
        AddBK_PubName_TBX.BackColor = Color.MidnightBlue
        AddBK_PubName_TBX.BorderStyle = BorderStyle.None
        AddBK_PubName_TBX.Font = New Font("Segoe UI", 9.0F)
        AddBK_PubName_TBX.ForeColor = Color.White
        AddBK_PubName_TBX.Location = New Point(260, 335)
        AddBK_PubName_TBX.Name = "AddBK_PubName_TBX"
        AddBK_PubName_TBX.PlaceholderText = "e.x.  Oracle"
        AddBK_PubName_TBX.Size = New Size(182, 16)
        AddBK_PubName_TBX.TabIndex = 4
        ' 
        ' AddBK_Qnt_TBX
        ' 
        AddBK_Qnt_TBX.BackColor = Color.MidnightBlue
        AddBK_Qnt_TBX.BorderStyle = BorderStyle.None
        AddBK_Qnt_TBX.Font = New Font("Segoe UI", 9.0F)
        AddBK_Qnt_TBX.ForeColor = Color.White
        AddBK_Qnt_TBX.Location = New Point(534, 254)
        AddBK_Qnt_TBX.Name = "AddBK_Qnt_TBX"
        AddBK_Qnt_TBX.PlaceholderText = "e.x. 10"
        AddBK_Qnt_TBX.Size = New Size(171, 16)
        AddBK_Qnt_TBX.TabIndex = 3
        ' 
        ' AddBK_Authname_TBX
        ' 
        AddBK_Authname_TBX.BackColor = Color.MidnightBlue
        AddBK_Authname_TBX.BorderStyle = BorderStyle.None
        AddBK_Authname_TBX.Font = New Font("Segoe UI", 9.0F)
        AddBK_Authname_TBX.ForeColor = Color.White
        AddBK_Authname_TBX.Location = New Point(237, 252)
        AddBK_Authname_TBX.Name = "AddBK_Authname_TBX"
        AddBK_Authname_TBX.PlaceholderText = "e.x.  Herbert Schildt"
        AddBK_Authname_TBX.Size = New Size(179, 16)
        AddBK_Authname_TBX.TabIndex = 2
        ' 
        ' AddBK_BKID_TBX
        ' 
        AddBK_BKID_TBX.BackColor = Color.MidnightBlue
        AddBK_BKID_TBX.BorderStyle = BorderStyle.None
        AddBK_BKID_TBX.Font = New Font("Segoe UI", 9.0F)
        AddBK_BKID_TBX.ForeColor = Color.White
        AddBK_BKID_TBX.Location = New Point(522, 207)
        AddBK_BKID_TBX.Name = "AddBK_BKID_TBX"
        AddBK_BKID_TBX.PlaceholderText = "e.x.  #1"
        AddBK_BKID_TBX.Size = New Size(178, 16)
        AddBK_BKID_TBX.TabIndex = 1
        ' 
        ' AddBK_BKName_TBX
        ' 
        AddBK_BKName_TBX.BackColor = Color.MidnightBlue
        AddBK_BKName_TBX.BorderStyle = BorderStyle.None
        AddBK_BKName_TBX.Font = New Font("Segoe UI", 9.0F)
        AddBK_BKName_TBX.ForeColor = Color.White
        AddBK_BKName_TBX.Location = New Point(211, 208)
        AddBK_BKName_TBX.Name = "AddBK_BKName_TBX"
        AddBK_BKName_TBX.PlaceholderText = "e.x. Java"
        AddBK_BKName_TBX.Size = New Size(176, 16)
        AddBK_BKName_TBX.TabIndex = 0
        ' 
        ' Admin_Pass_TBX
        ' 
        Admin_Pass_TBX.BackColor = Color.MidnightBlue
        Admin_Pass_TBX.BorderStyle = BorderStyle.None
        Admin_Pass_TBX.Font = New Font("Book Antiqua", 9.75F)
        Admin_Pass_TBX.ForeColor = Color.White
        Admin_Pass_TBX.Location = New Point(193, 370)
        Admin_Pass_TBX.Name = "Admin_Pass_TBX"
        Admin_Pass_TBX.PasswordChar = "*"c
        Admin_Pass_TBX.Size = New Size(178, 17)
        Admin_Pass_TBX.TabIndex = 7
        ' 
        ' Admin_CPass_TBX
        ' 
        Admin_CPass_TBX.BackColor = Color.MidnightBlue
        Admin_CPass_TBX.BorderStyle = BorderStyle.None
        Admin_CPass_TBX.Font = New Font("Book Antiqua", 9.75F)
        Admin_CPass_TBX.ForeColor = Color.White
        Admin_CPass_TBX.Location = New Point(595, 370)
        Admin_CPass_TBX.Name = "Admin_CPass_TBX"
        Admin_CPass_TBX.PasswordChar = "*"c
        Admin_CPass_TBX.Size = New Size(178, 17)
        Admin_CPass_TBX.TabIndex = 6
        ' 
        ' Admin_UName_TBX
        ' 
        Admin_UName_TBX.BackColor = Color.MidnightBlue
        Admin_UName_TBX.BorderStyle = BorderStyle.None
        Admin_UName_TBX.Font = New Font("Book Antiqua", 9.75F)
        Admin_UName_TBX.ForeColor = Color.White
        Admin_UName_TBX.Location = New Point(207, 330)
        Admin_UName_TBX.Name = "Admin_UName_TBX"
        Admin_UName_TBX.Size = New Size(178, 17)
        Admin_UName_TBX.TabIndex = 5
        ' 
        ' Admin_Add_TBX
        ' 
        Admin_Add_TBX.BackColor = Color.MidnightBlue
        Admin_Add_TBX.BorderStyle = BorderStyle.None
        Admin_Add_TBX.Font = New Font("Book Antiqua", 9.75F)
        Admin_Add_TBX.ForeColor = Color.White
        Admin_Add_TBX.Location = New Point(180, 284)
        Admin_Add_TBX.Name = "Admin_Add_TBX"
        Admin_Add_TBX.Size = New Size(350, 17)
        Admin_Add_TBX.TabIndex = 4
        ' 
        ' Admin_Phone_TBX
        ' 
        Admin_Phone_TBX.BackColor = Color.MidnightBlue
        Admin_Phone_TBX.BorderStyle = BorderStyle.None
        Admin_Phone_TBX.Font = New Font("Book Antiqua", 9.75F)
        Admin_Phone_TBX.ForeColor = Color.White
        Admin_Phone_TBX.Location = New Point(206, 249)
        Admin_Phone_TBX.Name = "Admin_Phone_TBX"
        Admin_Phone_TBX.PlaceholderText = "+91"
        Admin_Phone_TBX.Size = New Size(178, 17)
        Admin_Phone_TBX.TabIndex = 3
        ' 
        ' Admin_Lname_TBX
        ' 
        Admin_Lname_TBX.BackColor = Color.MidnightBlue
        Admin_Lname_TBX.BorderStyle = BorderStyle.None
        Admin_Lname_TBX.Font = New Font("Book Antiqua", 9.75F)
        Admin_Lname_TBX.ForeColor = Color.White
        Admin_Lname_TBX.Location = New Point(517, 205)
        Admin_Lname_TBX.Name = "Admin_Lname_TBX"
        Admin_Lname_TBX.PlaceholderText = "e.x. Das"
        Admin_Lname_TBX.Size = New Size(181, 17)
        Admin_Lname_TBX.TabIndex = 2
        ' 
        ' Admin_Fname_TBX
        ' 
        Admin_Fname_TBX.BackColor = Color.MidnightBlue
        Admin_Fname_TBX.BorderStyle = BorderStyle.None
        Admin_Fname_TBX.ForeColor = Color.White
        Admin_Fname_TBX.Location = New Point(207, 205)
        Admin_Fname_TBX.Name = "Admin_Fname_TBX"
        Admin_Fname_TBX.PlaceholderText = "e.x. Abir"
        Admin_Fname_TBX.Size = New Size(178, 16)
        Admin_Fname_TBX.TabIndex = 1
        ' 
        ' Admin_Cancel_btn
        ' 
        Admin_Cancel_btn.BackColor = Color.White
        Admin_Cancel_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold)
        Admin_Cancel_btn.ForeColor = Color.Indigo
        Admin_Cancel_btn.Location = New Point(588, 498)
        Admin_Cancel_btn.Name = "Admin_Cancel_btn"
        Admin_Cancel_btn.Size = New Size(115, 35)
        Admin_Cancel_btn.TabIndex = 13
        Admin_Cancel_btn.Text = "Close"
        Admin_Cancel_btn.UseVisualStyleBackColor = False
        ' 
        ' Admin_Reset_btn
        ' 
        Admin_Reset_btn.BackColor = Color.White
        Admin_Reset_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold)
        Admin_Reset_btn.ForeColor = Color.Indigo
        Admin_Reset_btn.Location = New Point(356, 498)
        Admin_Reset_btn.Name = "Admin_Reset_btn"
        Admin_Reset_btn.Size = New Size(115, 35)
        Admin_Reset_btn.TabIndex = 10
        Admin_Reset_btn.Text = "Reset"
        Admin_Reset_btn.UseVisualStyleBackColor = False
        ' 
        ' Admin_Submit_btn
        ' 
        Admin_Submit_btn.BackColor = Color.White
        Admin_Submit_btn.BackgroundImageLayout = ImageLayout.Stretch
        Admin_Submit_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Admin_Submit_btn.ForeColor = Color.Indigo
        Admin_Submit_btn.Location = New Point(126, 498)
        Admin_Submit_btn.Name = "Admin_Submit_btn"
        Admin_Submit_btn.Size = New Size(115, 35)
        Admin_Submit_btn.TabIndex = 9
        Admin_Submit_btn.Text = "Submit"
        Admin_Submit_btn.UseVisualStyleBackColor = False
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
        ' Menu
        ' 
        Menu.BackColor = Color.Indigo
        Menu.Controls.Add(Dash_LogOut_btn)
        Menu.Controls.Add(Label2)
        Menu.Controls.Add(Label1)
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
        ' Dash_LogOut_btn
        ' 
        Dash_LogOut_btn.Font = New Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Dash_LogOut_btn.ForeColor = Color.Indigo
        Dash_LogOut_btn.Location = New Point(898, 2)
        Dash_LogOut_btn.Name = "Dash_LogOut_btn"
        Dash_LogOut_btn.Size = New Size(64, 26)
        Dash_LogOut_btn.TabIndex = 10
        Dash_LogOut_btn.Text = "Log Out"
        Dash_LogOut_btn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(686, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 17)
        Label2.TabIndex = 9
        Label2.Text = "Logged in as"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(778, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 17)
        Label1.TabIndex = 8
        ' 
        ' Help_btn
        ' 
        Help_btn.BackColor = Color.White
        Help_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        Usr_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        Cust_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        BK_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        Reg_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
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
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
        Book_Panel.ResumeLayout(False)
        Cust_Panel.ResumeLayout(False)
        Reg_panel.ResumeLayout(False)
        Admin_Panel.ResumeLayout(False)
        Admin_Panel.PerformLayout()
        BkIssue_panel.ResumeLayout(False)
        BkSearch_Panel.ResumeLayout(False)
        SearchCustomer_Panel.ResumeLayout(False)
        CurrentProfile_Panel.ResumeLayout(False)
        AllUsers_Panel.ResumeLayout(False)
        Credits_Panel.ResumeLayout(False)
        Add_BK_Panel.ResumeLayout(False)
        Add_BK_Panel.PerformLayout()
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents icon_img As PictureBox
    Friend WithEvents Close_img As PictureBox
    Friend WithEvents Main_panel As Panel
    Friend WithEvents Menu As Panel
    Friend WithEvents Admin_Panel As Panel
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
    Friend WithEvents Admin_btn As Button
    Friend WithEvents Book_Panel As Panel
    Friend WithEvents Cust_Panel As Panel
    Friend WithEvents User_Panel As Panel
    Friend WithEvents Admin_Reset_btn As Button
    Friend WithEvents Admin_Submit_btn As Button
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
    Friend WithEvents Admin_Pass_TBX As TextBox
    Friend WithEvents Admin_CPass_TBX As TextBox
    Friend WithEvents Admin_UName_TBX As TextBox
    Friend WithEvents Admin_Add_TBX As TextBox
    Friend WithEvents Admin_Phone_TBX As TextBox
    Friend WithEvents Admin_Lname_TBX As TextBox
    Friend WithEvents Admin_Fname_TBX As TextBox
    Friend WithEvents Admin_login_showPass_chkbx As CheckBox
    Friend WithEvents Admin_Cancel_btn As Button
    Friend WithEvents Add_BK_Panel As Panel
    Friend WithEvents AddBK_BKName_TBX As TextBox
    Friend WithEvents AddBK_Qnt_TBX As TextBox
    Friend WithEvents AddBK_Authname_TBX As TextBox
    Friend WithEvents AddBK_BKID_TBX As TextBox
    Friend WithEvents AddBK_PubName_TBX As TextBox
    Friend WithEvents AddBK_DateTimePicker As DateTimePicker
    Friend WithEvents AddBK_Submit_btn As Button
    Friend WithEvents AddBK_Close_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dash_LogOut_btn As Button
End Class
