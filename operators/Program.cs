using System;

namespace operators;
class Program
{
    static void Main(string[] args)
    {
        //atama operatörleri
        int x = 3;
        int y = 3;
        y = y+2;
        y += 2;

        y /= 1;
        x *= 2;

        //mantıksal operatörler

        bool isSuccess = true;
        bool isCompleted = false;

        if(isSuccess && isCompleted)
            Console.WriteLine("Perfect"); //null

        if(isSuccess || isCompleted)
            Console.WriteLine("Great"); //1
        
        if(isSuccess && !isCompleted)
            Console.WriteLine("Fine"); //1

        //ilişkisel operatörler

        int a = 3;
        int b = 4;
        bool sonuc = a<b;

        Console.WriteLine(sonuc); //1
        sonuc = a>b;
        Console.WriteLine(sonuc); //0
        sonuc = a>=b;
        Console.WriteLine(sonuc);//0
        sonuc = a<=b;
        Console.WriteLine(sonuc);//1
        sonuc = a==b;
        Console.WriteLine(sonuc);//0
        sonuc = a!=b;
        Console.WriteLine(sonuc);//1

        //aritmetik operatörler

        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1= sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1-sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = ++sayi1;
        Console.WriteLine(sonuc1);

        int sonuc2 = 20%3;
        Console.WriteLine(sonuc2);
    }
}
