namespace arrays;
class Program
{
    static void Main(string[] args)
    {
        // Dizi Tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

        int[] dizi;
        dizi = new int[5];

        //Değer atama ve erişim.

        renkler[0] = "Mavi";
        dizi[3] = 10;
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        // Döngülerle dizi kullanımı.

        //Klavyeden girilen n tane sayının ortalaması

        Console.WriteLine("Lütfen dizinin eleman sayısını giriniz");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("Lütfen {0}. sayiyi giriniz.", i+1);
            array[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in array)
            toplam += sayi;

        Console.WriteLine("Ortalama :"+ toplam/arrayLength);
    }
}
