namespace methods;
class Program
{
    static void Main(string[] args)
    {
        // erisim_belirteci geri_donüstipi metot_adi(parametreListesi/argüman)

        int a = 2;
        int b = 3;

        int sonuc = Topla(a, b);
        Console.WriteLine(sonuc);

        Metotlar inst = new Metotlar();
        inst.EkranaYazdir(Convert.ToString(sonuc));

        int sonuc2 = inst.ArttirVeTopla(ref a, ref b);
        inst.EkranaYazdir(Convert.ToString(sonuc2));
    }

    static int Topla(int x, int y)
    {
        return(x+y);
    }
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int x, ref int y)
    {
        x += 1;
        y += 1;
        return x + y;
    }
}
