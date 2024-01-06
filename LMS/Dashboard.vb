Imports System.Configuration
Imports System.Data.OleDb
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions


Public Class Dashboard
    Public Conn As OleDbConnection
    Public Cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dt As DataTable
    'Public dr As OleDbDataReader
    Public Result As Integer
    Dim Sql_qry As String
    Public Sub DatabaseConnect()
        '---------------- Connect Database Universally ----------------'
        Try
            Conn = New OleDbConnection
            Conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LMS_Database.mdb"
            Conn.Open()
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
        Login.Show()
        Login.Login_UName_TBX.Text = ""
        Login.Login_Pass_TBX.Text = ""

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

    Private Sub BKIssue_btn_Click(sender As Object, e As EventArgs) Handles BKIssue_btn.Click
        Admin_Panel.Show()
        Add_BK_Panel.Show()
        BkIssue_panel.Show()
        BkSearch_Panel.Hide()
        BkReturn_Panel.Hide()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub

    Private Sub BKSearch_btn_Click(sender As Object, e As EventArgs) Handles BKSearch_btn.Click
        Admin_Panel.Show()
        Add_BK_Panel.Show()
        BkIssue_panel.Show()
        BkSearch_Panel.Show()
        BkReturn_Panel.Hide()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub

    Private Sub BKReturn_btn_Click(sender As Object, e As EventArgs) Handles BKReturn_btn.Click
        Admin_Panel.Show()
        Add_BK_Panel.Show()
        BkIssue_panel.Show()
        BkSearch_Panel.Show()
        BkReturn_Panel.Show()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub
    Private Sub CustSearch_btn_Click(sender As Object, e As EventArgs) Handles CustSearch_btn.Click
        Admin_Panel.Show()
        Add_BK_Panel.Show()
        BkIssue_panel.Show()
        BkSearch_Panel.Show()
        BkReturn_Panel.Show()
        SearchCustomer_Panel.Show()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub

    Private Sub Profile_btn_Click(sender As Object, e As EventArgs) Handles Profile_btn.Click
        Admin_Panel.Show()
        Add_BK_Panel.Show()
        BkIssue_panel.Show()
        BkSearch_Panel.Show()
        BkReturn_Panel.Show()
        SearchCustomer_Panel.Show()
        CurrentProfile_Panel.Show()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()

        Try
            DatabaseConnect()
            Sql_qry = "Select * from Admin_Reg Where UName='" + Label1.Text + "'"
            Cmd = New OleDbCommand
            With Cmd
                .Connection = Conn
                .CommandText = Sql_qry
            End With
            da = New OleDbDataAdapter
            dt = New DataTable
            Try
                da.SelectCommand = Cmd
                da.Fill(dt)
                Label3.Text = dt.Rows(0).Item("FName")
                Label4.Text = dt.Rows(0).Item("LName")
                Label5.Text = dt.Rows(0).Item("Phone")
                Label6.Text = dt.Rows(0).Item("Address")
                Label7.Text = dt.Rows(0).Item("UName")
                CurrentProfile_Pass_TBX.Text = dt.Rows(0).Item("PassWord")
                CurrentProfile_CPass_TBX.Text = dt.Rows(0).Item("PassWord")
            Catch ex As Exception
                MsgBox("Records Not Found!..")
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
            da.Dispose()
        End Try
    End Sub
    Private Sub AllUsr_btn_Click(sender As Object, e As EventArgs) Handles AllUsr_btn.Click
        Admin_Panel.Show()
        Add_BK_Panel.Show()
        BkIssue_panel.Show()
        BkSearch_Panel.Show()
        BkReturn_Panel.Show()
        SearchCustomer_Panel.Show()
        CurrentProfile_Panel.Show()
        AllUsers_Panel.Show()
        Credits_Panel.Hide()
        Try
            DatabaseConnect()
            Sql_qry = "Select * from Admin_Reg"
            da = New OleDbDataAdapter(Sql_qry, Conn)
            Dim c As DataSet = New DataSet()
            da.Fill(c, "FName")
            DataGridView3.DataSource = c
            DataGridView3.DataMember = "FName"
        Catch ex As Exception
            MessageBox.Show("Records Not Found!")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Panel.Hide()
    End Sub

    Private Sub Creds_btn_Click(sender As Object, e As EventArgs) Handles Creds_btn.Click
        Admin_Panel.Show()
        Add_BK_Panel.Show()
        BkIssue_panel.Show()
        BkSearch_Panel.Show()
        BkReturn_Panel.Show()
        SearchCustomer_Panel.Show()
        CurrentProfile_Panel.Show()
        AllUsers_Panel.Show()
        Credits_Panel.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Admin_Panel.Hide()
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

    '==================================== Register Panel ===================================='

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

    '====================================================================================='



    '=============================== Book Panel ==============================='

    '----------------  ADD BOOK PANEL  ----------------'
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
    '---------------------------------------------------------

    '----------------  BOOK ISSUE PANEL  ----------------'
    Private Sub BKIssue_Issue_btn_Click(sender As Object, e As EventArgs) Handles BKIssue_Issue_btn.Click
        If (BKIssu_BKName_TBX.Text = "" Or BKIssue_BKID_TBX.Text = "" Or BKIssue_CustName_TBX.Text = "" Or BKIssue_Phone_TBX.Text = "" Or BKIssue_IssueDate_TBX.Text = "" Or BKIssue_ReturnBKDate_TBX.Text = "") Then
            MsgBox("Fill all the Details.")
        Else
            DatabaseConnect()
            Sql_qry = "Insert into Book_Issue Values(@BKName,@BKID,@CustName,@Phone,@DateofIssue,@DateofReturn)"
            Cmd = New OleDbCommand
            With Cmd
                .Connection = Conn
                .CommandText = Sql_qry
                .Parameters.Clear()
                .Parameters.AddWithValue("@BKName", BKIssu_BKName_TBX.Text)
                .Parameters.AddWithValue("@BKID", BKIssue_BKID_TBX.Text)
                .Parameters.AddWithValue("@CustName", BKIssue_CustName_TBX.Text)
                .Parameters.AddWithValue("@Phone", BKIssue_Phone_TBX.Text)
                .Parameters.AddWithValue("@DateofIssue", BKIssue_IssueDate_TBX.Text)
                .Parameters.AddWithValue("@DateofReturn", BKIssue_ReturnBKDate_TBX.Text)
                .ExecuteNonQuery()
                MessageBox.Show("Book Issued Successfully")
                BKIssu_BKName_TBX.Text = ""
                BKIssue_BKID_TBX.Text = ""
                BKIssue_CustName_TBX.Text = ""
                BKIssue_Phone_TBX.Text = ""
                BKIssue_IssueDate_TBX.Text = ""
                BKIssue_ReturnBKDate_TBX.Text = ""
            End With
        End If
    End Sub

    Private Sub BKIssue_Reset_btn_Click(sender As Object, e As EventArgs) Handles BKIssue_Reset_btn.Click
        BKIssu_BKName_TBX.Text = ""
        BKIssue_BKID_TBX.Text = ""
        BKIssue_CustName_TBX.Text = ""
        BKIssue_Phone_TBX.Text = ""
        BKIssue_IssueDate_TBX.Text = ""
        BKIssue_ReturnBKDate_TBX.Text = ""
    End Sub

    Private Sub BKIssue_Close_btn_Click(sender As Object, e As EventArgs) Handles BKIssue_Close_btn.Click
        Admin_Panel.Hide()
    End Sub
    '-----------------------------------------------------------'


    '---------------------  BOOK SEARCH  ---------------------'
    Private Sub BKSearch_Search_btn_Click(sender As Object, e As EventArgs) Handles BKSearch_Search_btn.Click
        If Not Len(Trim(BKSearch_BKName_TBX.Text)) = 0 Then
            DatabaseConnect()
            Sql_qry = "Select * from Books_Catalogue Where BKName='" + BKSearch_BKName_TBX.Text + "'"
            da = New OleDbDataAdapter(Sql_qry, Conn)
            Dim c As DataSet = New DataSet()
            da.Fill(c, "BKName")
            DataGridView1.DataSource = c
            DataGridView1.DataMember = "BKName"
            BKSearch_BKName_TBX.Text = ""
            BKSearch_BKID_TBX.Text = ""

        ElseIf Not (Len(Trim(BKSearch_BKName_TBX.Text)) = 0) And Not (Len(Trim(BKSearch_BKID_TBX.Text)) = 0) Then
            DatabaseConnect()
            Sql_qry = "Select * from Books_Catalogue Where BKName='" + BKSearch_BKName_TBX.Text + "'and BKID='" + BKSearch_BKID_TBX.Text + "'"
            da = New OleDbDataAdapter(Sql_qry, Conn)
            Dim c As DataSet = New DataSet()
            da.Fill(c, "BKName")
            DataGridView1.DataSource = c
            DataGridView1.DataMember = "BKName"
            BKSearch_BKName_TBX.Text = ""
            BKSearch_BKID_TBX.Text = ""
        Else
            MessageBox.Show("Book Not Found!..")
            BKSearch_BKName_TBX.Text = ""
            BKSearch_BKID_TBX.Text = ""
        End If
    End Sub

    Private Sub BKSearch_Close_btn_Click(sender As Object, e As EventArgs) Handles BKSearch_Close_btn.Click
        Admin_Panel.Hide()
    End Sub

    '-----------------------------------------------------------'

    '============================================================================================'



    '================================  CUSTOMER PANEL  ==================================='

    '----------------------------  Return Book - Search  ----------------------------'
    Private Sub ReturnBK_Search_btn_Click(sender As Object, e As EventArgs) Handles ReturnBK_Search_btn.Click
        If ReturnBK_Phone_TBX.Text = "" And ReturnBK_BKID_TBX.Text = "" Then
            MsgBox("Fill the Mandatory Details.")
        Else
            Try
                DatabaseConnect()
                Sql_qry = "Select * from Book_Issue Where Phone='" + ReturnBK_Phone_TBX.Text + "'And BKID ='" + ReturnBK_BKID_TBX.Text + "'"
                Cmd = New OleDbCommand
                With Cmd
                    .Connection = Conn
                    .CommandText = Sql_qry
                End With
                da = New OleDbDataAdapter
                dt = New DataTable
                Try
                    da.SelectCommand = Cmd
                    da.Fill(dt)
                    ReturnBK_Phone_TBX.Text = dt.Rows(0).Item("Phone")
                    ReturnBK_CustName_TBX.Text = dt.Rows(0).Item("CustName")
                    ReturnBK_BKName_TBX.Text = dt.Rows(0).Item("BKName")
                    ReturnBK_BKID_TBX.Text = dt.Rows(0).Item("BKID")
                    ReturnBK_IssueDate_TBX.Text = dt.Rows(0).Item("DateofIssue")
                    ReturnBK_ReturnDate_TBX.Text = dt.Rows(0).Item("DateofReturn")
                Catch ex As Exception
                    MsgBox("Records Not Found!..")
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Conn.Close()
                da.Dispose()
            End Try

        End If
    End Sub

    Private Sub ReturnBK_Return_btn_Click(sender As Object, e As EventArgs) Handles ReturnBK_Return_btn.Click
        If (ReturnBK_Phone_TBX.Text = "" Or ReturnBK_CustName_TBX.Text = "" Or ReturnBK_BKName_TBX.Text = "" Or ReturnBK_BKID_TBX.Text = "" Or ReturnBK_IssueDate_TBX.Text = "" Or ReturnBK_ReturnDate_TBX.Text = "") Then
            MsgBox("Fill all the Details.")
        Else
            DatabaseConnect()
            Sql_qry = "Delete from Book_Issue Where Phone='" + ReturnBK_Phone_TBX.Text + "'and CustName='" + ReturnBK_CustName_TBX.Text + "'and BKName='" + ReturnBK_BKName_TBX.Text + "'and BKID='" + ReturnBK_BKID_TBX.Text + "'and DateofIssue='" + ReturnBK_IssueDate_TBX.Text + "'and DateofReturn='" + ReturnBK_ReturnDate_TBX.Text + "'"
            Cmd = New OleDbCommand
            With Cmd
                .Connection = Conn
                .CommandText = Sql_qry
                .ExecuteNonQuery()
                MessageBox.Show("Book Returned Successfully")
                ReturnBK_Phone_TBX.Text = ""
                ReturnBK_CustName_TBX.Text = ""
                ReturnBK_BKName_TBX.Text = ""
                ReturnBK_BKID_TBX.Text = ""
                ReturnBK_IssueDate_TBX.Text = ""
                ReturnBK_ReturnDate_TBX.Text = ""
            End With
        End If
    End Sub
    Private Sub ReturnBK_Close_btn_Click(sender As Object, e As EventArgs) Handles ReturnBK_Close_btn.Click
        Admin_Panel.Hide()
    End Sub

    Private Sub SearchCust_Search_btn_Click(sender As Object, e As EventArgs) Handles SearchCust_Search_btn.Click
        If SearchCust_CustName_TBX.Text = "" And SearchCust_CustPhone_TBX.Text = "" Then
            MsgBox("Fill All The Details!")
        Else
            Try
                DatabaseConnect()
                Sql_qry = "Select * from Book_Issue Where CustName='" + SearchCust_CustName_TBX.Text + "'And Phone='" + SearchCust_CustPhone_TBX.Text + "'"
                da = New OleDbDataAdapter(Sql_qry, Conn)
                Dim c As DataSet = New DataSet()
                da.Fill(c, "BKName")
                DataGridView2.DataSource = c
                DataGridView2.DataMember = "BKName"
                SearchCust_CustName_TBX.Text = ""
                SearchCust_CustPhone_TBX.Text = ""
            Catch ex As Exception
                MessageBox.Show("Records Not Found!")
            End Try


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            DatabaseConnect()
            Sql_qry = "Update Admin_Reg set PassWord='" + CurrentProfile_Pass_TBX.Text + "' Where UName='" + Label1.Text + "'"
            Cmd = New OleDbCommand(Sql_qry, Conn)
            With Cmd
                .Connection = Conn
                .CommandText = Sql_qry
                Result = .ExecuteNonQuery()
                If Result = 0 Then
                    MessageBox.Show("Password Updated Successfully..")
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Something Went Wrong!..")
        End Try
    End Sub

    Private Sub CurrentProfile_Close_btn_Click(sender As Object, e As EventArgs) Handles CurrentProfile_Close_btn.Click
        Admin_Panel.Hide()
    End Sub



End Class