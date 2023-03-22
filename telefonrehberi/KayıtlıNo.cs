namespace telefonrehberi
{
    public class KayıtlıNo
    {
        public static List<Rehber> _rehber;

        static KayıtlıNo()
        {
            _rehber = new List<Rehber>()
            {
                new Rehber {isim = "Emre", soyisim = "Tamam", numara = "0123456789"},
                new Rehber {isim = "Mustafa", soyisim = "Avcu", numara = "0123456789"},
                new Rehber {isim = "Bayram", soyisim = "Faruk", numara = "0123456789"},
                new Rehber {isim = "Samo", soyisim = "Aydın", numara = "0123456789"},
                new Rehber {isim = "Halo", soyisim = "Dayı", numara = "0123456789"},
            };
        }

        public static List<Rehber> rehberim
        {
            get {return _rehber; }
        }

        public static void Listele()
        {
            foreach (var item in rehberim)
            {
                Console.WriteLine(item.isim + " " + item.soyisim + " " + item.numara);
            }
        }
    }
}