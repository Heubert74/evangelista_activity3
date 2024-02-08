Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        a = txtFirstnum.Text
        b = txtSecondnum.Text
        lblResult.Text = a / b



    End Sub
End Class
