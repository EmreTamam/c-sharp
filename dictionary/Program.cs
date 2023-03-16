namespace dictionary;
class Program
{
    static void Main(string[] args)
    {
        //system.colleciton.generic
        Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

        kullanicilar.Add(10,"Ayşe Yılmaz");
        kullanicilar.Add(12,"Ahmet yılmaz");
        kullanicilar.Add(18,"Ayşe Arda");
        kullanicilar.Add(20,"Deniz Coşar");

        //elemanlara erişim
        Console.WriteLine(kullanicilar[12]);
        foreach (var item in kullanicilar)
            Console.WriteLine(item);

        //count
        kullanicilar.Count();

        //contains
        kullanicilar.ContainsKey(12);
        kullanicilar.ContainsValue("Ayşe Yılmaz");

        //remove
        kullanicilar.Remove(12);

        //Keys

        foreach (var item in kullanicilar.Keys)
            Console.WriteLine(item);
            
        //Values
        foreach (var item in kullanicilar.Values)
            Console.WriteLine(item);
    }
}
