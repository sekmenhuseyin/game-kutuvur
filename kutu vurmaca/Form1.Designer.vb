<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.ýmageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.label1 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.seçeneklerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.isimgiriþiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.kutusayýsýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.sýrasayýsýnýgirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.sütünsayýsýnýgirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.hýzayarýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripComboBox3 = New System.Windows.Forms.ToolStripComboBox
        Me.yenioyunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.baþlatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer1
        '
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(68, 352)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(19, 19)
        Me.pictureBox1.TabIndex = 7
        Me.pictureBox1.TabStop = False
        Me.pictureBox1.Visible = False
        '
        'ýmageList1
        '
        Me.ýmageList1.ImageStream = CType(resources.GetObject("ýmageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ýmageList1.Images.SetKeyName(0, "")
        Me.ýmageList1.Images.SetKeyName(1, "")
        Me.ýmageList1.Images.SetKeyName(2, "")
        Me.ýmageList1.Images.SetKeyName(3, "")
        Me.ýmageList1.Images.SetKeyName(4, "")
        Me.ýmageList1.Images.SetKeyName(5, "")
        Me.ýmageList1.Images.SetKeyName(6, "")
        Me.ýmageList1.Images.SetKeyName(7, "")
        Me.ýmageList1.Images.SetKeyName(8, "kutu5.bmp")
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.SystemColors.Control
        Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
        Me.label1.Location = New System.Drawing.Point(12, 368)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(19, 17)
        Me.label1.TabIndex = 5
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Location = New System.Drawing.Point(40, 411)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(103, 11)
        Me.button1.TabIndex = 4
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.seçeneklerToolStripMenuItem, Me.yenioyunToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(406, 24)
        Me.menuStrip1.TabIndex = 6
        Me.menuStrip1.TabStop = True
        Me.menuStrip1.Tag = "5"
        Me.menuStrip1.Text = "menuStrip1"
        '
        'seçeneklerToolStripMenuItem
        '
        Me.seçeneklerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.isimgiriþiToolStripMenuItem, Me.kutusayýsýToolStripMenuItem, Me.hýzayarýToolStripMenuItem})
        Me.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem"
        Me.seçeneklerToolStripMenuItem.Text = "seçenekler"
        '
        'isimgiriþiToolStripMenuItem
        '
        Me.isimgiriþiToolStripMenuItem.Name = "isimgiriþiToolStripMenuItem"
        Me.isimgiriþiToolStripMenuItem.Text = "isim giriþi"
        '
        'kutusayýsýToolStripMenuItem
        '
        Me.kutusayýsýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sýrasayýsýnýgirToolStripMenuItem, Me.sütünsayýsýnýgirToolStripMenuItem})
        Me.kutusayýsýToolStripMenuItem.Name = "kutusayýsýToolStripMenuItem"
        Me.kutusayýsýToolStripMenuItem.Text = "kutu sayýsý"
        '
        'sýrasayýsýnýgirToolStripMenuItem
        '
        Me.sýrasayýsýnýgirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripTextBox1})
        Me.sýrasayýsýnýgirToolStripMenuItem.Name = "sýrasayýsýnýgirToolStripMenuItem"
        Me.sýrasayýsýnýgirToolStripMenuItem.Text = "sýra sayýsýný gir"
        '
        'toolStripTextBox1
        '
        Me.toolStripTextBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.toolStripTextBox1.Name = "toolStripTextBox1"
        Me.toolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        'sütünsayýsýnýgirToolStripMenuItem
        '
        Me.sütünsayýsýnýgirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripTextBox2})
        Me.sütünsayýsýnýgirToolStripMenuItem.Name = "sütünsayýsýnýgirToolStripMenuItem"
        Me.sütünsayýsýnýgirToolStripMenuItem.Text = "sütün sayýsýný gir"
        '
        'toolStripTextBox2
        '
        Me.toolStripTextBox2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.toolStripTextBox2.Name = "toolStripTextBox2"
        Me.toolStripTextBox2.Size = New System.Drawing.Size(100, 21)
        '
        'hýzayarýToolStripMenuItem
        '
        Me.hýzayarýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripComboBox3})
        Me.hýzayarýToolStripMenuItem.Name = "hýzayarýToolStripMenuItem"
        Me.hýzayarýToolStripMenuItem.Text = "hýz ayarý"
        '
        'toolStripComboBox3
        '
        Me.toolStripComboBox3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Me.toolStripComboBox3.Items.AddRange(New Object() {"level1", "level2", "level3", "level4", "level5"})
        Me.toolStripComboBox3.Name = "toolStripComboBox3"
        Me.toolStripComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.toolStripComboBox3.Text = "hýzý seç"
        '
        'yenioyunToolStripMenuItem
        '
        Me.yenioyunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.baþlatToolStripMenuItem})
        Me.yenioyunToolStripMenuItem.Name = "yenioyunToolStripMenuItem"
        Me.yenioyunToolStripMenuItem.Text = "yeni oyun"
        '
        'baþlatToolStripMenuItem
        '
        Me.baþlatToolStripMenuItem.Name = "baþlatToolStripMenuItem"
        Me.baþlatToolStripMenuItem.Text = "baþlat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 434)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ýmageList1 As System.Windows.Forms.ImageList
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents seçeneklerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents isimgiriþiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kutusayýsýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sýrasayýsýnýgirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents sütünsayýsýnýgirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents hýzayarýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripComboBox3 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents yenioyunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents baþlatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
