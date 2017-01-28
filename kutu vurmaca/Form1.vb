Public Class Form1

    'Korh@n GeRi�  prestige2005


#Region "global de�i�kenler"
    'label �n ka�ar ka�ar ilerleyece�ini belirliyorum
    Dim gidis_x As Integer = -1
    Dim gidis_y As Integer = -1

    'ka� tane label olaca��n� s�yl�yorum
    Dim yeni(,) As Label

    's�tun say�lar� ve sat�r say�lar� i�in
    Dim sutun As Integer = 5
    Dim sat�r As Integer = 5

    'h�z� ayarla ,,, timer�n interval �na 
    Dim h�z As Integer = 10

    'isim giri�i yap�l�yor
    Dim isim As String = "esin"

    'ilk resimden ba�lan�lmas� sa�lan�yor
    Dim image_index As Integer = 0

    'vurulan kutular bitti mi diye saya� tutuluyor 
    Dim sayac As Integer = 0

#End Region

#Region "prosed�rler"

    '      1. ad�mda �ncelikle labellar olu�turuluyor bunun
    'i�in bir label dizisi kullan�lacak bunun i�in picturebox ta
    'tercih edilebilirdi

    Private Sub labellari_olustur()
        'kutular �iziliyor

        Dim i, j As Integer
        sayac = 0
        Me.Text = isim + " oynuyor"
        timer1.Enabled = True
        timer1.Interval = h�z
        label1.SetBounds(0, 370, 15, 20)
        Me.KeyPreview = True
        Me.Width = (40 * sutun) + 8
        button1.Width = (10 * sutun) + 13
        ReDim yeni(sat�r, sutun)
        Dim x_kordinat� As Integer = 0
        Dim y_kordinat� As Integer = 20
        For i = 0 To sat�r - 1
            For j = 0 To sutun - 1
                '�nce bi tane label olu�turuluyor
                Dim olustur As New Label()
                'sonra bu label diziye aktar�l�yor
                yeni(i, j) = olustur
                'sonra dizi eleman�da forma ekleniyor
                Me.Controls.Add(yeni(i, j))
                'imagelistten s�rayla imageler al�n�yor.
                yeni(i, j).Image = �mageList1.Images(image_index)
                yeni(i, j).BackColor = Color.DarkBlue
                label1.BackColor = Color.RoyalBlue
                Me.BackColor = Color.RoyalBlue
                'koyulacak olan elemanlar�n koordinat ve �evre bilgileri
                'ile setbounds metodu kullan�larak formda yerle�tiriliyor
                yeni(i, j).SetBounds(x_kordinat�, y_kordinat�, 40, 40)
                x_kordinat� += 40
                If (x_kordinat� = sutun * 40) Then
                    'kutular�n yan yana olmas� i�in
                    x_kordinat� = 0
                    'bi alt sat�ra ge� ve dewam et koymaya
                    y_kordinat� += 40
                End If
                'her defas�nda farkl� bi resim almak i�in artt�r�l�yor
                image_index += 1
                If (image_index = 9) Then
                    'son resime gelince ilk resime geri d�n�l�yor
                    image_index = 0
                End If
            Next

        Next

    End Sub

    '2. ad�mda hareket eden topun yukar�da bulunan kutulara de�ip de�medi�ine
    'bak�l�yor ve de�erse kutularyok ediliyor.. kutu say�s� bitmi� ise bu sayac
    'yard�m� ile takip ediliyor oyun bitmi� oluyor..

    Private Function kutular�_vur() As Boolean

        'matris elemanlar�n� kontrol edebilmek i�in 2 for kullanmam gerekti
        Dim i, j As Integer
        For i = 0 To sat�r - 1

            For j = 0 To sutun - 1

                If ((label1.Left > yeni(i, j).Left) And (label1.Left < yeni(i, j).Left + yeni(i, j).Width)) Then
                    'top kutu koordinatlar�n ge�ti mi diye bakarken
                    'hem geni�li�ine hemde y�ksekli�ine bakmam gerekiyor
                    If ((label1.Top >= yeni(i, j).Top) And (label1.Top < yeni(i, j).Top + yeni(i, j).Height)) Then

                        If (yeni(i, j).Text <> "1") Then

                            'kutular bittimi diye bakmak i�in
                            Dim kutu_sayisi As Integer = sat�r * sutun
                            'vurulan kutunun text de�erini 1 yap
                            yeni(i, j).Text = "1"
                            yeni(i, j).Visible = False
                            sayac += 1
                            If (kutu_sayisi = sayac) Then
                                timer1.Enabled = False
                                MessageBox.Show("oyunu kazand�n", "BRAVO")

                                menuStrip1.Enabled = True
                                sayac = 0
                            End If
                            'kutu koordinatlar�ndan ge�tiyse i�lemden ��k
                            Return True
                        End If
                    End If
                End If
            Next
        Next

        Return False

    End Function

    Private Sub temizle()
        'oyun bitince kutular� temizle
        Dim i, j As Integer
        For i = 0 To sat�r - 1
            For j = 0 To sutun - 1
                yeni(i, j).Dispose()
            Next
        Next

    End Sub

#End Region

#Region "eventler"
    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'a�a��daki tahtam�z�(buton) hareketi i�in kullan�yorum
        If (e.KeyCode = Keys.Left) Then
            'e�er bas�lan tu� sol hareket tu�u ise
            button1.Left -= 20

        ElseIf (e.KeyCode = Keys.Right) Then
            'e�er bas�lan tu� sa� hareket tu�u ise
            button1.Left += 20
        End If
    End Sub

    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        label1.Left += gidis_x
        label1.Top += gidis_y
        If (label1.Left > Me.Width - label1.Width) Then
            'sa� kenera gelince ��kma
            gidis_x = -gidis_x

        ElseIf (label1.Left < 0) Then
            'sol kenera gelince durma
            gidis_x = -gidis_x

        ElseIf ((label1.Left > button1.Left) And (label1.Left < button1.Left + button1.Width)) Then
            'butonun koordinatlar�nda ise geri d�n
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

        If (kutular�_vur()) Then
            gidis_y = -gidis_y
        End If

    End Sub

    Private Sub isimgiri�iToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles isimgiri�iToolStripMenuItem.Click
        'isim giri�i
        Try
            isim = InputBox("isminizi giriniz", "isim giri�i", "ES�N", 100, 100)
        Catch
        End Try
    End Sub

    Private Sub ba�latToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ba�latToolStripMenuItem.Click
        'oyunu ba�latmak i�in
        labellari_olustur()
        menuStrip1.Enabled = False
    End Sub

    Private Sub toolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolStripTextBox1.TextChanged
        'sat�r say�s�n� belirle
        Try

            sat�r = Convert.ToInt32(toolStripTextBox1.Text)

        Catch
        End Try
    End Sub

    Private Sub toolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolStripTextBox2.TextChanged
        's�tun say�s�n� belirle
        Try

            sutun = Convert.ToInt32(toolStripTextBox2.Text)
        Catch
        End Try
    End Sub

    Private Sub h�zayar�ToolStripMenuItem_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles h�zayar�ToolStripMenuItem.TextChanged
        'topun h�z�n� ayarlamak i�in
        Try

            Dim deger As String = h�zayar�ToolStripMenuItem.Text
            h�z = 10
            Select Case (deger)
                Case "level1"
                    h�z = 10

                Case "level2"
                    h�z = 9

                Case "level3"
                    h�z = 7

                Case "level4"
                    h�z = 5

                Case "level5"
                    h�z = 3
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
