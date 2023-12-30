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
        Dash_img = New PictureBox()
        Close_img = New PictureBox()
        Label1 = New Label()
        Main_panel = New Panel()
        Admin_Panel = New Panel()
        Student_Panel = New Panel()
        BkIssue_panel = New Panel()
        BkSearch_Panel = New Panel()
        SearchCustomer_Panel = New Panel()
        CurrentProfile_Panel = New Panel()
        AllUsers_Panel = New Panel()
        Credits_Panel = New Panel()
        MenuStrip1 = New MenuStrip()
        Registration = New ToolStripMenuItem()
        AsAdmin = New ToolStripMenuItem()
        AsStudent = New ToolStripMenuItem()
        Books = New ToolStripMenuItem()
        BookIssue = New ToolStripMenuItem()
        BookSearch = New ToolStripMenuItem()
        BookReturn = New ToolStripMenuItem()
        Customer = New ToolStripMenuItem()
        SearchCoustomer = New ToolStripMenuItem()
        Users = New ToolStripMenuItem()
        CrntProfile = New ToolStripMenuItem()
        AllUsr = New ToolStripMenuItem()
        Help = New ToolStripMenuItem()
        Credits = New ToolStripMenuItem()
        BkReturn_Panel = New Panel()
        CType(icon_img, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dash_img, ComponentModel.ISupportInitialize).BeginInit()
        CType(Close_img, ComponentModel.ISupportInitialize).BeginInit()
        Main_panel.SuspendLayout()
        Admin_Panel.SuspendLayout()
        Student_Panel.SuspendLayout()
        BkIssue_panel.SuspendLayout()
        BkSearch_Panel.SuspendLayout()
        SearchCustomer_Panel.SuspendLayout()
        CurrentProfile_Panel.SuspendLayout()
        AllUsers_Panel.SuspendLayout()
        Credits_Panel.SuspendLayout()
        MenuStrip1.SuspendLayout()
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
        ' Dash_img
        ' 
        Dash_img.Dock = DockStyle.Fill
        Dash_img.Image = My.Resources.Resources.Dashboard
        Dash_img.Location = New Point(0, 0)
        Dash_img.Name = "Dash_img"
        Dash_img.Size = New Size(1106, 697)
        Dash_img.SizeMode = PictureBoxSizeMode.StretchImage
        Dash_img.TabIndex = 1
        Dash_img.TabStop = False
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Fuchsia
        Label1.Location = New Point(41, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 14)
        Label1.TabIndex = 3
        ' 
        ' Main_panel
        ' 
        Main_panel.BackColor = Color.White
        Main_panel.Controls.Add(Admin_Panel)
        Main_panel.Controls.Add(MenuStrip1)
        Main_panel.Location = New Point(10, 33)
        Main_panel.Name = "Main_panel"
        Main_panel.Size = New Size(1084, 650)
        Main_panel.TabIndex = 0
        ' 
        ' Admin_Panel
        ' 
        Admin_Panel.Controls.Add(Student_Panel)
        Admin_Panel.Dock = DockStyle.Fill
        Admin_Panel.Location = New Point(0, 24)
        Admin_Panel.Name = "Admin_Panel"
        Admin_Panel.Size = New Size(1084, 626)
        Admin_Panel.TabIndex = 1
        ' 
        ' Student_Panel
        ' 
        Student_Panel.Controls.Add(BkIssue_panel)
        Student_Panel.Dock = DockStyle.Fill
        Student_Panel.Location = New Point(0, 0)
        Student_Panel.Name = "Student_Panel"
        Student_Panel.Size = New Size(1084, 626)
        Student_Panel.TabIndex = 0
        ' 
        ' BkIssue_panel
        ' 
        BkIssue_panel.Controls.Add(BkSearch_Panel)
        BkIssue_panel.Dock = DockStyle.Fill
        BkIssue_panel.Location = New Point(0, 0)
        BkIssue_panel.Name = "BkIssue_panel"
        BkIssue_panel.Size = New Size(1084, 626)
        BkIssue_panel.TabIndex = 0
        ' 
        ' BkSearch_Panel
        ' 
        BkSearch_Panel.Controls.Add(SearchCustomer_Panel)
        BkSearch_Panel.Dock = DockStyle.Fill
        BkSearch_Panel.Location = New Point(0, 0)
        BkSearch_Panel.Name = "BkSearch_Panel"
        BkSearch_Panel.Size = New Size(1084, 626)
        BkSearch_Panel.TabIndex = 0
        ' 
        ' SearchCustomer_Panel
        ' 
        SearchCustomer_Panel.Controls.Add(CurrentProfile_Panel)
        SearchCustomer_Panel.Dock = DockStyle.Fill
        SearchCustomer_Panel.Location = New Point(0, 0)
        SearchCustomer_Panel.Name = "SearchCustomer_Panel"
        SearchCustomer_Panel.Size = New Size(1084, 626)
        SearchCustomer_Panel.TabIndex = 0
        ' 
        ' CurrentProfile_Panel
        ' 
        CurrentProfile_Panel.Controls.Add(AllUsers_Panel)
        CurrentProfile_Panel.Dock = DockStyle.Fill
        CurrentProfile_Panel.Location = New Point(0, 0)
        CurrentProfile_Panel.Name = "CurrentProfile_Panel"
        CurrentProfile_Panel.Size = New Size(1084, 626)
        CurrentProfile_Panel.TabIndex = 0
        ' 
        ' AllUsers_Panel
        ' 
        AllUsers_Panel.Controls.Add(Credits_Panel)
        AllUsers_Panel.Dock = DockStyle.Fill
        AllUsers_Panel.Location = New Point(0, 0)
        AllUsers_Panel.Name = "AllUsers_Panel"
        AllUsers_Panel.Size = New Size(1084, 626)
        AllUsers_Panel.TabIndex = 0
        ' 
        ' Credits_Panel
        ' 
        Credits_Panel.Controls.Add(BkReturn_Panel)
        Credits_Panel.Dock = DockStyle.Fill
        Credits_Panel.Location = New Point(0, 0)
        Credits_Panel.Name = "Credits_Panel"
        Credits_Panel.Size = New Size(1084, 626)
        Credits_Panel.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Indigo
        MenuStrip1.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {Registration, Books, Customer, Users, Help})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1084, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Registration
        ' 
        Registration.BackColor = Color.White
        Registration.DropDownItems.AddRange(New ToolStripItem() {AsAdmin, AsStudent})
        Registration.ForeColor = Color.Indigo
        Registration.Name = "Registration"
        Registration.Size = New Size(101, 20)
        Registration.Text = "Registration"
        ' 
        ' AsAdmin
        ' 
        AsAdmin.BackColor = Color.White
        AsAdmin.ForeColor = Color.Indigo
        AsAdmin.Name = "AsAdmin"
        AsAdmin.Size = New Size(234, 22)
        AsAdmin.Text = "As Admin"
        ' 
        ' AsStudent
        ' 
        AsStudent.BackColor = Color.White
        AsStudent.ForeColor = Color.Indigo
        AsStudent.Name = "AsStudent"
        AsStudent.Size = New Size(234, 22)
        AsStudent.Text = "As Student / Coustomer"
        ' 
        ' Books
        ' 
        Books.BackColor = Color.White
        Books.DropDownItems.AddRange(New ToolStripItem() {BookIssue, BookSearch, BookReturn})
        Books.ForeColor = Color.Indigo
        Books.Name = "Books"
        Books.Size = New Size(59, 20)
        Books.Text = "Books"
        ' 
        ' BookIssue
        ' 
        BookIssue.BackColor = Color.White
        BookIssue.ForeColor = Color.Indigo
        BookIssue.Name = "BookIssue"
        BookIssue.Size = New Size(180, 22)
        BookIssue.Text = "Issue"
        ' 
        ' BookSearch
        ' 
        BookSearch.BackColor = Color.White
        BookSearch.ForeColor = Color.Indigo
        BookSearch.Name = "BookSearch"
        BookSearch.Size = New Size(180, 22)
        BookSearch.Text = "Search"
        ' 
        ' BookReturn
        ' 
        BookReturn.BackColor = Color.White
        BookReturn.ForeColor = Color.Indigo
        BookReturn.Name = "BookReturn"
        BookReturn.Size = New Size(180, 22)
        BookReturn.Text = "Return"
        ' 
        ' Customer
        ' 
        Customer.BackColor = Color.White
        Customer.DropDownItems.AddRange(New ToolStripItem() {SearchCoustomer})
        Customer.ForeColor = Color.Indigo
        Customer.Name = "Customer"
        Customer.Size = New Size(83, 20)
        Customer.Text = "Customer"
        ' 
        ' SearchCoustomer
        ' 
        SearchCoustomer.BackColor = Color.White
        SearchCoustomer.ForeColor = Color.Indigo
        SearchCoustomer.Name = "SearchCoustomer"
        SearchCoustomer.Size = New Size(193, 22)
        SearchCoustomer.Text = "Search Coustomer"
        ' 
        ' Users
        ' 
        Users.BackColor = Color.White
        Users.DropDownItems.AddRange(New ToolStripItem() {CrntProfile, AllUsr})
        Users.ForeColor = Color.Indigo
        Users.Name = "Users"
        Users.Size = New Size(55, 20)
        Users.Text = "Users"
        ' 
        ' CrntProfile
        ' 
        CrntProfile.BackColor = Color.White
        CrntProfile.ForeColor = Color.Indigo
        CrntProfile.Name = "CrntProfile"
        CrntProfile.Size = New Size(180, 22)
        CrntProfile.Text = "Current Profile"
        ' 
        ' AllUsr
        ' 
        AllUsr.BackColor = Color.White
        AllUsr.ForeColor = Color.Indigo
        AllUsr.Name = "AllUsr"
        AllUsr.Size = New Size(180, 22)
        AllUsr.Text = "Show all Users"
        ' 
        ' Help
        ' 
        Help.BackColor = Color.White
        Help.DropDownItems.AddRange(New ToolStripItem() {Credits})
        Help.ForeColor = Color.Indigo
        Help.Name = "Help"
        Help.Size = New Size(49, 20)
        Help.Text = "Help"
        ' 
        ' Credits
        ' 
        Credits.BackColor = Color.White
        Credits.ForeColor = Color.Indigo
        Credits.Name = "Credits"
        Credits.Size = New Size(180, 22)
        Credits.Text = "Credits"
        ' 
        ' BkReturn_Panel
        ' 
        BkReturn_Panel.Dock = DockStyle.Fill
        BkReturn_Panel.Location = New Point(0, 0)
        BkReturn_Panel.Name = "BkReturn_Panel"
        BkReturn_Panel.Size = New Size(1084, 626)
        BkReturn_Panel.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1106, 697)
        Controls.Add(Main_panel)
        Controls.Add(Label1)
        Controls.Add(Close_img)
        Controls.Add(icon_img)
        Controls.Add(Dash_img)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        CType(icon_img, ComponentModel.ISupportInitialize).EndInit()
        CType(Dash_img, ComponentModel.ISupportInitialize).EndInit()
        CType(Close_img, ComponentModel.ISupportInitialize).EndInit()
        Main_panel.ResumeLayout(False)
        Main_panel.PerformLayout()
        Admin_Panel.ResumeLayout(False)
        Student_Panel.ResumeLayout(False)
        BkIssue_panel.ResumeLayout(False)
        BkSearch_Panel.ResumeLayout(False)
        SearchCustomer_Panel.ResumeLayout(False)
        CurrentProfile_Panel.ResumeLayout(False)
        AllUsers_Panel.ResumeLayout(False)
        Credits_Panel.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents icon_img As PictureBox
    Friend WithEvents Dash_img As PictureBox
    Friend WithEvents Close_img As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Main_panel As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Registration As ToolStripMenuItem
    Friend WithEvents Books As ToolStripMenuItem
    Friend WithEvents Customer As ToolStripMenuItem
    Friend WithEvents Users As ToolStripMenuItem
    Friend WithEvents AsAdmin As ToolStripMenuItem
    Friend WithEvents AsStudent As ToolStripMenuItem
    Friend WithEvents BookIssue As ToolStripMenuItem
    Friend WithEvents BookSearch As ToolStripMenuItem
    Friend WithEvents BookReturn As ToolStripMenuItem
    Friend WithEvents SearchCoustomer As ToolStripMenuItem
    Friend WithEvents CrntProfile As ToolStripMenuItem
    Friend WithEvents AllUsr As ToolStripMenuItem
    Friend WithEvents Help As ToolStripMenuItem
    Friend WithEvents Credits As ToolStripMenuItem
    Friend WithEvents Admin_Panel As Panel
    Friend WithEvents Student_Panel As Panel
    Friend WithEvents BkIssue_panel As Panel
    Friend WithEvents BkSearch_Panel As Panel
    Friend WithEvents SearchCustomer_Panel As Panel
    Friend WithEvents CurrentProfile_Panel As Panel
    Friend WithEvents AllUsers_Panel As Panel
    Friend WithEvents Credits_Panel As Panel
    Friend WithEvents BkReturn_Panel As Panel
End Class
