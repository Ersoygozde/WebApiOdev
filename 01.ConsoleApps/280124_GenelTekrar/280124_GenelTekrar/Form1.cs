namespace _280124_GenelTekrar;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Kategorileri dolduralim
        string[] Kategoriler = new string[] { "Teknoloji", "Ev Gerecleri", "Bahce Malzemeleri", "Beyaz Esya" };

        //combobox'a ekleme yapma
        cmbKategori.Items.Add("Deneme");

        foreach (var item in Kategoriler)
        {
            cmbKategori.Items.Add(item);
        }
    }
    // int counter = 0; //global degisken
    int sayac = 0; // yerel degisken
    private void btnKaydet_Click(object sender, EventArgs e)
    {
        /* Kaydet Butonuna basildiginda tum veriler alinarak asagidaki sekilde bir diziye eklenecektir. Aktar butonuna basildiginda dizi icerisinden tum degerler okunarak listeye eklenecektir.
         */

        //form uzerinden degerler aliniyor


        string KategoriAdi = cmbKategori.Text;
        string urunAdi = txtUrunAdi.Text;
        double urunFiyati = Convert.ToDouble(txtUrunFiyati.Text);
        int stokMiktari = Convert.ToInt32(tetxtStokMiktari.Text);

        //string eklenecekMetin = kategoriAdi + " " + urunAdi;

        //diziye eklenecek cumle olusturuluyor:
        string eklenecekMetin = $"{urunAdi}-{urunFiyati}-{stokMiktari}";

        //diziye ekleniyor:
        string[] eklenecekData = new string[5];
        eklenecekData[sayac] = eklenecekMetin;
        sayac++;

        //Diziye 1 eleman daha ekleyelim



    }

    private void btnAktar_Click(object sender, EventArgs e)
    {
        // burada globalde bulunan diziye ulasarak tum elemanlarini listeye ekliyoruz.

        foreach (var item in eklenecekData)
        {
            //Listbox'a ekleme yapiyoruz:
            lstListe.Items.Add(item);
        }

    }
}
