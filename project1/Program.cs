namespace project1;
class Program
{
    static void Main(string[] args)
    {   
       /* #region subject1 
        Console.WriteLine("Bir Sayı Giriniz.");
        int count = int.Parse(Console.ReadLine());
        int[] dizi = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Lütfen {0}. sayiyi giriniz.", i+1);
            dizi[i] = int.Parse(Console.ReadLine());
        }

         foreach (var sayi in dizi)
            if(sayi % 2 == 0) Console.WriteLine(sayi);
        #endregion*/
        
       /* #region subject2 
        Console.WriteLine("Birinci Sayıyı Giriniz.");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("İkinci Sayıyı Giriniz.");
        int m = int.Parse(Console.ReadLine());

        int[] dizi = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Lütfen {0}. sayiyi giriniz.", i+1);
            dizi[i] = int.Parse(Console.ReadLine());
        }

           foreach (var sayi in dizi)
               if(sayi % m == 0 || sayi == m) Console.WriteLine(sayi);
        #endregion*/

       /* #region subject3
       Console.WriteLine("Bir Sayı Giriniz.");
       int count = int.Parse(Console.ReadLine());

       string[] kelimeler = new string[count];

       for (int i = 0; i < count; i++)
       {
            Console.WriteLine("Lütfen {0}. Kelimeyi Giriniz.", i+1);
            string kelime = Console.ReadLine();
            kelimeler[i] = kelime;
       }
       Array.Reverse(kelimeler);
       foreach (var item in kelimeler)
             Console.WriteLine(item);
        #endregion */
    
       /*#region subject4
       
        Console.WriteLine("Bir Cümle yazınız.");
        string metin = Console.ReadLine();

        string[] kelimeler = metin.Split(' ');
        string def = String.Join("",kelimeler);
        char[] harf = def.ToCharArray();

        Console.WriteLine("Kelime Sayısı :"+kelimeler.Length);
        Console.WriteLine("Harf Sayısı :"+harf.Length);
        
        foreach(string kelime in kelimeler)
        {
            Console.Write(kelime+" ");
        }

       #endregion*/

    }
}
