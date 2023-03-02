namespace donusumler;
class Program
{
    static void Main(string[] args)
    {
        // Implicit Conversion (bilinçsiz dönüşüm)

        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a+b+c;
        Console.WriteLine(d);

        long h = d;
        Console.WriteLine(h);

        float i = h;
        Console.WriteLine(i);

        string e = "emre";
        char f = 'a';
        object g = e+f;
        Console.WriteLine(g);

        //Explicit Conversion (Bilinçli Dönüşüm)

        int x = 4;
        byte y = (byte)x;
        Console.WriteLine(y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine(t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine(w);

        // ToString Method

        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine(yy);

        // System.Convert

        string s1 = "10", s2 = "20";
        int sayi1, sayi2;
        int toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);

        toplam = sayi1 + sayi2;
        Console.WriteLine(toplam);

        // Parse

        ParseMethod();
    }

    public static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam;
        double dble;

        rakam = Int32.Parse(metin1); //parse her zaman string dönüştürür.
        dble = Double.Parse(metin2);

        Console.WriteLine(rakam);
        Console.WriteLine(dble);
    }
}
