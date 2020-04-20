Public Class Form1
    Private counter As Integer = 0
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4.Visible = False
        Button3.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter += 1
        Label1.Text = "pat count = "
        Label2.Text = counter
        PictureBox1.Visible = False
        If counter = 1 Then
            MessageBox.Show("You patted the loli for the first time.
The loli is delighted.")
        End If
        If counter = 10 Then
            MessageBox.Show("You patted the loli 10 times.
The loli is thrilled.")
        End If
        If counter = 50 Then
            MessageBox.Show("You patted the loli 50 times.
The loli is very happy to recieve this many headpats.")
        End If
        If counter = 100 Then
            MessageBox.Show("You patted the loli 100 times.
The loli felt fulfilled with 100 headpats.

You no longer feel the need to pat the loli.")
            Label3.Text = "PS : you can also use Enter or Space key!"
        End If
        If counter = 200 Then
            PictureBox2.Visible = False
        End If
        If counter = 400 Then
            PictureBox6.Visible = False
            MessageBox.Show("You spam-patted the loli 400 times.
This message box may or may not be seen.

The loli is terrified.")
        End If
        If counter >= 550 Then
            Button1.Text = "Bash"
            Label1.Text = "Bash count ="
        End If
        If counter = 600 Then
            PictureBox3.Visible = False
            MessageBox.Show("You bashed the loli head.











The loli is unconscious.")
        End If
        If counter = 800 Then
            Me.Text = "LoliKiller v666"
            Me.Icon = New Icon(Me.GetType(), "eyee.ico")
        End If
        If counter = 1000 Then
            Button1.Visible = False
            PictureBox4.Visible = True
            MessageBox.Show("The loli resisted your foul headbashing session and now you are being ""patted"" instead.")
            Label1.Text = ""
            Label2.Text = ""
            Label3.Text = ""
            Me.ControlBox = False
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        counter += 1
        Label1.Text = "resistance is futile."
        Label2.Text = ""
        Label3.Text = counter
        If counter = 1020 Then
            Button3.Enabled = True
            Button3.Visible = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Behind you")
        Me.Close()
    End Sub
End Class
