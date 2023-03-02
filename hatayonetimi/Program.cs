namespace hatayonetimi;
class Program
{
    static void Main(string[] args)
    {
        try
        {
        Console.WriteLine("Sayı Giriniz!:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girdiğiniz Sayi:" + sayi);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("Ok.");
        }

        try
        {
            int a = int.Parse(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş Deger Girdiniz.");
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri uygunsuz.");
            Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Çok büyük yada küçük bir değer girildi.");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("Ok.");
        }
    }
}
