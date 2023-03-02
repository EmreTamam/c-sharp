namespace if_else_if;
class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        // if * else if

        if(time >= 6 && time <= 10)
            Console.WriteLine("Günaydin!");
        else if(time <= 18)
            Console.WriteLine("İyi Günler!");
        else
            Console.WriteLine("İyi Geceler!");

        // ternary if * ? true : false
        string sonuc;
        sonuc = time >= 6 && time <= 10 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
        Console.WriteLine(sonuc);
    }
}
