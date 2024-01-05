Imports System.Configuration
Imports System.Data.OleDb

Public Class Login
    'Public Conn As OleDbConnection
    'Public Cmd As OleDbCommand
    'Public da As OleDbDataAdapter
    'Public dt As DataTable
    'Public dr As OleDbDataReader
    'Dim Sql_qry As String
    'Public Sub DatabaseConnect()
    '    '---------------- Connect Database Universally ----------------'
    '    Try
    '        Conn = New OleDbConnection
    '        Conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Visual Studio Projects\LMS\College.mdb"
    '        Conn.Open()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SS.Hide()
    End Sub

    Private Sub Label5_MouseClick(sender As Object, e As MouseEventArgs) Handles Label5.MouseClick
        Me.Hide()
        RegUsr.Show()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()
        SS.Close()
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If Len(Trim(Login_UName_TBX.Text)) = 0 Then
            MessageBox.Show("Please Enter UserName", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Login_UName_TBX.Focus()
            Exit Sub
        End If
        If Len(Trim(Login_Pass_TBX.Text)) = 0 Then
            MessageBox.Show("Please Enter Password", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Login_Pass_TBX.Focus()
            Exit Sub
        End If

        Dim Con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Visual Studio Projects\LMS\College.mdb")
        Dim cmd As New OleDbCommand("select * from Admin_Reg Where UName='" + Login_UName_TBX.Text + "'and PassWord='" + Login_Pass_TBX.Text + "'", Con)
        Con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            Me.Hide()
            Dashboard.Show()
            Dashboard.Label1.Text = Login_UName_TBX.Text
        Else
            MessageBox.Show("Wrong UserName or Password. Try Again!", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Login_UName_TBX.Text = ""
            Login_Pass_TBX.Text = ""
        End If
    End Sub

    Private Sub Login_ShowPass_ChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles Login_ShowPass_ChkBx.CheckedChanged
        If Login_ShowPass_ChkBx.Checked = True Then
            Login_Pass_TBX.PasswordChar = ""
        Else
            Login_Pass_TBX.PasswordChar = "*"
        End If
    End Sub
End Class



