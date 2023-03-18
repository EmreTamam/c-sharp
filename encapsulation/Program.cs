namespace encapsulation;
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ayşe";
        ogrenci.Soyisim = "Kara";
        ogrenci.No = 293;
        ogrenci.Sinif = 3;
        ogrenci.OgrenciBilgileriniGetir();

        ogrenci.SinifAtlat();
        ogrenci.OgrenciBilgileriniGetir();

        Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
        ogrenci1.OgrenciBilgileriniGetir();
        ogrenci1.SinifDusur();
        ogrenci1.SinifDusur();
        ogrenci1.OgrenciBilgileriniGetir();

    }
}

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int no;
    private int sinif;

    public string Isim { 
        get => isim; 
        set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int No { get => no; set => no = value; }
    public int Sinif
    { 
        get => sinif;
        set
        {
            if(value < 1)
            {
                Console.WriteLine("sınıf en az 1 olabiliir");
            }
            else
                sinif = value;
        }
    }

    public Ogrenci(string ısim, string soyisim, int no, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        No = no;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("Ögrenci Adı: {0}",this.isim);
        Console.WriteLine("Ögrenci Soyadı: {0}",this.soyisim);
        Console.WriteLine("Ögrenci No: {0}",this.no);
        Console.WriteLine("Ögrenci sınıfı: {0}",this.sinif);
    }

    public void SinifAtlat()
    {
        this.sinif = this.sinif + 1;
    }

    public void SinifDusur()
    {
        this.sinif = this.sinif - 1;
    }
}
