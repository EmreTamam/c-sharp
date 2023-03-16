using System.Collections;

namespace soru2;
class Program
{
    static void Main(string[] args)
    {
        ArrayList numbers = new ArrayList();
        ArrayList minNumbers = new ArrayList();
        ArrayList maxNumbers = new ArrayList();


        InputNumbers(numbers,minNumbers,maxNumbers);
        MinNumbers(numbers, minNumbers);
        MaxNumbers(numbers,maxNumbers);
        MinAverage(minNumbers);
        MaxAverage(maxNumbers);
    }
    public static void InputNumbers(ArrayList numbers, ArrayList minNumbers, ArrayList maxNumbers)
    {
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("{0}. Sayıyı Giriniz:", i+1);
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                numbers.Add(n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen Sayı Giriniz.");
            }
        }
    }
    
    public static void MinNumbers (ArrayList numbers, ArrayList minNumbers)
    {
        numbers.Sort();
        for(int i = 0; i < 3; i++)
        {
            minNumbers.Add(numbers[i]);
        }

        Console.WriteLine("Küçük Sayılar:");
        foreach (var item in minNumbers)
            Console.Write(item+" ");
        Console.WriteLine();
    }

    public static void MaxNumbers(ArrayList numbers, ArrayList maxNumbers)
    {
        numbers.Sort();
        numbers.Reverse();
        for(int i = 0; i < 3; i++)
        {
            maxNumbers.Add(numbers[i]);
        }

        Console.WriteLine("Büyük Sayılar:");
        foreach (var item in maxNumbers)
            Console.Write(item+" ");
        Console.WriteLine();
    }

    public static void MinAverage(ArrayList minNumbers)
    {
        int minSum = 0;
        float minAvr = 0;

        foreach(int item in minNumbers)
            minSum += item;

        minAvr = minSum / 3;

        Console.WriteLine("Küçük Sayıların Ortalaması: "+minAvr);
    }

    public static void MaxAverage(ArrayList maxNumbers)
    {
        int maxSum = 0;
        float maxAvr = 0;

        foreach(int item in maxNumbers)
            maxSum += item;

        maxAvr = maxSum / 3;

        Console.WriteLine("Büyük Sayıların Ortalaması: "+maxAvr);
    }

   
}


