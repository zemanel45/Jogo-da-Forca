Public Class frmjogo


    Dim palavras(3) As String
    Dim word As String                                                             'declarar variaveis universais do form1 para possibilitar o acesso das mesma nas diferentes do form'
    Dim wordsplit() As String
    Dim comp As Integer
    Dim Index As Integer = 0
    Dim forca As Integer = 0

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        palavras(0) = "o-l-a"
        palavras(1) = "r-i-o"
        palavras(2) = "a-r"
        palavras(3) = "d-u-v-i-d-a-v-a"



        word = "o-l-a" 'palavras(Int(Rnd() * 4))                                            'randomicamente escolhe uma palavra'
        wordsplit = word.Split("-")                                                'Separa cada letra com base na separação e coloca cada letra num array'
        comp = wordsplit.Length                                                    'Vê o tamanho da palavra'

        For val As Integer = 0 To comp
            lblpalavra.Text = lblpalavra.Text & "-"
        Next
    End Sub

    Private Sub Form4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Randomize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Myletter As String
        Dim comp2 As Integer = 0
        Dim size As New Size(256, 231)

        ImageList1.ImageSize = size

        Myletter = tbxresposta.Text                                                 'utilizador escolhe a palavra

        If Len(Myletter) = 1 Then

            If Asc(Myletter) < 65 Or Asc(Myletter) > 90 Then                        'Codigo para verificar se é uma letra minuscula' 
                If Myletter = wordsplit(Index) Then                                 'verifica se a letra que o utilizador escolheu é igual a cada letra da palavra'
                    MsgBox("acertastes")
                    comp = comp - 1                                                 'variavel dos acertos'
                    Index = Index + 1
                Else
                    forca = forca + 1                                               'variavel dos erros'
                    PictureBox1.Image = ImageList1.Images(forca)
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

    Private Sub lblpalavra_Click(sender As Object, e As EventArgs) Handles lblpalavra.Click

    End Sub

    Private Sub tbxresposta_TextChanged(sender As Object, e As EventArgs) Handles tbxresposta.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class