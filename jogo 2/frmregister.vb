Public Class frmregister
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not txtusername.Text = "" Then
            If Not txtpassword.Text = "" Then
                My.Settings.Username = txtusername.Text
                My.Settings.Password = txtpassword.Text
                My.Settings.Save()
                Me.Hide()
                frmlogin.Show()
            End If
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frminicio.Show()
    End Sub

    Private Sub btback_Click_1(sender As Object, e As EventArgs) Handles btback.Click
        Me.Hide()
        frminicio.Show()
    End Sub
End Class