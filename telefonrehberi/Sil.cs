namespace telefonrehberi
{
    public class Sil:KayıtlıNo
    {
        public static void Silme()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input = Console.ReadLine();

            foreach (var item in rehberim.ToList())
            {
                if(input == item.isim || input == item.soyisim)
                {
                    Console.WriteLine(item.isim + " " + item.soyisim + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
                    string check = Console.ReadLine();
                    if(check == "y")
                    {
                        rehberim.Remove(item);
                    }
                    else
                    {
                        Console.WriteLine("Çıkış yapılıyor.");
                        break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                    Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden denemek için (2)");
                    int check1 = Convert.ToInt32(Console.ReadLine());

                    if(check1 == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    }
                    else
                    {
                        Sil.Silme();
                    }
                break;
                }         
            }
        }
    }
}