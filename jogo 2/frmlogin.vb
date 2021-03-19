Public Class frmlogin
    Sub entr()
        MsgBox("Login correto")
        Me.Hide()
        frmmenu.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusername.Text = "Neves" And txtpassword.Text = "123" Or txtusername.Text = "Guerra" And txtpassword.Text = "123" Or txtusername.Text = "Johnny" And txtpassword.Text = "123" Or txtusername.Text = "Duartao" And txtpassword.Text = "123" Then
            entr()
        Else MsgBox("Login errado")
        End If
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Hide()
        frminicio.Show()
    End Sub
End Class