Imports System.Configuration
Imports System.Data.OleDb

Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Visual Studio Projects\LMS\College.mdb")


    End Sub

    Private Sub Label5_MouseClick(sender As Object, e As MouseEventArgs) Handles Label5.MouseClick
        Me.Hide()
        RegUsr.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()
        SS.Close()
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click

    End Sub
End Class



