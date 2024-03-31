namespace _280124_GenelTekrar;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        txtUrunAdi = new TextBox();
        label2 = new Label();
        txtUrunFiyati = new TextBox();
        label3 = new Label();
        tetxtStokMiktari = new TextBox();
        label4 = new Label();
        cmbKategori = new ComboBox();
        lstListe = new ListBox();
        btnKaydet = new Button();
        btnAktar = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(34, 80);
        label1.Name = "label1";
        label1.Size = new Size(82, 25);
        label1.TabIndex = 0;
        label1.Text = "Urun Adi";
        // 
        // txtUrunAdi
        // 
        txtUrunAdi.Location = new Point(165, 80);
        txtUrunAdi.Name = "txtUrunAdi";
        txtUrunAdi.Size = new Size(280, 31);
        txtUrunAdi.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(34, 120);
        label2.Name = "label2";
        label2.Size = new Size(96, 25);
        label2.TabIndex = 0;
        label2.Text = "Urun Fiyati";
        // 
        // txtUrunFiyati
        // 
        txtUrunFiyati.Location = new Point(165, 117);
        txtUrunFiyati.Name = "txtUrunFiyati";
        txtUrunFiyati.Size = new Size(280, 31);
        txtUrunFiyati.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(34, 157);
        label3.Name = "label3";
        label3.Size = new Size(106, 25);
        label3.TabIndex = 0;
        label3.Text = "Stok Miktari";
        // 
        // tetxtStokMiktari
        // 
        tetxtStokMiktari.Location = new Point(165, 154);
        tetxtStokMiktari.Name = "tetxtStokMiktari";
        tetxtStokMiktari.Size = new Size(280, 31);
        tetxtStokMiktari.TabIndex = 1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(34, 44);
        label4.Name = "label4";
        label4.Size = new Size(110, 25);
        label4.TabIndex = 2;
        label4.Text = "Kategori Adi";
        // 
        // cmbKategori
        // 
        cmbKategori.FormattingEnabled = true;
        cmbKategori.Location = new Point(165, 41);
        cmbKategori.Name = "cmbKategori";
        cmbKategori.Size = new Size(280, 33);
        cmbKategori.TabIndex = 3;
        // 
        // lstListe
        // 
        lstListe.FormattingEnabled = true;
        lstListe.ItemHeight = 25;
        lstListe.Location = new Point(451, 41);
        lstListe.Name = "lstListe";
        lstListe.Size = new Size(180, 204);
        lstListe.TabIndex = 4;
        // 
        // btnKaydet
        // 
        btnKaydet.Location = new Point(165, 191);
        btnKaydet.Name = "btnKaydet";
        btnKaydet.Size = new Size(130, 54);
        btnKaydet.TabIndex = 5;
        btnKaydet.Text = "Kaydet";
        btnKaydet.UseVisualStyleBackColor = true;
        btnKaydet.Click += btnKaydet_Click;
        // 
        // btnAktar
        // 
        btnAktar.Location = new Point(304, 191);
        btnAktar.Name = "btnAktar";
        btnAktar.Size = new Size(130, 54);
        btnAktar.TabIndex = 5;
        btnAktar.Text = "Aktar";
        btnAktar.UseVisualStyleBackColor = true;
        btnAktar.Click += btnAktar_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnAktar);
        Controls.Add(btnKaydet);
        Controls.Add(lstListe);
        Controls.Add(cmbKategori);
        Controls.Add(label4);
        Controls.Add(tetxtStokMiktari);
        Controls.Add(label3);
        Controls.Add(txtUrunFiyati);
        Controls.Add(label2);
        Controls.Add(txtUrunAdi);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtUrunAdi;
    private Label label2;
    private TextBox txtUrunFiyati;
    private Label label3;
    private TextBox tetxtStokMiktari;
    private Label label4;
    private ComboBox cmbKategori;
    private ListBox lstListe;
    private Button btnKaydet;
    private Button btnAktar;
}
