using System;
using System.Collections.Generic;

namespace OgrenciBakiyeTakip
{
    class Program
    {
        static Dictionary<string, double> ogrenciBakiyeleri = new Dictionary<string, double>();

        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Bakiye Takip Programına Hoş Geldiniz!");

            while (true)
            {
                Console.WriteLine("\n1 - Yeni Öğrenci Ekle");
                Console.WriteLine("2 - Bakiye Görüntüle");
                Console.WriteLine("3 - Bakiye Ekle");
                Console.WriteLine("4 - Bakiye Çıkar");
                Console.WriteLine("5 - Çıkış");
                Console.Write("Seçiminizi yapın: ");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        EkleOgrenci();
                        break;
                    case 2:
                        GosterBakiye();
                        break;
                    case 3:
                        EkleBakiye();
                        break;
                    case 4:
                        CikarBakiye();
                        break;
                    case 5:
                        Console.WriteLine("Programdan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                        break;
                }
            }
        }

        static void EkleOgrenci()
        {
            Console.Write("Öğrenci adını girin: ");
            string ad = Console.ReadLine();

            if (!ogrenciBakiyeleri.ContainsKey(ad))
            {
                Console.Write($"{ad} öğrencisinin başlangıç bakiyesini girin: ");
                double bakiye = Convert.ToDouble(Console.ReadLine());

                ogrenciBakiyeleri.Add(ad, bakiye);
                Console.WriteLine($"{ad} öğrencisi eklendi.");
            }
            else
            {
                Console.WriteLine($"{ad} öğrencisi zaten var.");
            }
        }

        static void GosterBakiye()
        {
            Console.Write("Öğrenci adını girin: ");
            string ad = Console.ReadLine();

            if (ogrenciBakiyeleri.ContainsKey(ad))
            {
                double bakiye = ogrenciBakiyeleri[ad];
                Console.WriteLine($"{ad} öğrencisinin bakiyesi: {bakiye} TL");
            }
            else
            {
                Console.WriteLine($"{ad} öğrencisi bulunamadı.");
            }
        }

        static void EkleBakiye()
        {
            Console.Write("Öğrenci adını girin: ");
            string ad = Console.ReadLine();

            if (ogrenciBakiyeleri.ContainsKey(ad))
            {
                Console.Write($"Ne kadar bakiye eklemek istiyorsunuz?: ");
                double eklenecekBakiye = Convert.ToDouble(Console.ReadLine());

                ogrenciBakiyeleri[ad] += eklenecekBakiye;
                Console.WriteLine($"{ad} öğrencisinin bakiyesine {eklenecekBakiye} TL eklendi. Yeni bakiye: {ogrenciBakiyeleri[ad]} TL");
            }
            else
            {
                Console.WriteLine($"{ad} öğrencisi bulunamadı.");
            }
        }

        static void CikarBakiye()
        {
            Console.Write("Öğrenci adını girin: ");
            string ad = Console.ReadLine();

            if (ogrenciBakiyeleri.ContainsKey(ad))
            {
                Console.Write($"Ne kadar bakiye çıkarmak istiyorsunuz?: ");
                double cikarilacakBakiye = Convert.ToDouble(Console.ReadLine());

                if (ogrenciBakiyeleri[ad] >= cikarilacakBakiye)
                {
                    ogrenciBakiyeleri[ad] -= cikarilacakBakiye;
                    Console.WriteLine($"{ad} öğrencisinin bakiyesinden {cikarilacakBakiye} TL çıkarıldı. Yeni bakiye: {ogrenciBakiyeleri[ad]} TL");
                }
                else
                {
                    Console.WriteLine($"{ad} öğrencisinin bakiyesi yetersiz.");
                }
            }
            else
            {
                Console.WriteLine($"{ad} öğrencisi bulunamadı.");
            }
        }
    }
}
