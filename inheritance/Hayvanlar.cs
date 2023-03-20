namespace inheritance;

public class Hayvanlar:Canlılar
{
    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adapte sürecine girer.");
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
    }
    public void UcarakHareket()
    {
        Console.WriteLine("Kuşlar uçarak hareket eder.");
    }
}