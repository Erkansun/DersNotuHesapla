using System.Globalization;

namespace DersNotuHesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
        baslangic:

            Console.WriteLine("**********************************************");
            Console.WriteLine("*                                            *");
            Console.WriteLine("* DERS NOTU HESAPLAMA VE HARF NOTU BELİRLEME *");
            Console.WriteLine("*                                            *");
            Console.WriteLine("**********************************************");

            Console.WriteLine("");

            Console.Write("Ders adı: ");
            string dersAdi=Console.ReadLine();

            Console.Write("Vize notunuz: ");
            int vizeNotu=  Convert.ToInt32(Console.ReadLine());

            Console.Write("Final notunuz: ");
            int finalNotu= Convert.ToInt32(Console.ReadLine());

            double notOrtalamasi = (vizeNotu * 0.40) + (finalNotu * 0.60);

            if (notOrtalamasi >=0 && notOrtalamasi < 50)
            {
                Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: D");
            }else if (notOrtalamasi >= 50 && notOrtalamasi < 60)
            {
                Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: C2");
            }else if (notOrtalamasi >= 60 && notOrtalamasi < 65)
            {
                Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: C1");
            }else if (notOrtalamasi >= 65 && notOrtalamasi < 70)
            {
                Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: B2");
            }else if (notOrtalamasi >= 70 && notOrtalamasi < 75)
            {
                Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: B1");
            }else if (notOrtalamasi >= 75 && notOrtalamasi < 85)
            {
                Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: A2");
            }else if (notOrtalamasi >= 85 && notOrtalamasi <= 100)
            {
                Console.WriteLine($"{dersAdi} dersi dönem sonu puanınız: A1");
            }
            else
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu (girilen notlar 0 il 100 arasında olmalıdır). Devam etmek için bir tuşa basın");
                Console.ReadLine();

                Console.Clear();

                goto baslangic; 
            }

            Console.WriteLine((notOrtalamasi >= 50) ? "GEÇTİNİZ" : "KALDINIZ");

            Console.Write("Başka bir ders notu hesaplamak ister misin? [E/H]: ");
            string bitis = Console.ReadLine();

            if (bitis == "e" || bitis=="E")
            {
                Console.Clear();
                goto baslangic;
            }
            else
            {
                Console.WriteLine("Çıkıiş yapmak için bir tuşa basınız");
            }

            Console.ReadLine();
        }
    }
}
