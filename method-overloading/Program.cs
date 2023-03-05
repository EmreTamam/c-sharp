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
    }
}

class Methods
{
    public int Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }
}
