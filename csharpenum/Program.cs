namespace csharpenum;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazartesi);
        Console.WriteLine((int)Gunler.Cuma);

        int sicaklik = 25;

        if(sicaklik <= (int)HavaDurumu.Normal)
            Console.WriteLine("Hava Soğuk");
        else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.Sıcak)
            Console.WriteLine("Hava Normal");
        else if(sicaklik >= (int)HavaDurumu.Sıcak)
            Console.WriteLine("Hava Sıcak");

            
    }
}

enum Gunler
{
    Pazartesi = 1,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soğuk = 5,
    Normal = 20,
    Sıcak = 30
}