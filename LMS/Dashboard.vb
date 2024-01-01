Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------- Ribbon Menus Buttons Panels ----------------'
        Reg_panel.Hide()
        Book_Panel.Hide()
        Cust_Panel.Hide()
        User_Panel.Hide()
        Help_Panel.Hide()

        '---------------- Ribbon Menus Panels ----------------'
        Admin_Panel.Hide()
        Customer_Panel.Hide()
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
        Customer_Panel.Hide()
        BkIssue_panel.Hide()
        BkSearch_Panel.Hide()
        BkReturn_Panel.Hide()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub
    Private Sub Customer_btn_Click(sender As Object, e As EventArgs) Handles Customer_btn.Click
        Admin_Panel.Show()
        Customer_Panel.Show()
        BkIssue_panel.Hide()
        BkSearch_Panel.Hide()
        BkReturn_Panel.Hide()
        SearchCustomer_Panel.Hide()
        CurrentProfile_Panel.Hide()
        AllUsers_Panel.Hide()
        Credits_Panel.Hide()
    End Sub
End Class