Imports System.Configuration
Imports System.Data.OleDb
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions


Public Class Dashboard
    Public Conn As OleDbConnection
    Public Cmd As OleDbCommand
    'Public da As OleDbDataAdapter
    'Public dt As DataTable
    'Public dr As OleDbDataReader
    Dim Sql_qry As String
    Public Sub DatabaseConnect()
        '---------------- Connect Database Universally ----------------'
        Try
            Conn = New OleDbConnection
            Conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Visual Studio Projects\LMS\College.mdb"
            Conn.Open()
            'Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------- Ribbon Menus Buttons Panels ----------------'
        Reg_panel.Hide()
        Book_Panel.Hide()
        Cust_Panel.Hide()
        User_Panel.Hide()
        Help_Panel.Hide()

        '---------------- Ribbon Menus Panels ----------------'
        Admin_Panel.Hide()
        Add_BK_Panel.Hide()
        BkIssue_panel.Hide()
        BkSearch_Panel.Hide()
        BkReturn_Panel.Hide()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub

    Private Sub Close_img_Click(sender As Object, e As EventArgs) Handles Close_img.Click
        Me.Close()
        Login.Close()
        SS.Close()
    End Sub

    Private Sub Reg_btn_Click(sender As Object, e As EventArgs) Handles Reg_btn.Click
        Reg_panel.Show()
        Book_Panel.Hide()
        Cust_Panel.Hide()
        User_Panel.Hide()
        Help_Panel.Hide()
    End Sub

    Private Sub BK_btn_Click(sender As Object, e As EventArgs) Handles BK_btn.Click
        Reg_panel.Hide()
        Book_Panel.Show()
        Cust_Panel.Hide()
        User_Panel.Hide()
        Help_Panel.Hide()
    End Sub

    Private Sub Cust_btn_Click(sender As Object, e As EventArgs) Handles Cust_btn.Click
        Reg_panel.Hide()
        Book_Panel.Hide()
        Cust_Panel.Show()
        User_Panel.Hide()
        Help_Panel.Hide()
    End Sub

    Private Sub Usr_btn_Click(sender As Object, e As EventArgs) Handles Usr_btn.Click
        Reg_panel.Hide()
        Book_Panel.Hide()
        Cust_Panel.Hide()
        User_Panel.Show()
        Help_Panel.Hide()
    End Sub
    Private Sub Help_btn_Click(sender As Object, e As EventArgs) Handles Help_btn.Click
        Reg_panel.Hide()
        Book_Panel.Hide()
        Cust_Panel.Hide()
        User_Panel.Hide()
        Help_Panel.Show()
    End Sub

    Private Sub Admin_btn_Click(sender As Object, e As EventArgs) Handles Admin_btn.Click
        Admin_Panel.Show()
        Add_BK_Panel.Hide()
        BkIssue_panel.Hide()
        BkSearch_Panel.Hide()
        BkReturn_Panel.Hide()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub

    Private Sub AddBK_btn_Click(sender As Object, e As EventArgs) Handles AddBK_btn.Click

        Admin_Panel.Show()
        Add_BK_Panel.Show()
        BkIssue_panel.Hide()
        BkSearch_Panel.Hide()
        BkReturn_Panel.Hide()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub

    Private Sub Admin_login_showPass_chkbx_CheckedChanged(sender As Object, e As EventArgs) Handles Admin_login_showPass_chkbx.CheckedChanged
        If Admin_login_showPass_chkbx.Checked = True Then
            Admin_Pass_TBX.PasswordChar = ""
            Admin_CPass_TBX.PasswordChar = ""
        Else
            Admin_Pass_TBX.PasswordChar = "*"
            Admin_CPass_TBX.PasswordChar = "*"
        End If
    End Sub



    Private Sub Admin_Submit_btn_Click(sender As Object, e As EventArgs) Handles Admin_Submit_btn.Click
        Dim Pass As String = Admin_Pass_TBX.Text
        Dim regex As New Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@$!%*?&~])([a-zA-Z0-9@$!%*?&~]{8,})$")
        Dim Match = regex.Match(Pass)

        If (Admin_Fname_TBX.Text = "" Or Admin_Lname_TBX.Text = "" Or Admin_Phone_TBX.Text = "" Or Admin_Add_TBX.Text = "" Or Admin_UName_TBX.Text = "" Or Admin_Pass_TBX.Text = "" Or Admin_CPass_TBX.Text = "") Then
            MsgBox("Fill all the Details.")
        Else

            If Not Admin_Pass_TBX.Text = Admin_CPass_TBX.Text Then
                MessageBox.Show("Password and Confirm Doesn't Match")
                Admin_Pass_TBX.Text = ""
                Admin_CPass_TBX.Text = ""
            Else
                If (Match.Success) Then
                    DatabaseConnect()
                    Sql_qry = "Insert into Admin_Reg Values(@FName,@LName,@Phone,@Address,@UName,@Password)"
                    Cmd = New OleDbCommand
                    With Cmd
                        .Connection = Conn
                        .CommandText = Sql_qry
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@FName", Admin_Fname_TBX.Text)
                        .Parameters.AddWithValue("@LName", Admin_Lname_TBX.Text)
                        .Parameters.AddWithValue("@Phone", Admin_Phone_TBX.Text)
                        .Parameters.AddWithValue("@Address", Admin_Add_TBX.Text)
                        .Parameters.AddWithValue("@UName", Admin_UName_TBX.Text)
                        .Parameters.AddWithValue("@Pass", Admin_Pass_TBX.Text)
                        .ExecuteNonQuery()
                        MessageBox.Show("Registered Successfully")
                        Admin_Fname_TBX.Text = ""
                        Admin_Lname_TBX.Text = ""
                        Admin_Phone_TBX.Text = ""
                        Admin_Add_TBX.Text = ""
                        Admin_UName_TBX.Text = ""
                        Admin_Pass_TBX.Text = ""
                        Admin_CPass_TBX.Text = ""
                    End With
                End If

            End If
        End If
    End Sub

    Private Sub Admin_Reset_btn_Click(sender As Object, e As EventArgs) Handles Admin_Reset_btn.Click
        Admin_Fname_TBX.Text = ""
        Admin_Lname_TBX.Text = ""
        Admin_Phone_TBX.Text = ""
        Admin_Add_TBX.Text = ""
        Admin_UName_TBX.Text = ""
        Admin_Pass_TBX.Text = ""
        Admin_CPass_TBX.Text = ""
    End Sub

    Private Sub Admin_Cancel_btn_Click(sender As Object, e As EventArgs) Handles Admin_Cancel_btn.Click
        Admin_Panel.Hide()
    End Sub

    Private Sub AddBK_Submit_btn_Click(sender As Object, e As EventArgs) Handles AddBK_Submit_btn.Click

        If (AddBK_BKName_TBX.Text = "" Or AddBK_BKID_TBX.Text = "" Or AddBK_Authname_TBX.Text = "" Or AddBK_Qnt_TBX.Text = "" Or AddBK_DateTimePicker.Text = "" Or AddBK_PubName_TBX.Text = "") Then
            MsgBox("Fill all the Details.")
        Else
            DatabaseConnect()
            Sql_qry = "Insert into Books_Catalogue Values(@BKName,@BKID,@AuthName,@Quantity,@Date,@PublisherName)"
            Cmd = New OleDbCommand
            With Cmd
                .Connection = Conn
                .CommandText = Sql_qry
                .Parameters.Clear()
                .Parameters.AddWithValue("@BKName", AddBK_BKName_TBX.Text)
                .Parameters.AddWithValue("@BKID", AddBK_BKID_TBX.Text)
                .Parameters.AddWithValue("@AuthName", AddBK_Authname_TBX.Text)
                .Parameters.AddWithValue("@Quantity", AddBK_Qnt_TBX.Text)
                .Parameters.AddWithValue("@Date", AddBK_DateTimePicker.Text)
                .Parameters.AddWithValue("@PublisherName", AddBK_PubName_TBX.Text)
                .ExecuteNonQuery()
                MessageBox.Show("Book Added Successfully")
                AddBK_BKName_TBX.Text = ""
                Admin_Lname_TBX.Text = ""
                AddBK_BKID_TBX.Text = ""
                AddBK_Authname_TBX.Text = ""
                AddBK_Qnt_TBX.Text = ""
                AddBK_DateTimePicker.Text = ""
                AddBK_PubName_TBX.Text = ""
            End With

        End If
    End Sub

    Private Sub AddBK_Close_btn_Click(sender As Object, e As EventArgs) Handles AddBK_Close_btn.Click
        Admin_Panel.Hide()
    End Sub

    Private Sub Dash_LogOut_btn_Click(sender As Object, e As EventArgs) Handles Dash_LogOut_btn.Click
        '---------------- Ribbon Menus Buttons Panels ----------------'
        Reg_panel.Hide()
        Book_Panel.Hide()
        Cust_Panel.Hide()
        User_Panel.Hide()
        Help_Panel.Hide()

        '---------------- Ribbon Menus Panels ----------------'
        Admin_Panel.Hide()
        Add_BK_Panel.Hide()
        BkIssue_panel.Hide()
        BkSearch_Panel.Hide()
        BkReturn_Panel.Hide()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()



        Label1.Text = ""
        Me.Hide()
        'Login.Show()
        Login.Login_UName_TBX.Text = ""
        Login.Login_Pass_TBX.Text = ""

    End Sub
End Class