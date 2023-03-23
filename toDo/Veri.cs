namespace toDo
{
    public class Veri:Kart
    {
        public static List<Kart> kartlar = new List<Kart>();
        public static List<Kişi> kişiler = new List<Kişi>();

        static Veri()
        {
            kişiler = new List<Kişi>()
            {
                new Kişi{id = 1, isim = "Ceren"},
                new Kişi{id = 2, isim = "Kaan"},
                new Kişi{id = 3, isim = "İrem"},
                new Kişi{id = 4, isim = "Meriç"}
            };

            kartlar = new List<Kart>()
            {
                new Kart{başlık = "Ödev" , içerik = "test", kişi = "Emre", size = "S", line = "TODO"},
                new Kart{başlık = "Toplantı" , içerik = "test1", kişi = "Mavcu", size = "XS", line = "DONE"},
                new Kart{başlık = "Eğitim" , içerik = "test2", kişi = "Samo", size = "L", line = "INPROGRESS"},
                new Kart{başlık = "Proje" , içerik = "test3", kişi = "Bayro", size = "M", line = "TODO"}
            };
        }
        public static void VeriYaz()
        {
            foreach (var item in kartlar)
            {
                Console.WriteLine(item.başlık+ " " + item.içerik + " " + item.kişi + " " + item.size + " " + item.line);
            }
        }
    }
    
}