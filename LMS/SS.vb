Public Class SS
    Dim prg As Integer = 0
    Dim a As String = "Use credits.txt to credit"
    Dim b As String = "contributors to your website"
    Dim c As String = " like open source software developers"
    Dim d As String = " who don’t get credit in your site’s text."
    Dim f As String = "Many people sharing work for free online rely"
    Dim g As String = "on credits to build reputation."
    Dim h As String = "A good reputation helps them find "
    Dim i As String = "the paying opportunities that fund their free work."
    Dim j As String = "Creater....."
    Dim k As String = "Rabindranath Chanda"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        If (ProgressBar1.Value < 10) Then
            Label1.Text = a
        ElseIf (ProgressBar1.Value < 20) Then
            Label1.Text = b
        ElseIf (ProgressBar1.Value < 30) Then
            Label1.Text = c
        ElseIf (ProgressBar1.Value < 40) Then
            Label1.Text = d
        ElseIf (ProgressBar1.Value < 50) Then
            Label1.Text = f
        ElseIf (ProgressBar1.Value < 60) Then
            Label1.Text = g
        ElseIf (ProgressBar1.Value < 70) Then
            Label1.Text = h
        ElseIf (ProgressBar1.Value < 80) Then
            Label1.Text = i
        ElseIf (ProgressBar1.Value < 90) Then
            Label1.Text = ""
            Label2.Text = k
            Label3.Text = j
        ElseIf (ProgressBar1.Value < 96) Then
            Login.Show()
        ElseIf (ProgressBar1.Value >= 98) Then
            Timer1.Enabled = False
        Else

        End If


    End Sub

End Class
