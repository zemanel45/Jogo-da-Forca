Public Class frmmenu
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbprof.CheckedChanged
        check()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btjogar.Click
        If rbfacil.Checked = True Then
            My.Settings.dificuldade = 1
        End If

        If rbdificil.Checked = True Then
            My.Settings.dificuldade = 2
        End If

        If rdpaises.Checked = True Then
            My.Settings.tema = 1
        End If
        If rbfrutas.Checked = True Then
            My.Settings.tema = 2
        End If
        If rbprof.Checked = True Then
            My.Settings.tema = 3
        End If
        If rbanimais.Checked = True Then
            My.Settings.tema = 4
        End If

        Me.Hide()
        frmjogos.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblnome.Click

    End Sub

    Sub desabilita()
        btjogar.Visible = False
    End Sub

    Sub habilita()
        btjogar.Visible = True
    End Sub

    Private Sub frmmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnome.Text = My.Settings.Username
        lblnome.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold)
        desabilita()



    End Sub

    Private Sub rdpaises_CheckedChanged(sender As Object, e As EventArgs) Handles rdpaises.CheckedChanged
        check()
    End Sub

    Private Sub rbfrutas_CheckedChanged(sender As Object, e As EventArgs) Handles rbfrutas.CheckedChanged
        check()
    End Sub

    Private Sub rbanimais_CheckedChanged(sender As Object, e As EventArgs) Handles rbanimais.CheckedChanged
        check()
    End Sub

    Private Sub rbfacil_CheckedChanged(sender As Object, e As EventArgs) Handles rbfacil.CheckedChanged
        check()
    End Sub

    Private Sub rbdificil_CheckedChanged(sender As Object, e As EventArgs) Handles rbdificil.CheckedChanged
        check()

    End Sub

    Sub check()
        If (rbanimais.Checked = True Or rbprof.Checked = True Or rbfrutas.Checked = True Or rdpaises.Checked = True) And (rbfacil.Checked = True Or rbdificil.Checked = True) Then
            btjogar.Visible = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class