namespace kurucu_metotlar;
class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan("Ayşe","Kara",1235,"ik");
        calisan1.CalisanBilgileri();

        Calisan calisan2 = new Calisan();
        calisan1.Ad = "Deniz";
        calisan1.Soyad = "Arda";
        calisan1.No = 21359;
        calisan1.Departman = "Satın Alma";
        calisan2.CalisanBilgileri();
        
        Calisan calisan3 = new Calisan("Emre","Tamam");
        calisan3.CalisanBilgileri();
    }
}

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyadı, int no, string departmanı)
    {
        this.Ad = ad;
        this.Soyad = soyadı;
        this.No = no;
        this.Departman = departmanı;
    }

    public Calisan(string ad, string soyadı)
    {
        this.Ad = ad;
        this.Soyad = soyadı;
    }

    public Calisan(){}

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan adı: {0}", Ad);
        Console.WriteLine("Çalışan soyadı: {0}", Soyad);
        Console.WriteLine("Çalışan numarası: {0}", No);
        Console.WriteLine("Çalışan depertmanı: {0}", Departman);
    }
}
