Public Class Form1

    'Korh@n GeRiÞ  prestige2005


#Region "global deðiþkenler"
    'label ýn kaçar kaçar ilerleyeceðini belirliyorum
    Dim gidis_x As Integer = -1
    Dim gidis_y As Integer = -1

    'kaç tane label olacaðýný söylüyorum
    Dim yeni(,) As Label

    'sütun sayýlarý ve satýr sayýlarý için
    Dim sutun As Integer = 5
    Dim satýr As Integer = 5

    'hýzý ayarla ,,, timerýn interval ýna 
    Dim hýz As Integer = 10

    'isim giriþi yapýlýyor
    Dim isim As String = "esin"

    'ilk resimden baþlanýlmasý saðlanýyor
    Dim image_index As Integer = 0

    'vurulan kutular bitti mi diye sayaç tutuluyor 
    Dim sayac As Integer = 0

#End Region

#Region "prosedürler"

    '      1. adýmda öncelikle labellar oluþturuluyor bunun
    'için bir label dizisi kullanýlacak bunun için picturebox ta
    'tercih edilebilirdi

    Private Sub labellari_olustur()
        'kutular çiziliyor

        Dim i, j As Integer
        sayac = 0
        Me.Text = isim + " oynuyor"
        timer1.Enabled = True
        timer1.Interval = hýz
        label1.SetBounds(0, 370, 15, 20)
        Me.KeyPreview = True
        Me.Width = (40 * sutun) + 8
        button1.Width = (10 * sutun) + 13
        ReDim yeni(satýr, sutun)
        Dim x_kordinatý As Integer = 0
        Dim y_kordinatý As Integer = 20
        For i = 0 To satýr - 1
            For j = 0 To sutun - 1
                'önce bi tane label oluþturuluyor
                Dim olustur As New Label()
                'sonra bu label diziye aktarýlýyor
                yeni(i, j) = olustur
                'sonra dizi elemanýda forma ekleniyor
                Me.Controls.Add(yeni(i, j))
                'imagelistten sýrayla imageler alýnýyor.
                yeni(i, j).Image = ýmageList1.Images(image_index)
                yeni(i, j).BackColor = Color.DarkBlue
                label1.BackColor = Color.RoyalBlue
                Me.BackColor = Color.RoyalBlue
                'koyulacak olan elemanlarýn koordinat ve çevre bilgileri
                'ile setbounds metodu kullanýlarak formda yerleþtiriliyor
                yeni(i, j).SetBounds(x_kordinatý, y_kordinatý, 40, 40)
                x_kordinatý += 40
                If (x_kordinatý = sutun * 40) Then
                    'kutularýn yan yana olmasý için
                    x_kordinatý = 0
                    'bi alt satýra geç ve dewam et koymaya
                    y_kordinatý += 40
                End If
                'her defasýnda farklý bi resim almak için arttýrýlýyor
                image_index += 1
                If (image_index = 9) Then
                    'son resime gelince ilk resime geri dönülüyor
                    image_index = 0
                End If
            Next

        Next

    End Sub

    '2. adýmda hareket eden topun yukarýda bulunan kutulara deðip deðmediðine
    'bakýlýyor ve deðerse kutularyok ediliyor.. kutu sayýsý bitmiþ ise bu sayac
    'yardýmý ile takip ediliyor oyun bitmiþ oluyor..

    Private Function kutularý_vur() As Boolean

        'matris elemanlarýný kontrol edebilmek için 2 for kullanmam gerekti
        Dim i, j As Integer
        For i = 0 To satýr - 1

            For j = 0 To sutun - 1

                If ((label1.Left > yeni(i, j).Left) And (label1.Left < yeni(i, j).Left + yeni(i, j).Width)) Then
                    'top kutu koordinatlarýn geçti mi diye bakarken
                    'hem geniþliðine hemde yüksekliðine bakmam gerekiyor
                    If ((label1.Top >= yeni(i, j).Top) And (label1.Top < yeni(i, j).Top + yeni(i, j).Height)) Then

                        If (yeni(i, j).Text <> "1") Then

                            'kutular bittimi diye bakmak için
                            Dim kutu_sayisi As Integer = satýr * sutun
                            'vurulan kutunun text deðerini 1 yap
                            yeni(i, j).Text = "1"
                            yeni(i, j).Visible = False
                            sayac += 1
                            If (kutu_sayisi = sayac) Then
                                timer1.Enabled = False
                                MessageBox.Show("oyunu kazandýn", "BRAVO")

                                menuStrip1.Enabled = True
                                sayac = 0
                            End If
                            'kutu koordinatlarýndan geçtiyse iþlemden çýk
                            Return True
                        End If
                    End If
                End If
            Next
        Next

        Return False

    End Function

    Private Sub temizle()
        'oyun bitince kutularý temizle
        Dim i, j As Integer
        For i = 0 To satýr - 1
            For j = 0 To sutun - 1
                yeni(i, j).Dispose()
            Next
        Next

    End Sub

#End Region

#Region "eventler"
    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'aþaðýdaki tahtamýzý(buton) hareketi için kullanýyorum
        If (e.KeyCode = Keys.Left) Then
            'eðer basýlan tuþ sol hareket tuþu ise
            button1.Left -= 20

        ElseIf (e.KeyCode = Keys.Right) Then
            'eðer basýlan tuþ sað hareket tuþu ise
            button1.Left += 20
        End If
    End Sub

    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        label1.Left += gidis_x
        label1.Top += gidis_y
        If (label1.Left > Me.Width - label1.Width) Then
            'sað kenera gelince çýkma
            gidis_x = -gidis_x

        ElseIf (label1.Left < 0) Then
            'sol kenera gelince durma
            gidis_x = -gidis_x

        ElseIf ((label1.Left > button1.Left) And (label1.Left < button1.Left + button1.Width)) Then
            'butonun koordinatlarýnda ise geri dön
            If ((label1.Top >= button1.Top) And (label1.Top < button1.Top + button1.Height)) Then

                label1.Top -= 5
                gidis_y = -gidis_y
            End If
        End If

        If (label1.Top < menuStrip1.Height) Then

            label1.Top += 3
            gidis_y = -gidis_y

        ElseIf (label1.Top >= button1.Top + 50) Then

            timer1.Enabled = False
            temizle()
            Dim cevap As DialogResult
            cevap = MessageBox.Show(Me, isim + " kaybetti " & Chr(13) & "bu ayarlarla devam etmek istermisin?", "game over", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (cevap = DialogResult.Yes) Then

                gidis_x = -1
                gidis_y = -1
                labellari_olustur()

            Else

                MessageBox.Show("oyun bitti", "oyun bitti")
                menuStrip1.Enabled = True
                Return
            End If

        End If

        If (kutularý_vur()) Then
            gidis_y = -gidis_y
        End If

    End Sub

    Private Sub isimgiriþiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles isimgiriþiToolStripMenuItem.Click
        'isim giriþi
        Try
            isim = InputBox("isminizi giriniz", "isim giriþi", "ESÝN", 100, 100)
        Catch
        End Try
    End Sub

    Private Sub baþlatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baþlatToolStripMenuItem.Click
        'oyunu baþlatmak için
        labellari_olustur()
        menuStrip1.Enabled = False
    End Sub

    Private Sub toolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolStripTextBox1.TextChanged
        'satýr sayýsýný belirle
        Try

            satýr = Convert.ToInt32(toolStripTextBox1.Text)

        Catch
        End Try
    End Sub

    Private Sub toolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolStripTextBox2.TextChanged
        'sütun sayýsýný belirle
        Try

            sutun = Convert.ToInt32(toolStripTextBox2.Text)
        Catch
        End Try
    End Sub

    Private Sub hýzayarýToolStripMenuItem_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hýzayarýToolStripMenuItem.TextChanged
        'topun hýzýný ayarlamak için
        Try

            Dim deger As String = hýzayarýToolStripMenuItem.Text
            hýz = 10
            Select Case (deger)
                Case "level1"
                    hýz = 10

                Case "level2"
                    hýz = 9

                Case "level3"
                    hýz = 7

                Case "level4"
                    hýz = 5

                Case "level5"
                    hýz = 3
            End Select
        Catch
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        label1.BringToFront()
        Me.Refresh()
    End Sub
#End Region

End Class
