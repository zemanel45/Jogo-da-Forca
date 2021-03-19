Public Class frmjfruta
    Dim palavrasf(9) As String
    Dim palavrasd(9) As String
    Dim word As String                                                             'declarar variaveis universais do form1 para possibilitar o acesso das mesma nas diferentes do form'
    Dim wordsplit() As String
    Dim comp As Integer
    Dim Index As Integer = 0
    Dim forca As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        palavrasf(0) = "p-o-r-t-u-g-a-l"
        palavrasf(1) = "c-h-i-n-a"
        palavrasf(2) = "e-s-p-a-n-h-a"
        palavrasf(3) = "a-l-e-m-a-n-h-a"
        palavrasf(4) = "b-r-a-s-i-l"
        palavrasf(5) = "j-a-p-a-o"
        palavrasf(6) = "i-t-a-l-i-a"
        palavrasf(7) = "p-e-r-u"
        palavrasf(8) = "c-a-n-a-d-a"
        palavrasf(9) = "g-r-e-c-i-a"

        palavrasd(1) = "e-s-t-a-d-o-s-u-n-i-d-o-s-d-a-a-m-e-r-i-c-a"
        palavrasd(2) = "e-m-i-r-a-d-o-s-a-r-a-b-e-s-u-n-i-d-o-s"
        palavrasd(3) = "f-i-l-i-p-i-n-a-s"
        palavrasd(4) = "a-f-e-g-a-n-i-s-t-a-o"
        palavrasd(5) = "a-r-g-e-n-t-i-n-a"
        palavrasd(6) = "c-h-i-p-r-e"
        palavrasd(7) = "m-a-d-a-g-a-s-c-a-r"
        palavrasd(8) = "s-e-n-e-g-a-l"
        palavrasd(9) = "l-i-t-u-a-n-i-a"


        If My.Settings.dificuldade = 1 Then
            word = palavrasf(Int(Rnd() * 4))                                       'randomicamente escolhe uma palavra'
            If Not My.Settings.dificuldade = 2 Then
                word = palavrasd(Int(Rnd() * 4))
            End If
        End If

        wordsplit = word.Split("-")                                                'Separa cada letra com base na separação e coloca cada letra num array'
        comp = wordsplit.Length                                                    'Vê o tamanho da palavra'

        For val As Integer = 0 To comp
            lblpalavra.Text = lblpalavra.Text & "-"
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Myletter As String
        Dim comp2 As Integer = 0


        Myletter = tbxresposta.Text                                                 'utilizador escolhe a palavra

        If Len(Myletter) = 1 Then

            If Asc(Myletter) < 65 Or Asc(Myletter) > 90 Then                        'Codigo para verificar se é uma letra minuscula' 
                If Myletter = wordsplit(Index) Then                                 'verifica se a letra que o utilizador escolheu é igual a cada letra da palavra'
                    MsgBox("acertastes")
                    comp = comp - 1                                                 'variavel dos acertos'
                    Index = Index + 1
                Else
                    forca = forca + 1                                               'variavel dos erros'
                End If
            Else
                MsgBox("Tens de usar letras minusculas")                            'mensagem de erro caso não seja letra minuscula'
            End If
        Else
            MsgBox("resposta invalida")
            Label1.Text = wordsplit(Index)
        End If
        If comp = 0 Then
            MsgBox("win")                                                           'Quando o utilixador ganha'

        ElseIf forca = 6 Then
            MsgBox("not win")                                                       'Quando utilizador perde'

        End If
    End Sub
End Class