namespace loops;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir Sayi Giriniz.");
        int count = int.Parse(Console.ReadLine());
        for (int i = 1; i < count; i++)
        {
            if (i % 2 == 1)
                Console.WriteLine(i);
        }

        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 1; i < 1001; i++)
        {
            if(i % 2 == 1)
                tekToplam += i;
            else
                ciftToplam += i;
        }
        Console.WriteLine(tekToplam);
        Console.WriteLine(ciftToplam);

        //break, continue

        for (int i = 1; i < 11; i++)
        {
            if(i == 4)
                break;
            Console.WriteLine(i);
        }
        for (int i = 1; i < 11; i++)
        {
            if(i == 4)
                continue;
            Console.WriteLine(i);
        }
    }
}
