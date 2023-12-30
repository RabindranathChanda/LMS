Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin_Panel.Hide()
        Student_Panel.Hide()
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

End Class