namespace inheritance;

public class Hayvanlar:Canlılar
{
    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adapte sürecine girer.");
    }

    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
}

public class Sürüngenler:Hayvanlar
{
    public Sürüngenler(){
        base.Adaptasyon();
        base.Beslenme();
        base.Solunum();
    }
    public void SürünerekHareket()
    {
        Console.WriteLine("Sürüngenler sürünerek hareket eder.");
    }
}

public class Kuslar:Hayvanlar
{
    public Kuslar(){
        base.Adaptasyon();
        base.Beslenme();
        base.Solunum();
        base.UyaranlaraTepki();
    }
    public void UcarakHareket()
    {
        Console.WriteLine("Kuşlar uçarak hareket eder.");
    }
}