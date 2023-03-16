using System.Collections;

namespace soru1;
class Program
{
    static void Main(string[] args)
    {
        ArrayList numbers = new ArrayList();
        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();

        float primeAvr = 0, primeSum = 0, nonPrimeAvr = 0, nonPrimeSum = 0;
        int primeCount = 0, nonPrimeCount = 0;

        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("{0}. Sayıyı Giriniz:", i+1);
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if(n <= 0)
                    Console.WriteLine("Lütfen pozitif sayı giriniz.");
                else
                    numbers.Add(n);
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen Sayı Giriniz.");
            }
        }

        foreach (int item in numbers)
        {
    
            if(isPrime(item))
            {
                primeNumbers.Add(item);
                primeSum += item;
                primeCount++;
            }
            else
            {
                nonPrimeNumbers.Add(item);
                nonPrimeSum += item;
                nonPrimeCount++;
            }
        }
            

        primeAvr = primeSum / primeCount;
        nonPrimeAvr = nonPrimeSum / nonPrimeCount;

        primeNumbers.Sort();
        nonPrimeNumbers.Reverse();

        nonPrimeNumbers.Sort();
        primeNumbers.Reverse();

        Console.WriteLine();
        Console.WriteLine("ASAL SAYILAR");

        foreach(var item in primeNumbers)
            Console.Write(item + " ");

        Console.WriteLine();
        Console.WriteLine("ASAL OLMAYAN SAYILAR");

        foreach(var item in nonPrimeNumbers)
            Console.Write(item + " ");

        Console.WriteLine();
        Console.WriteLine("{0} ADET ASAL SAYININ ORTALAMASI: {1}", primeCount, primeAvr);
        Console.WriteLine("{0} ADET ASAL OLMAYAN SAYININ ORTALAMASI: {1}", nonPrimeCount, nonPrimeAvr);
    }

    public static bool isPrime(int nbr)
    {
        bool Case = false;
        int Control = 0;

        for (int i = 2; i < nbr; i++)
        {
            if(nbr % i == 0)
            {
                Control = 1;
                break;
            }
        }
        if(Control == 1)
            Case = false;
        else
            Case = true;

        return Case;

    }
}
