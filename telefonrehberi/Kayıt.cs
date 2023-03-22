namespace telefonrehberi
{
    public class Kayıt:KayıtlıNo
    {
        public static void Kaydet()
        {
            Console.WriteLine("Lütfen ad giriniz            :");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyad giriniz         :");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string no = Console.ReadLine();

            Rehber kişi = new Rehber();
            kişi.isim = ad;
            kişi.soyisim = soyad;
            kişi.numara = no;

            KayıtlıNo.rehberim.Add(kişi);
        }
    }
}