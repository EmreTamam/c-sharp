namespace telefonrehberi
{
    public class Güncelle:KayıtlıNo
    {
        public static void Güncelleme()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string check = Console.ReadLine();

            foreach (var item in rehberim)
            {
                if (check == item.isim || check == item.soyisim)
                {
                    Console.WriteLine("Lütfen yeni numarayı giriniz:");
                    string newNo = Console.ReadLine();
                    item.numara = newNo;
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden denemek için (2)");
                    int check1 = Convert.ToInt32(Console.ReadLine());

                    if(check1 == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    }
                    else
                    {
                        Güncelle.Güncelleme();
                    }
                break;
                }
            }
        }
    }
}