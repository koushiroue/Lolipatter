Public Class form1

    Private counter As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter += 1
        Label2.Text = counter
        PictureBox1.Visible = False
    End Sub
End Class
