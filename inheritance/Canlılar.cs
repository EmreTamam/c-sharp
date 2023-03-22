namespace inheritance;

public class Canlılar
{
    protected void Beslenme()
    {
        Console.WriteLine("canlılar beslenir");
    }

    protected void Solunum()
    {
        Console.WriteLine("canlılar solunum yapar");
    }

    public virtual void UyaranlaraTepki()
    {
        Console.WriteLine("Canlılar uyarılara tepki verir.");
    }
}