namespace sinif_kavrami;
class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan();
        calisan1.Ad = "Ayse";
        calisan1.Soyad = "Kara";
        calisan1.No = 21358;
        calisan1.Departman = "İK";

        calisan1.CalisanBilgileri();

        Calisan calisan2 = new Calisan();
        calisan1.Ad = "Deniz";
        calisan1.Soyad = "Arda";
        calisan1.No = 21359;
        calisan1.Departman = "Satın Alma";

        calisan2.CalisanBilgileri();
    }
}

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan adı: {0}", Ad);
        Console.WriteLine("Çalışan soyadı: {0}", Soyad);
        Console.WriteLine("Çalışan numarası: {0}", No);
        Console.WriteLine("Çalışan depertmanı: {0}", Departman);
    }
}
