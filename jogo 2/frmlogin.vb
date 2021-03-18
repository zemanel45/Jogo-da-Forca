Public Class frmlogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtpassword.Text = My.Settings.Password And txtusername.Text = My.Settings.Username Then
            MsgBox("Login correto")
            Me.Hide()
            frmmenu.Show()
        Else MsgBox("Login errado")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Hide()
        frminicio.Show()
    End Sub
End Class