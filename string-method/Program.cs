namespace string_method;
class Program
{
    static void Main(string[] args)
    {
        string degisken = "Merhaba Hoşgeldiniz";
        string degisken2 = "Hoşgeldiniz";
        //Length
        Console.WriteLine(degisken.Length);

        //ToUpper, ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat
        Console.WriteLine(string.Concat(degisken,"Dünya!"));

        //Compare, CompareTo
        // = 0, > 1, < -1;
        Console.WriteLine(degisken.CompareTo(degisken2));
        Console.WriteLine(string.Compare(degisken,degisken2,true)); // true = büyük küçük harf duyarsız.
       
       //Contains
       Console.WriteLine(degisken.Contains(degisken2)); //içinde var ise true dönecek.(içeriyor mu?)
       Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));// x ile bitiyor mu
       Console.WriteLine(degisken.StartsWith("Merhaba"));// x ile başlıyor mu

       //IndexOf
       Console.WriteLine(degisken.IndexOf("Hoş"));
       Console.WriteLine(degisken.LastIndexOf("i"));
       
       //Insert
       Console.WriteLine(degisken.Insert(0,"Selam!"));

       //PadRight, PadLeft

       Console.WriteLine(degisken + degisken2.PadLeft(30));
       Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
       Console.WriteLine(degisken + degisken2.PadRight(30));
       Console.WriteLine(degisken + degisken2.PadRight(30,'-'));

       //Remove 
       Console.WriteLine(degisken.Remove(10));
       Console.WriteLine(degisken.Remove(0,1));

       //Replace
       Console.WriteLine(degisken.Replace("Merhaba","Selam"));
       
       //Split
       Console.WriteLine(degisken.Split(' ')[1]);

       //Substring
       Console.WriteLine(degisken.Substring(4)); //4'den başla sonuna kadar getir.
    }
}
