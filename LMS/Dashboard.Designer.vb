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
        CustSearch_btn = New Button()
        BKReturn_btn = New Button()
        Book_Panel = New Panel()
        BKSearch_btn = New Button()
        BKIssue_btn = New Button()
        AddBK_btn = New Button()
        Reg_panel = New Panel()
        Admin_btn = New Button()
        Admin_Panel = New Panel()
        BkIssue_panel = New Panel()
        BkSearch_Panel = New Panel()
        BkReturn_Panel = New Panel()
        SearchCustomer_Panel = New Panel()
        CurrentProfile_Panel = New Panel()
        AllUsers_Panel = New Panel()
        Credits_Panel = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        DataGridView3 = New DataGridView()
        CurrentProfile_CPass_TBX = New TextBox()
        CurrentProfile_Pass_TBX = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        CurrentProfile_Close_btn = New Button()
        SearchCust_Search_btn = New Button()
        SearchCust_CustPhone_TBX = New TextBox()
        SearchCust_CustName_TBX = New TextBox()
        DataGridView2 = New DataGridView()
        ReturnBK_Close_btn = New Button()
        ReturnBK_Return_btn = New Button()
        ReturnBK_Search_btn = New Button()
        Panel1 = New Panel()
        ReturnBK_ReturnDate_TBX = New TextBox()
        ReturnBK_IssueDate_TBX = New TextBox()
        ReturnBK_BKID_TBX = New TextBox()
        ReturnBK_BKName_TBX = New TextBox()
        ReturnBK_CustName_TBX = New TextBox()
        ReturnBK_Phone_TBX = New TextBox()
        BKSearch_Close_btn = New Button()
        BKSearch_Search_btn = New Button()
        BKSearch_BKID_TBX = New TextBox()
        BKSearch_BKName_TBX = New TextBox()
        DataGridView1 = New DataGridView()
        BKIssue_Close_btn = New Button()
        BKIssue_Reset_btn = New Button()
        BKIssue_Issue_btn = New Button()
        BKIssue_ReturnBKDate_TBX = New DateTimePicker()
        BKIssue_IssueDate_TBX = New DateTimePicker()
        BKIssue_Phone_TBX = New TextBox()
        BKIssue_CustName_TBX = New TextBox()
        BKIssue_BKID_TBX = New TextBox()
        BKIssu_BKName_TBX = New TextBox()
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
        Cust_Panel.SuspendLayout()
        Book_Panel.SuspendLayout()
        Reg_panel.SuspendLayout()
        Admin_Panel.SuspendLayout()
        BkIssue_panel.SuspendLayout()
        BkSearch_Panel.SuspendLayout()
        BkReturn_Panel.SuspendLayout()
        SearchCustomer_Panel.SuspendLayout()
        CurrentProfile_Panel.SuspendLayout()
        AllUsers_Panel.SuspendLayout()
        Credits_Panel.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Main_panel.Controls.Add(Cust_Panel)
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
        Help_Panel.Location = New Point(0, 30)
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
        User_Panel.Location = New Point(1, 29)
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
        ' Cust_Panel
        ' 
        Cust_Panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Cust_Panel.Controls.Add(CustSearch_btn)
        Cust_Panel.Controls.Add(BKReturn_btn)
        Cust_Panel.Location = New Point(1, 29)
        Cust_Panel.Name = "Cust_Panel"
        Cust_Panel.Size = New Size(1106, 31)
        Cust_Panel.TabIndex = 8
        ' 
        ' CustSearch_btn
        ' 
        CustSearch_btn.BackColor = Color.White
        CustSearch_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
        CustSearch_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        CustSearch_btn.Location = New Point(112, 3)
        CustSearch_btn.Name = "CustSearch_btn"
        CustSearch_btn.Size = New Size(75, 23)
        CustSearch_btn.TabIndex = 1
        CustSearch_btn.Text = "Search Customer"
        CustSearch_btn.UseVisualStyleBackColor = False
        ' 
        ' BKReturn_btn
        ' 
        BKReturn_btn.BackColor = Color.White
        BKReturn_btn.Font = New Font("Book Antiqua", 9.0F, FontStyle.Bold)
        BKReturn_btn.ForeColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        BKReturn_btn.Location = New Point(11, 3)
        BKReturn_btn.Name = "BKReturn_btn"
        BKReturn_btn.Size = New Size(92, 23)
        BKReturn_btn.TabIndex = 0
        BKReturn_btn.Text = "Return Books"
        BKReturn_btn.UseVisualStyleBackColor = False
        ' 
        ' Book_Panel
        ' 
        Book_Panel.BackColor = Color.FromArgb(CByte(91), CByte(2), CByte(156))
        Book_Panel.Controls.Add(BKSearch_btn)
        Book_Panel.Controls.Add(BKIssue_btn)
        Book_Panel.Controls.Add(AddBK_btn)
        Book_Panel.Location = New Point(0, 30)
        Book_Panel.Name = "Book_Panel"
        Book_Panel.Size = New Size(1106, 30)
        Book_Panel.TabIndex = 4
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
        Admin_Panel.Location = New Point(0, 61)
        Admin_Panel.Name = "Admin_Panel"
        Admin_Panel.Size = New Size(1107, 637)
        Admin_Panel.TabIndex = 1
        ' 
        ' BkIssue_panel
        ' 
        BkIssue_panel.BackgroundImage = My.Resources.Resources.Issue_Book
        BkIssue_panel.BackgroundImageLayout = ImageLayout.Stretch
        BkIssue_panel.Controls.Add(BkSearch_Panel)
        BkIssue_panel.Controls.Add(BKIssue_Close_btn)
        BkIssue_panel.Controls.Add(BKIssue_Reset_btn)
        BkIssue_panel.Controls.Add(BKIssue_Issue_btn)
        BkIssue_panel.Controls.Add(BKIssue_ReturnBKDate_TBX)
        BkIssue_panel.Controls.Add(BKIssue_IssueDate_TBX)
        BkIssue_panel.Controls.Add(BKIssue_Phone_TBX)
        BkIssue_panel.Controls.Add(BKIssue_CustName_TBX)
        BkIssue_panel.Controls.Add(BKIssue_BKID_TBX)
        BkIssue_panel.Controls.Add(BKIssu_BKName_TBX)
        BkIssue_panel.Dock = DockStyle.Fill
        BkIssue_panel.Location = New Point(0, 0)
        BkIssue_panel.Name = "BkIssue_panel"
        BkIssue_panel.Size = New Size(1107, 637)
        BkIssue_panel.TabIndex = 0
        ' 
        ' BkSearch_Panel
        ' 
        BkSearch_Panel.BackgroundImage = My.Resources.Resources.Search_Book
        BkSearch_Panel.BackgroundImageLayout = ImageLayout.Stretch
        BkSearch_Panel.Controls.Add(BkReturn_Panel)
        BkSearch_Panel.Controls.Add(BKSearch_Close_btn)
        BkSearch_Panel.Controls.Add(BKSearch_Search_btn)
        BkSearch_Panel.Controls.Add(BKSearch_BKID_TBX)
        BkSearch_Panel.Controls.Add(BKSearch_BKName_TBX)
        BkSearch_Panel.Controls.Add(DataGridView1)
        BkSearch_Panel.Dock = DockStyle.Fill
        BkSearch_Panel.Location = New Point(0, 0)
        BkSearch_Panel.Name = "BkSearch_Panel"
        BkSearch_Panel.Size = New Size(1107, 637)
        BkSearch_Panel.TabIndex = 0
        ' 
        ' BkReturn_Panel
        ' 
        BkReturn_Panel.BackgroundImage = My.Resources.Resources.Return_Book
        BkReturn_Panel.BackgroundImageLayout = ImageLayout.Stretch
        BkReturn_Panel.Controls.Add(SearchCustomer_Panel)
        BkReturn_Panel.Controls.Add(ReturnBK_Close_btn)
        BkReturn_Panel.Controls.Add(ReturnBK_Return_btn)
        BkReturn_Panel.Controls.Add(ReturnBK_Search_btn)
        BkReturn_Panel.Controls.Add(Panel1)
        BkReturn_Panel.Controls.Add(ReturnBK_ReturnDate_TBX)
        BkReturn_Panel.Controls.Add(ReturnBK_IssueDate_TBX)
        BkReturn_Panel.Controls.Add(ReturnBK_BKID_TBX)
        BkReturn_Panel.Controls.Add(ReturnBK_BKName_TBX)
        BkReturn_Panel.Controls.Add(ReturnBK_CustName_TBX)
        BkReturn_Panel.Controls.Add(ReturnBK_Phone_TBX)
        BkReturn_Panel.Dock = DockStyle.Fill
        BkReturn_Panel.Location = New Point(0, 0)
        BkReturn_Panel.Name = "BkReturn_Panel"
        BkReturn_Panel.Size = New Size(1107, 637)
        BkReturn_Panel.TabIndex = 0
        ' 
        ' SearchCustomer_Panel
        ' 
        SearchCustomer_Panel.BackgroundImage = My.Resources.Resources.Search_Customer
        SearchCustomer_Panel.BackgroundImageLayout = ImageLayout.Stretch
        SearchCustomer_Panel.Controls.Add(CurrentProfile_Panel)
        SearchCustomer_Panel.Controls.Add(SearchCust_Search_btn)
        SearchCustomer_Panel.Controls.Add(SearchCust_CustPhone_TBX)
        SearchCustomer_Panel.Controls.Add(SearchCust_CustName_TBX)
        SearchCustomer_Panel.Controls.Add(DataGridView2)
        SearchCustomer_Panel.Dock = DockStyle.Fill
        SearchCustomer_Panel.Location = New Point(0, 0)
        SearchCustomer_Panel.Name = "SearchCustomer_Panel"
        SearchCustomer_Panel.Size = New Size(1107, 637)
        SearchCustomer_Panel.TabIndex = 0
        ' 
        ' CurrentProfile_Panel
        ' 
        CurrentProfile_Panel.BackgroundImage = My.Resources.Resources.Current_Profile
        CurrentProfile_Panel.BackgroundImageLayout = ImageLayout.Stretch
        CurrentProfile_Panel.Controls.Add(AllUsers_Panel)
        CurrentProfile_Panel.Controls.Add(CurrentProfile_CPass_TBX)
        CurrentProfile_Panel.Controls.Add(CurrentProfile_Pass_TBX)
        CurrentProfile_Panel.Controls.Add(Button1)
        CurrentProfile_Panel.Controls.Add(Label7)
        CurrentProfile_Panel.Controls.Add(Label6)
        CurrentProfile_Panel.Controls.Add(Label5)
        CurrentProfile_Panel.Controls.Add(Label4)
        CurrentProfile_Panel.Controls.Add(Label3)
        CurrentProfile_Panel.Controls.Add(CurrentProfile_Close_btn)
        CurrentProfile_Panel.Dock = DockStyle.Fill
        CurrentProfile_Panel.Location = New Point(0, 0)
        CurrentProfile_Panel.Name = "CurrentProfile_Panel"
        CurrentProfile_Panel.Size = New Size(1107, 637)
        CurrentProfile_Panel.TabIndex = 0
        ' 
        ' AllUsers_Panel
        ' 
        AllUsers_Panel.BackgroundImage = My.Resources.Resources.All_Users
        AllUsers_Panel.BackgroundImageLayout = ImageLayout.Stretch
        AllUsers_Panel.Controls.Add(Credits_Panel)
        AllUsers_Panel.Controls.Add(Button2)
        AllUsers_Panel.Controls.Add(DataGridView3)
        AllUsers_Panel.Dock = DockStyle.Fill
        AllUsers_Panel.Location = New Point(0, 0)
        AllUsers_Panel.Name = "AllUsers_Panel"
        AllUsers_Panel.Size = New Size(1107, 637)
        AllUsers_Panel.TabIndex = 0
        ' 
        ' Credits_Panel
        ' 
        Credits_Panel.BackgroundImage = My.Resources.Resources.Credits
        Credits_Panel.BackgroundImageLayout = ImageLayout.Stretch
        Credits_Panel.Controls.Add(Button3)
        Credits_Panel.Dock = DockStyle.Fill
        Credits_Panel.Location = New Point(0, 0)
        Credits_Panel.Name = "Credits_Panel"
        Credits_Panel.Size = New Size(1107, 637)
        Credits_Panel.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Indigo
        Button3.Location = New Point(458, 570)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 35)
        Button3.TabIndex = 3
        Button3.Text = "Close"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Indigo
        Button2.Location = New Point(505, 589)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 35)
        Button2.TabIndex = 2
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView3.BackgroundColor = Color.MidnightBlue
        DataGridView3.BorderStyle = BorderStyle.None
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(15, 134)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(1079, 445)
        DataGridView3.TabIndex = 1
        ' 
        ' CurrentProfile_CPass_TBX
        ' 
        CurrentProfile_CPass_TBX.BackColor = Color.MidnightBlue
        CurrentProfile_CPass_TBX.BorderStyle = BorderStyle.None
        CurrentProfile_CPass_TBX.ForeColor = Color.White
        CurrentProfile_CPass_TBX.Location = New Point(598, 370)
        CurrentProfile_CPass_TBX.Name = "CurrentProfile_CPass_TBX"
        CurrentProfile_CPass_TBX.Size = New Size(175, 16)
        CurrentProfile_CPass_TBX.TabIndex = 11
        ' 
        ' CurrentProfile_Pass_TBX
        ' 
        CurrentProfile_Pass_TBX.BackColor = Color.MidnightBlue
        CurrentProfile_Pass_TBX.BorderStyle = BorderStyle.None
        CurrentProfile_Pass_TBX.ForeColor = Color.White
        CurrentProfile_Pass_TBX.Location = New Point(196, 371)
        CurrentProfile_Pass_TBX.Name = "CurrentProfile_Pass_TBX"
        CurrentProfile_Pass_TBX.Size = New Size(175, 16)
        CurrentProfile_Pass_TBX.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Indigo
        Button1.Location = New Point(157, 508)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 35)
        Button1.TabIndex = 9
        Button1.Text = "Update Password"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MidnightBlue
        Label7.ForeColor = Color.White
        Label7.Location = New Point(207, 331)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 6
        Label7.Text = "Label7"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MidnightBlue
        Label6.ForeColor = Color.White
        Label6.Location = New Point(179, 287)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 5
        Label6.Text = "Label6"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MidnightBlue
        Label5.ForeColor = Color.White
        Label5.Location = New Point(205, 251)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 4
        Label5.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MidnightBlue
        Label4.ForeColor = Color.White
        Label4.Location = New Point(518, 207)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MidnightBlue
        Label3.ForeColor = Color.White
        Label3.Location = New Point(207, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' CurrentProfile_Close_btn
        ' 
        CurrentProfile_Close_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CurrentProfile_Close_btn.ForeColor = Color.Indigo
        CurrentProfile_Close_btn.Location = New Point(534, 508)
        CurrentProfile_Close_btn.Name = "CurrentProfile_Close_btn"
        CurrentProfile_Close_btn.Size = New Size(115, 35)
        CurrentProfile_Close_btn.TabIndex = 1
        CurrentProfile_Close_btn.Text = "Close"
        CurrentProfile_Close_btn.UseVisualStyleBackColor = True
        ' 
        ' SearchCust_Search_btn
        ' 
        SearchCust_Search_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SearchCust_Search_btn.ForeColor = Color.Indigo
        SearchCust_Search_btn.Location = New Point(558, 202)
        SearchCust_Search_btn.Name = "SearchCust_Search_btn"
        SearchCust_Search_btn.Size = New Size(115, 35)
        SearchCust_Search_btn.TabIndex = 4
        SearchCust_Search_btn.Text = "Search"
        SearchCust_Search_btn.UseVisualStyleBackColor = True
        ' 
        ' SearchCust_CustPhone_TBX
        ' 
        SearchCust_CustPhone_TBX.BackColor = Color.MidnightBlue
        SearchCust_CustPhone_TBX.BorderStyle = BorderStyle.None
        SearchCust_CustPhone_TBX.ForeColor = Color.White
        SearchCust_CustPhone_TBX.Location = New Point(236, 214)
        SearchCust_CustPhone_TBX.Name = "SearchCust_CustPhone_TBX"
        SearchCust_CustPhone_TBX.Size = New Size(180, 16)
        SearchCust_CustPhone_TBX.TabIndex = 3
        ' 
        ' SearchCust_CustName_TBX
        ' 
        SearchCust_CustName_TBX.BackColor = Color.MidnightBlue
        SearchCust_CustName_TBX.BorderStyle = BorderStyle.None
        SearchCust_CustName_TBX.ForeColor = Color.White
        SearchCust_CustName_TBX.Location = New Point(290, 150)
        SearchCust_CustName_TBX.Name = "SearchCust_CustName_TBX"
        SearchCust_CustName_TBX.Size = New Size(178, 16)
        SearchCust_CustName_TBX.TabIndex = 2
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = Color.MidnightBlue
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(15, 307)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(1077, 298)
        DataGridView2.TabIndex = 1
        ' 
        ' ReturnBK_Close_btn
        ' 
        ReturnBK_Close_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBK_Close_btn.ForeColor = Color.Indigo
        ReturnBK_Close_btn.Location = New Point(590, 498)
        ReturnBK_Close_btn.Name = "ReturnBK_Close_btn"
        ReturnBK_Close_btn.Size = New Size(115, 35)
        ReturnBK_Close_btn.TabIndex = 10
        ReturnBK_Close_btn.Text = "Close"
        ReturnBK_Close_btn.UseVisualStyleBackColor = True
        ' 
        ' ReturnBK_Return_btn
        ' 
        ReturnBK_Return_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBK_Return_btn.ForeColor = Color.Indigo
        ReturnBK_Return_btn.Location = New Point(364, 498)
        ReturnBK_Return_btn.Name = "ReturnBK_Return_btn"
        ReturnBK_Return_btn.Size = New Size(115, 35)
        ReturnBK_Return_btn.TabIndex = 9
        ReturnBK_Return_btn.Text = "Return"
        ReturnBK_Return_btn.UseVisualStyleBackColor = True
        ' 
        ' ReturnBK_Search_btn
        ' 
        ReturnBK_Search_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnBK_Search_btn.ForeColor = Color.Indigo
        ReturnBK_Search_btn.Location = New Point(126, 498)
        ReturnBK_Search_btn.Name = "ReturnBK_Search_btn"
        ReturnBK_Search_btn.Size = New Size(115, 35)
        ReturnBK_Search_btn.TabIndex = 8
        ReturnBK_Search_btn.Text = "Search"
        ReturnBK_Search_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Location = New Point(78, 372)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(411, 27)
        Panel1.TabIndex = 7
        ' 
        ' ReturnBK_ReturnDate_TBX
        ' 
        ReturnBK_ReturnDate_TBX.BackColor = Color.MidnightBlue
        ReturnBK_ReturnDate_TBX.BorderStyle = BorderStyle.None
        ReturnBK_ReturnDate_TBX.ForeColor = Color.White
        ReturnBK_ReturnDate_TBX.Location = New Point(247, 331)
        ReturnBK_ReturnDate_TBX.Name = "ReturnBK_ReturnDate_TBX"
        ReturnBK_ReturnDate_TBX.Size = New Size(178, 16)
        ReturnBK_ReturnDate_TBX.TabIndex = 6
        ' 
        ' ReturnBK_IssueDate_TBX
        ' 
        ReturnBK_IssueDate_TBX.BackColor = Color.MidnightBlue
        ReturnBK_IssueDate_TBX.BorderStyle = BorderStyle.None
        ReturnBK_IssueDate_TBX.ForeColor = Color.White
        ReturnBK_IssueDate_TBX.Location = New Point(231, 286)
        ReturnBK_IssueDate_TBX.Name = "ReturnBK_IssueDate_TBX"
        ReturnBK_IssueDate_TBX.Size = New Size(211, 16)
        ReturnBK_IssueDate_TBX.TabIndex = 5
        ' 
        ' ReturnBK_BKID_TBX
        ' 
        ReturnBK_BKID_TBX.BackColor = Color.MidnightBlue
        ReturnBK_BKID_TBX.BorderStyle = BorderStyle.None
        ReturnBK_BKID_TBX.ForeColor = Color.White
        ReturnBK_BKID_TBX.Location = New Point(495, 237)
        ReturnBK_BKID_TBX.Name = "ReturnBK_BKID_TBX"
        ReturnBK_BKID_TBX.PlaceholderText = "Mandatory for Search"
        ReturnBK_BKID_TBX.Size = New Size(178, 16)
        ReturnBK_BKID_TBX.TabIndex = 4
        ' 
        ' ReturnBK_BKName_TBX
        ' 
        ReturnBK_BKName_TBX.BackColor = Color.MidnightBlue
        ReturnBK_BKName_TBX.BorderStyle = BorderStyle.None
        ReturnBK_BKName_TBX.ForeColor = Color.White
        ReturnBK_BKName_TBX.Location = New Point(214, 237)
        ReturnBK_BKName_TBX.Name = "ReturnBK_BKName_TBX"
        ReturnBK_BKName_TBX.Size = New Size(179, 16)
        ReturnBK_BKName_TBX.TabIndex = 3
        ' 
        ' ReturnBK_CustName_TBX
        ' 
        ReturnBK_CustName_TBX.BackColor = Color.MidnightBlue
        ReturnBK_CustName_TBX.BorderStyle = BorderStyle.None
        ReturnBK_CustName_TBX.ForeColor = Color.White
        ReturnBK_CustName_TBX.Location = New Point(261, 200)
        ReturnBK_CustName_TBX.Name = "ReturnBK_CustName_TBX"
        ReturnBK_CustName_TBX.Size = New Size(177, 16)
        ReturnBK_CustName_TBX.TabIndex = 2
        ' 
        ' ReturnBK_Phone_TBX
        ' 
        ReturnBK_Phone_TBX.BackColor = Color.MidnightBlue
        ReturnBK_Phone_TBX.BorderStyle = BorderStyle.None
        ReturnBK_Phone_TBX.ForeColor = Color.White
        ReturnBK_Phone_TBX.Location = New Point(206, 163)
        ReturnBK_Phone_TBX.Name = "ReturnBK_Phone_TBX"
        ReturnBK_Phone_TBX.PlaceholderText = "Mandatory for Search"
        ReturnBK_Phone_TBX.Size = New Size(177, 16)
        ReturnBK_Phone_TBX.TabIndex = 1
        ' 
        ' BKSearch_Close_btn
        ' 
        BKSearch_Close_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BKSearch_Close_btn.ForeColor = Color.Indigo
        BKSearch_Close_btn.Location = New Point(522, 204)
        BKSearch_Close_btn.Name = "BKSearch_Close_btn"
        BKSearch_Close_btn.Size = New Size(115, 35)
        BKSearch_Close_btn.TabIndex = 5
        BKSearch_Close_btn.Text = "Close"
        BKSearch_Close_btn.UseVisualStyleBackColor = True
        ' 
        ' BKSearch_Search_btn
        ' 
        BKSearch_Search_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BKSearch_Search_btn.ForeColor = Color.Indigo
        BKSearch_Search_btn.Location = New Point(522, 152)
        BKSearch_Search_btn.Name = "BKSearch_Search_btn"
        BKSearch_Search_btn.Size = New Size(115, 35)
        BKSearch_Search_btn.TabIndex = 3
        BKSearch_Search_btn.Text = "Search"
        BKSearch_Search_btn.UseVisualStyleBackColor = True
        ' 
        ' BKSearch_BKID_TBX
        ' 
        BKSearch_BKID_TBX.BackColor = Color.MidnightBlue
        BKSearch_BKID_TBX.BorderStyle = BorderStyle.None
        BKSearch_BKID_TBX.ForeColor = Color.White
        BKSearch_BKID_TBX.Location = New Point(217, 216)
        BKSearch_BKID_TBX.Name = "BKSearch_BKID_TBX"
        BKSearch_BKID_TBX.PlaceholderText = "e.x. #1"
        BKSearch_BKID_TBX.Size = New Size(181, 16)
        BKSearch_BKID_TBX.TabIndex = 2
        ' 
        ' BKSearch_BKName_TBX
        ' 
        BKSearch_BKName_TBX.BackColor = Color.MidnightBlue
        BKSearch_BKName_TBX.BorderStyle = BorderStyle.None
        BKSearch_BKName_TBX.ForeColor = Color.White
        BKSearch_BKName_TBX.Location = New Point(248, 152)
        BKSearch_BKName_TBX.Name = "BKSearch_BKName_TBX"
        BKSearch_BKName_TBX.PlaceholderText = "e.x. Java"
        BKSearch_BKName_TBX.Size = New Size(181, 16)
        BKSearch_BKName_TBX.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.MidnightBlue
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.Cyan
        DataGridView1.Location = New Point(15, 293)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.Size = New Size(1077, 330)
        DataGridView1.TabIndex = 4
        ' 
        ' BKIssue_Close_btn
        ' 
        BKIssue_Close_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold)
        BKIssue_Close_btn.ForeColor = Color.Indigo
        BKIssue_Close_btn.Location = New Point(505, 498)
        BKIssue_Close_btn.Name = "BKIssue_Close_btn"
        BKIssue_Close_btn.Size = New Size(115, 35)
        BKIssue_Close_btn.TabIndex = 9
        BKIssue_Close_btn.Text = "Close"
        BKIssue_Close_btn.UseVisualStyleBackColor = True
        ' 
        ' BKIssue_Reset_btn
        ' 
        BKIssue_Reset_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold)
        BKIssue_Reset_btn.ForeColor = Color.Indigo
        BKIssue_Reset_btn.Location = New Point(353, 498)
        BKIssue_Reset_btn.Name = "BKIssue_Reset_btn"
        BKIssue_Reset_btn.Size = New Size(115, 35)
        BKIssue_Reset_btn.TabIndex = 8
        BKIssue_Reset_btn.Text = "Reset"
        BKIssue_Reset_btn.UseVisualStyleBackColor = True
        ' 
        ' BKIssue_Issue_btn
        ' 
        BKIssue_Issue_btn.Font = New Font("Book Antiqua", 14.25F, FontStyle.Bold)
        BKIssue_Issue_btn.ForeColor = Color.Indigo
        BKIssue_Issue_btn.Location = New Point(205, 498)
        BKIssue_Issue_btn.Name = "BKIssue_Issue_btn"
        BKIssue_Issue_btn.Size = New Size(115, 35)
        BKIssue_Issue_btn.TabIndex = 7
        BKIssue_Issue_btn.Text = "Issue"
        BKIssue_Issue_btn.UseVisualStyleBackColor = True
        ' 
        ' BKIssue_ReturnBKDate_TBX
        ' 
        BKIssue_ReturnBKDate_TBX.Location = New Point(245, 327)
        BKIssue_ReturnBKDate_TBX.Name = "BKIssue_ReturnBKDate_TBX"
        BKIssue_ReturnBKDate_TBX.Size = New Size(180, 23)
        BKIssue_ReturnBKDate_TBX.TabIndex = 6
        ' 
        ' BKIssue_IssueDate_TBX
        ' 
        BKIssue_IssueDate_TBX.Location = New Point(228, 281)
        BKIssue_IssueDate_TBX.Name = "BKIssue_IssueDate_TBX"
        BKIssue_IssueDate_TBX.Size = New Size(214, 23)
        BKIssue_IssueDate_TBX.TabIndex = 5
        ' 
        ' BKIssue_Phone_TBX
        ' 
        BKIssue_Phone_TBX.BackColor = Color.MidnightBlue
        BKIssue_Phone_TBX.BorderStyle = BorderStyle.None
        BKIssue_Phone_TBX.ForeColor = Color.White
        BKIssue_Phone_TBX.Location = New Point(569, 254)
        BKIssue_Phone_TBX.Name = "BKIssue_Phone_TBX"
        BKIssue_Phone_TBX.Size = New Size(179, 16)
        BKIssue_Phone_TBX.TabIndex = 4
        ' 
        ' BKIssue_CustName_TBX
        ' 
        BKIssue_CustName_TBX.BackColor = Color.MidnightBlue
        BKIssue_CustName_TBX.BorderStyle = BorderStyle.None
        BKIssue_CustName_TBX.ForeColor = Color.White
        BKIssue_CustName_TBX.Location = New Point(261, 251)
        BKIssue_CustName_TBX.Name = "BKIssue_CustName_TBX"
        BKIssue_CustName_TBX.Size = New Size(179, 16)
        BKIssue_CustName_TBX.TabIndex = 3
        ' 
        ' BKIssue_BKID_TBX
        ' 
        BKIssue_BKID_TBX.BackColor = Color.MidnightBlue
        BKIssue_BKID_TBX.BorderStyle = BorderStyle.None
        BKIssue_BKID_TBX.ForeColor = Color.White
        BKIssue_BKID_TBX.Location = New Point(494, 207)
        BKIssue_BKID_TBX.Name = "BKIssue_BKID_TBX"
        BKIssue_BKID_TBX.Size = New Size(179, 16)
        BKIssue_BKID_TBX.TabIndex = 2
        ' 
        ' BKIssu_BKName_TBX
        ' 
        BKIssu_BKName_TBX.BackColor = Color.MidnightBlue
        BKIssu_BKName_TBX.BorderStyle = BorderStyle.None
        BKIssu_BKName_TBX.ForeColor = Color.White
        BKIssu_BKName_TBX.Location = New Point(214, 207)
        BKIssu_BKName_TBX.Name = "BKIssu_BKName_TBX"
        BKIssu_BKName_TBX.Size = New Size(179, 16)
        BKIssu_BKName_TBX.TabIndex = 1
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
        Add_BK_Panel.Size = New Size(1107, 637)
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
        AddBK_PubName_TBX.Location = New Point(260, 333)
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
        AddBK_Authname_TBX.Location = New Point(237, 250)
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
        AddBK_BKName_TBX.Location = New Point(211, 206)
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
        Cust_Panel.ResumeLayout(False)
        Book_Panel.ResumeLayout(False)
        Reg_panel.ResumeLayout(False)
        Admin_Panel.ResumeLayout(False)
        Admin_Panel.PerformLayout()
        BkIssue_panel.ResumeLayout(False)
        BkIssue_panel.PerformLayout()
        BkSearch_Panel.ResumeLayout(False)
        BkSearch_Panel.PerformLayout()
        BkReturn_Panel.ResumeLayout(False)
        BkReturn_Panel.PerformLayout()
        SearchCustomer_Panel.ResumeLayout(False)
        SearchCustomer_Panel.PerformLayout()
        CurrentProfile_Panel.ResumeLayout(False)
        CurrentProfile_Panel.PerformLayout()
        AllUsers_Panel.ResumeLayout(False)
        Credits_Panel.ResumeLayout(False)
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents User_Panel As Panel
    Friend WithEvents Admin_Reset_btn As Button
    Friend WithEvents Admin_Submit_btn As Button
    Friend WithEvents Profile_btn As Button
    Friend WithEvents AllUsr_btn As Button
    Friend WithEvents Help_Panel As Panel
    Friend WithEvents Creds_btn As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents AddBK_btn As Button
    Friend WithEvents BKIssue_btn As Button
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
    Friend WithEvents BKIssue_ReturnBKDate_TBX As DateTimePicker
    Friend WithEvents BKIssue_IssueDate_TBX As DateTimePicker
    Friend WithEvents BKIssue_Phone_TBX As TextBox
    Friend WithEvents BKIssue_CustName_TBX As TextBox
    Friend WithEvents BKIssue_BKID_TBX As TextBox
    Friend WithEvents BKIssu_BKName_TBX As TextBox
    Friend WithEvents BKIssue_Issue_btn As Button
    Friend WithEvents BKIssue_Close_btn As Button
    Friend WithEvents BKIssue_Reset_btn As Button
    Friend WithEvents BKSearch_BKID_TBX As TextBox
    Friend WithEvents BKSearch_BKName_TBX As TextBox
    Friend WithEvents BKSearch_Search_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BKSearch_Close_btn As Button
    Friend WithEvents Cust_Panel As Panel
    Friend WithEvents BKReturn_btn As Button
    Friend WithEvents CustSearch_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ReturnBK_ReturnDate_TBX As TextBox
    Friend WithEvents ReturnBK_IssueDate_TBX As TextBox
    Friend WithEvents ReturnBK_BKID_TBX As TextBox
    Friend WithEvents ReturnBK_BKName_TBX As TextBox
    Friend WithEvents ReturnBK_CustName_TBX As TextBox
    Friend WithEvents ReturnBK_Phone_TBX As TextBox
    Friend WithEvents ReturnBK_Search_btn As Button
    Friend WithEvents ReturnBK_Close_btn As Button
    Friend WithEvents ReturnBK_Return_btn As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SearchCust_CustPhone_TBX As TextBox
    Friend WithEvents SearchCust_CustName_TBX As TextBox
    Friend WithEvents SearchCust_Search_btn As Button
    Friend WithEvents CurrentProfile_Close_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CurrentProfile_CPass_TBX As TextBox
    Friend WithEvents CurrentProfile_Pass_TBX As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
