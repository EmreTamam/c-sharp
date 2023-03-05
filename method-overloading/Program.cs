namespace method_overloading;
class Program
{
    static void Main(string[] args)
    {
        //out parametreler
        string sayi = "999";

        bool sonuc = int.TryParse(sayi, out int outSayi);

        if(sonuc)
        {
            Console.WriteLine("Ok.");
            Console.WriteLine(outSayi);
        }
        else
            Console.WriteLine("Başarısız.");

        Methods inst = new Methods();
        inst.Topla(2,3, out int toplamsonuc);
        Console.WriteLine(toplamsonuc);

        //Method Overloading

        int ifade = 999;
        inst.EkranaYazir(ifade);

        //Metot İmzası
        // metotAdi + parametre sayisi + paramtre
    }
}

class Methods
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }

    public void EkranaYazir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazir(int veri)
    {
        Console.WriteLine(veri);
    }
}
