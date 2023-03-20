namespace inheritance;

public class Bitkiler:Canlılar
{
    protected void Fotosentez()
    {
        Console.WriteLine("Bitkiler Fotosentez yapar.");
    }
}

public class TohumluBitkiler:Bitkiler
{
    public TohumluBitkiler(){
        base.Beslenme();
        base.Fotosentez();
        base.Solunum();
    }
    public void TohumlaCogalma()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla coğalır");
    }
}

public class TohumsuzBitkiler:Bitkiler
{
    public TohumsuzBitkiler(){
        base.Beslenme();
        base.Fotosentez();
        base.Solunum();
    }
    public void TohumsuzCogalma()
    {
        Console.WriteLine("Tohumsuz bitkiler sporla coğalır.");
    }
}