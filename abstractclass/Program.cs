namespace abstractclass;
class Program
{
    static void Main(string[] args)
    {
        Corvette corvy = new Corvette();
        Console.WriteLine(corvy.RengiNe().ToString());
        Console.WriteLine(corvy.Markasi().ToString());
        Console.WriteLine(corvy.Tekerlek());
    }
}
