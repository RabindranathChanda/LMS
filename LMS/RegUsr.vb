Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class RegUsr

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

    Private Sub Label7_MouseClick(sender As Object, e As MouseEventArgs) Handles Label7.MouseClick
        Me.Close()
        Login.Show()
    End Sub

    Private Sub reg_btn_Click(sender As Object, e As EventArgs) Handles reg_btn.Click
        Dim Pass As String = RegUsr_Pass_TBX.Text
        Dim regex As New Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@$!%*?&~])([a-zA-Z0-9@$!%*?&~]{8,})$")
        Dim Match = regex.Match(Pass)

        If (RegUsr_FName_TBX.Text = "" Or RegUsr_LName_TBX.Text = "" Or RegUsr_Phone_TBX.Text = "" Or RegUsr_Add_TBX.Text = "" Or RegUsr_UName_TBX.Text = "" Or RegUsr_Pass_TBX.Text = "" Or RegUsr_CPass_TBX.Text = "") Then
            MsgBox("Fill all the Details.")
        Else

            If Not RegUsr_Pass_TBX.Text = RegUsr_CPass_TBX.Text Then
                MessageBox.Show("Password and Confirm Doesn't Match")
                RegUsr_Pass_TBX.Text = ""
                RegUsr_CPass_TBX.Text = ""
            Else
                If (Match.Success) Then
                    DatabaseConnect()
                    Sql_qry = "Insert into Admin_Reg Values(@FName,@LName,@Phone,@Address,@UName,@Password)"
                    Cmd = New OleDbCommand
                    With Cmd
                        .Connection = Conn
                        .CommandText = Sql_qry
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@FName", RegUsr_FName_TBX.Text)
                        .Parameters.AddWithValue("@LName", RegUsr_LName_TBX.Text)
                        .Parameters.AddWithValue("@Phone", RegUsr_Phone_TBX.Text)
                        .Parameters.AddWithValue("@Address", RegUsr_Add_TBX.Text)
                        .Parameters.AddWithValue("@UName", RegUsr_UName_TBX.Text)
                        .Parameters.AddWithValue("@Pass", RegUsr_Pass_TBX.Text)
                        .ExecuteNonQuery()
                        MessageBox.Show("Registered Successfully, Now You Can Log In.")
                        RegUsr_FName_TBX.Text = ""
                        RegUsr_LName_TBX.Text = ""
                        RegUsr_Phone_TBX.Text = ""
                        RegUsr_Add_TBX.Text = ""
                        RegUsr_UName_TBX.Text = ""
                        RegUsr_Pass_TBX.Text = ""
                        RegUsr_CPass_TBX.Text = ""
                    End With
                End If

            End If
        End If
    End Sub

    Private Sub reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        RegUsr_FName_TBX.Text = ""
        RegUsr_LName_TBX.Text = ""
        RegUsr_Phone_TBX.Text = ""
        RegUsr_Add_TBX.Text = ""
        RegUsr_UName_TBX.Text = ""
        RegUsr_Pass_TBX.Text = ""
        RegUsr_CPass_TBX.Text = ""
    End Sub
End Class