namespace telefonrehberi
{
    public class Arama:KayıtlıNo
    {
        public static void Ara()
        {
            Console.WriteLine("Arama yapmak istediğiniz yöntemi seçiniz:");
            Console.WriteLine("*****************************************");
            Console.WriteLine("İsim veya soy isime göre arama yapmak için: (1)");
            Console.WriteLine("Numaraya göre arama yapmak için: (2)");
            int optionCheck = Convert.ToInt32(Console.ReadLine());

            if (optionCheck == 1)
            {
                Console.WriteLine("Lütfen isim  veya soyisim giriniz:");
                string check = Console.ReadLine();
                foreach (var item in rehberim)
                {
                    if (check == item.isim || check == item.soyisim)
                    {
                        Console.WriteLine("İsim            : " + item.isim);
                        Console.WriteLine("Soyisim         : " + item.soyisim);
                        Console.WriteLine("Telefon Numarası: " + item.numara);
                        Console.WriteLine("-");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil.");
                        break;
                    }
                }
            }

            else
            {
                Console.WriteLine("Lütfen numarayı giriniz:");
                string check1 = Console.ReadLine();
                foreach (var item in rehberim)
                {
                    if (check1 == item.numara)
                    {
                        Console.WriteLine("İsim            : " + item.isim);
                        Console.WriteLine("Soyisim         : " + item.soyisim);
                        Console.WriteLine("Telefon Numarası: " + item.numara);
                        Console.WriteLine("-");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil.");
                        break;
                    }
                }
            }
        }
    }
}