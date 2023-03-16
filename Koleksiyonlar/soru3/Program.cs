using System.Collections;

namespace soru3;
class Program
{
    static void Main(string[] args)
    {
        ArrayList vowels = new ArrayList();
        findVowels(vowels);
    }

    public static void findVowels(ArrayList vowel)
    {
        Console.WriteLine("Cümle Giriniz:");

        string sentence = Console.ReadLine();
        sentence = sentence.ToLower();

        foreach(var item in sentence)
        {
            if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö'|| 
                item == 'u' || item == 'ü')
            {
                vowel.Add(item);
            }
        }

        Console.WriteLine("Sesli Harfler: ");

        foreach(var item in vowel)
            Console.Write(item + " ");
    }
}
