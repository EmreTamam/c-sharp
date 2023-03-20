namespace static_sinif_ve_üyeler;
class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan("Ayşe", "Yılmaz", "IK");
        Console.WriteLine("Çalışan Sayısı {0}", Calisan.CalisanSayisi);
        Calisan calisan2 = new Calisan("Deniz", "Yılmaz", "IK");
        Console.WriteLine("Çalışan Sayısı {0}", Calisan.CalisanSayisi);
        

        Console.WriteLine("Toplam: {0}", Islemler.Topla(4,2));
        Console.WriteLine("Çıkan: {0}", Islemler.Cikar(4,2));
    }
}

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi;}

    private string Isim;
    private string Soyİsim;
    private string Departman;

    static Calisan(){
        calisanSayisi = 0;
    }

    public Calisan(string isim, string soyİsim, string departman)
    {
        this.Isim = isim;
        this.Soyİsim = soyİsim;
        this.Departman = departman;
        calisanSayisi++;
    }
}

static class Islemler
{
    public static long Topla (int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Cikar (int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}