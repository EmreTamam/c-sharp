namespace genericlist;
class Program
{
    static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        // T => object türündedir.

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(8);
        sayiListesi.Add(5);
        sayiListesi.Add(45);
        sayiListesi.Add(12);

        List<string> renkListesi = new List<string>();

        renkListesi.Add("Mavi");
        renkListesi.Add("Yeşil");
        renkListesi.Add("Siyah");
        renkListesi.Add("Sarı");
        renkListesi.Add("Mor");
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Siyah");

        //Count
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        //foreach ile elemanlara erişim
        foreach (var sayi in sayiListesi)
            Console.WriteLine(sayi);
        foreach (var renk in renkListesi)
            Console.WriteLine(renk);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Listeden eleman çıkarma
        sayiListesi.Remove(5);
        //renkListesi.Remove("Sarı");

        sayiListesi.RemoveAt(0);
        //renkListesi.RemoveAt(1);

        //Liste'de eleman bulma.
        if(sayiListesi.Contains(5))
            Console.WriteLine("Liste içerisinde 5 sayısı bulunmaktadır");

        //İndex'e erişim.
        Console.WriteLine(renkListesi.IndexOf("Siyah"));
        Console.WriteLine(renkListesi.IndexOf("Siyah",3));

        //Diziyi List'e çevirme.
        string[] hayvanlar = {"Kedi","Köpek","Maymun"};
        List<string> hayvanListesi = new List<string>(hayvanlar);

        //Liste temizleme.
        hayvanListesi.Clear();

        //List eleman tutmak
        List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();

        Kullanıcılar kullanici1 = new Kullanıcılar();
        kullanici1.Isim = "Emre";
        kullanici1.Soyadi = "Tamam";
        kullanici1.Yas = 20;

        Kullanıcılar kullanici2 = new Kullanıcılar();
        kullanici2.Isim = "Mahmut";
        kullanici2.Soyadi = "Tuncer";
        kullanici2.Yas = 57;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

        yeniListe.Add(new Kullanıcılar(){
            Isim = "Mustafa",
            Soyadi = "Avcu",
            Yas = 21
        });

        foreach (var kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kulanıcı Adı: "+kullanici.Isim);
            Console.WriteLine("Kulanıcı Soyadı: "+kullanici.Soyadi);
            Console.WriteLine("Kulanıcı Yaşı: "+kullanici.Yas);
        }
    }

    public class Kullanıcılar{
        private string isim;

        private string soyadi;

        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyadi { get => soyadi; set => soyadi = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
