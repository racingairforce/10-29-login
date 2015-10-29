Public Class Form1

  
    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If txtusername.Text = "login" Then
        End If
        If txtpassword.Text = "abc123" Then
            MsgBox("帳戶密碼正確")
        Else
            txtusername.BackColor = Color.MistyRose

            txtpassword.BackColor = Color.MistyRose


        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
