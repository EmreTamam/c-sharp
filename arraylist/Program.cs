using System.Collections;

namespace arraylist;
class Program
{
    static void Main(string[] args)
    {
        //System.Collections namespace
        ArrayList liste = new ArrayList();
        liste.Add("Ayşe");
        liste.Add(2);
        liste.Add(true);
        liste.Add('A');

        //Erişim
        Console.WriteLine(liste[1]);

        foreach (var item in liste)
            Console.WriteLine(item);

        //AddRange
        string[] renkler = {"kırmızı","sarı"};
        List<int> sayilar = new List<int>(){1,2,5,7,4};
        liste.AddRange(sayilar);
        liste.AddRange(renkler);

        foreach (var item in liste)
            Console.WriteLine(item);
        
        //Sort
        liste.Sort();

        //Binary Search
        Console.WriteLine(liste.BinarySearch(9));

        //Reverse
        liste.Reverse();

        //clear
        liste.Clear();
    }
}
