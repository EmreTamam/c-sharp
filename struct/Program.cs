namespace structer;
class Program
{
    static void Main(string[] args)
    {
        Dikdörtgen dk = new Dikdörtgen();
        dk.kisaKenar = 5;
        dk.uzunKenar = 7;

        Console.WriteLine("Alan: {0}", dk.AlanHesapla());

        Dikdörtgen_Struct dkstruct;
        dkstruct.kisaKenar = 5;
        dkstruct.uzunKenar = 7;

        Console.WriteLine("Alan: {0}", dkstruct.AlanHesapla());
    }
}

class Dikdörtgen
{
    public int kisaKenar;
    public int uzunKenar;

    public long AlanHesapla()
    {
        return this.kisaKenar * this.uzunKenar;
    }
}

struct Dikdörtgen_Struct
{
    public int kisaKenar;
    public int uzunKenar;

    public long AlanHesapla()
    {
        return this.kisaKenar * this.uzunKenar;
    }
}
