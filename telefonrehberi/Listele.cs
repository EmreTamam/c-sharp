namespace telefonrehberi
{
    public class Listele : KayıtlıNo
    {
        public static void Listeleme()
        {
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("***********************************");
                
                foreach (var item in rehberim)
                {
                    Console.WriteLine("İsim            : " + item.isim);
                    Console.WriteLine("Soyisim         : " + item.soyisim);
                    Console.WriteLine("Telefon Numarası: " + item.numara);
                    Console.WriteLine("-");
                }
        }
    }

}