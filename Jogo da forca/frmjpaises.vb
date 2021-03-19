Public Class frmjpaises

    Dim Palavra As String
    Dim Tamanhodapalavra As Integer
    Dim letra As String
    Dim LetrasCorretas As Integer
    Dim LetrasIncorretas As Integer
    Dim palavrasf(9) As String
    Dim palavrasd(9) As String

    Sub palavras()
        palavrasf(0) = "PORTUGAL"
        palavrasf(1) = "CHINA"
        palavrasf(2) = "ESPANHA"
        palavrasf(3) = "ALEMANHA"
        palavrasf(4) = "BRASIL"
        palavrasf(5) = "JAPAO"
        palavrasf(6) = "ITALIA"
        palavrasf(7) = "PERU"
        palavrasf(8) = "CANADA"
        palavrasf(9) = "GRECIA"

        palavrasd(0) = "NEPAL"
        palavrasd(1) = "MAURITANIA"
        palavrasd(2) = "TURCOMENISTAO"
        palavrasd(3) = "FILIPINAS"
        palavrasd(4) = "AFEGANISTAO"
        palavrasd(5) = "ARGENTINA"
        palavrasd(6) = "CHIPRE"
        palavrasd(7) = "MADASGARCAR"
        palavrasd(8) = "SENEGAL"
        palavrasd(9) = "LITUANIA"


        If My.Settings.dificuldade = 1 Then
            Palavra = palavrasf(Int(Rnd() * 10))
        ElseIf My.Settings.dificuldade = 2 Then
            Palavra = palavrasd(Int(Rnd() * 10))
        End If




    End Sub

    Sub DesabilitaLabels()
        Dim lbls As Control
        For Each lbls In groupPalavra.Controls
            If TypeOf lbls Is Label Then
                lbls.Visible = False
            End If
        Next
    End Sub

    Sub SearchWord()
        Dim searching As Integer = 1
        For searching = 1 To Len(Palavra)
            If Mid(Palavra, searching, Len(letra)) = letra Then
                MinhaLabel(searching - 1).Text = letra
                LetrasCorretas += 1
            End If
        Next
        If Not Palavra.Contains(letra) Then
            My.Computer.Audio.Play(My.Resources.bruh, AudioPlayMode.Background)
            LetrasIncorretas += 1
            lblNumeroErros.Text = 6 - LetrasIncorretas
        End If

        getimage()

        If LetrasIncorretas = 6 Then Perdejogo()

        If LetrasCorretas = Len(Palavra) Then
            Fimdejogo()
        End If




    End Sub

    Sub getimage()

        If LetrasIncorretas = 0 Then
            PictureBox1.Image = My.Resources.Forca_0
        ElseIf LetrasIncorretas = 1 Then
            PictureBox1.Image = My.Resources.Forca_1
        ElseIf LetrasIncorretas = 2 Then
            PictureBox1.Image = My.Resources.forca_2
        ElseIf LetrasIncorretas = 3 Then
            PictureBox1.Image = My.Resources.Forca_3
        ElseIf LetrasIncorretas = 4 Then
            PictureBox1.Image = My.Resources.Forca_4
        ElseIf LetrasIncorretas = 5 Then
            PictureBox1.Image = My.Resources.Forca_5
        ElseIf LetrasIncorretas = 6 Then
            PictureBox1.Image = My.Resources.forca_6
        End If


    End Sub

    Sub Desabilitabotoes()
        Dim ctrl As Control
        For Each ctrl In groupbotoes.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = False
            End If
        Next
    End Sub

    Sub Fimdejogo()
        My.Computer.Audio.Play(My.Resources.acertou, AudioPlayMode.Background)
        MsgBox("GANHASTEEEEEEEEE")
        For i As Integer = 0 To Tamanhodapalavra - 1
            MinhaLabel(i).Text = ""
        Next
        PictureBox1.Image = My.Resources.Forca_0
        lblNumeroErros.Text = ""
        LetrasIncorretas = 0
        Desabilitabotoes()
        DesabilitaLabels()
        Me.Hide()
        frmmenu.Show()

    End Sub

    Sub Perdejogo()
        My.Computer.Audio.Play(My.Resources.FNAF, AudioPlayMode.Background)
        MsgBox("Assassino!!!!,A palavra era: " & Palavra)
        For i As Integer = 0 To Tamanhodapalavra - 1
            MinhaLabel(i).Text = ""
        Next
        Desabilitabotoes()
        DesabilitaLabels()
        PictureBox1.Image = My.Resources.Forca_0
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        LetrasIncorretas = 0
        LetrasCorretas = 0

        palavras()

        Palavra = UCase(Palavra)
        Palavra = Palavra.Replace(" ", "")
        LetrasCorretas = 0
        LetrasIncorretas = 0
        Tamanhodapalavra = Len(Palavra)

        DesabilitaLabels()

        For i As Integer = 0 To Tamanhodapalavra - 1
            MinhaLabel(i).Visible = True
        Next

        Dim ctrl As Control
        For Each ctrl In groupbotoes.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = True
            End If
        Next
        lblNumeroErros.Text = "6"
    End Sub

    Private Sub ButtonClicks(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonA.Click, ButtonB.Click, ButtonC.Click, ButtonD.Click, ButtonE.Click,
            ButtonF.Click, ButtonG.Click, ButtonH.Click, ButtonI.Click, ButtonJ.Click, ButtonK.Click, ButtonL.Click, ButtonM.Click, ButtonN.Click, ButtonO.Click, ButtonP.Click,
            ButtonQ.Click, ButtonR.Click, ButtonS.Click, ButtonT.Click, ButtonU.Click, ButtonV.Click, ButtonW.Click, ButtonX.Click, ButtonY.Click, ButtonZ.Click

        Dim strText As String = DirectCast(sender, Button).Text
        Select Case strText
            Case "A"
                ButtonA.Visible = False
            Case "B"
                ButtonB.Visible = False
            Case "C"
                ButtonC.Visible = False
            Case "D"
                ButtonD.Visible = False
            Case "E"
                ButtonE.Visible = False
            Case "F"
                ButtonF.Visible = False
            Case "G"
                ButtonG.Visible = False
            Case "H"
                ButtonH.Visible = False
            Case "I"
                ButtonI.Visible = False
            Case "J"
                ButtonJ.Visible = False
            Case "K"
                ButtonK.Visible = False
            Case "L"
                ButtonL.Visible = False
            Case "M"
                ButtonM.Visible = False
            Case "N"
                ButtonN.Visible = False
            Case "O"
                ButtonO.Visible = False
            Case "P"
                ButtonP.Visible = False
            Case "Q"
                ButtonQ.Visible = False
            Case "R"
                ButtonR.Visible = False
            Case "S"
                ButtonS.Visible = False
            Case "T"
                ButtonT.Visible = False
            Case "U"
                ButtonU.Visible = False
            Case "V"
                ButtonV.Visible = False
            Case "W"
                ButtonW.Visible = False
            Case "X"
                ButtonX.Visible = False
            Case "Y"
                ButtonY.Visible = False
            Case "Z"
                ButtonZ.Visible = False
        End Select
        letra = strText
        SearchWord()
    End Sub

    Private Sub frmjpaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        PictureBox1.Image = My.Resources.Forca_0
        DesabilitaLabels()
        Desabilitabotoes()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmmenu.Show()

    End Sub

End Class

