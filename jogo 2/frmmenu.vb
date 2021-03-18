Public Class frmmenu
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btjogar.Click
        Me.Hide()
        frmjogo.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblnome.Click

    End Sub

    Private Sub frmmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnome.Text = My.Settings.Username
        lblnome.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
    End Sub
End Class