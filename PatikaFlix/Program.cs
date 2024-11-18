using System;
using System.Collections.Generic;
using System.Linq;

namespace Patikaflix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<Dizi> diziListesi = new List<Dizi>
            {
                //dizi listesi
                new Dizi("Avrupa Yakası", 2004, "Komedi", 2004, "Yüksel Aksu", "Kanal D"),
                new Dizi("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"),
                new Dizi("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"),
                new Dizi("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"),
                new Dizi("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"),
                new Dizi("Arka Sokaklar", 2004, "Polisiye, Dram", 2004, "Orhan Oğuz", "Kanal D"),
                new Dizi("Aşk-ı Memnu", 2008, "Dram, Romantik", 2008, "Hilal Saral", "Kanal D"),
                new Dizi("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", 2011, "Mercan Çilingiroğlu", "Star TV"),
                new Dizi("Yaprak Dökümü", 2006, "Dram", 2006, "Serdar Akar", "Kanal D")
            };

            Console.WriteLine("Patikaflix'e Hoş Geldiniz!");
            while (true)
            {
                //bilgi yazdırma ve alma
                Console.Write("Dizi Adı: ");
                string ad = Console.ReadLine();
                Console.Write("Yayına Başladığı Yıl: ");
                if (!int.TryParse(Console.ReadLine(), out int baslangicYili))
                {
                    Console.WriteLine("Geçersiz yıl girdiniz. Lütfen tekrar deneyin.");
                    continue;
                }
                Console.Write("Tür: ");
                string tur = Console.ReadLine();
                Console.Write("Yayın Yılı: ");
                if (!int.TryParse(Console.ReadLine(), out int yayinYili))
                {
                    Console.WriteLine("Geçersiz yıl girdiniz. Lütfen tekrar deneyin.");
                    continue;
                }
                Console.Write("Yönetmen: ");
                string yonetmen = Console.ReadLine();
                Console.Write("Platform: ");
                string platform = Console.ReadLine();

                diziListesi.Add(new Dizi(ad, baslangicYili, tur, yayinYili, yonetmen, platform));

                Console.WriteLine("Dizi eklendi. Başka bir dizi eklemek istiyor musunuz? (E/H)");
                string devam = Console.ReadLine();
                if (devam.ToUpper() != "E")
                {
                    break;
                }
            }

            // Komedi dizilerini filtreleyip ekrana yazdırıyoruz.
            var komediDizileri = diziListesi
                .Where(d => d.Tur.Contains("Komedi"))
                .Select(d => new KomediDizisi(d.Ad, d.Yonetmen))
                .ToList();

            Console.WriteLine("Komedi Dizileri:");
            foreach (KomediDizisi komedi in komediDizileri)
            {
                Console.WriteLine(komedi);
            }
            Console.WriteLine("<------------------------------------------------------------------------------------->");

            Console.WriteLine("Tüm Diziler:");
            diziListesi
                .OrderBy(d => d.Ad)
                .ThenBy(d => d.Yonetmen)
                .ToList()
                .ForEach(d => Console.WriteLine(d));
        }
    }

    class Dizi
    {
        //Dizi hakkında bilgiler
        public string Ad { get; set; }
        public int BaslangicYili { get; set; }
        public string Tur { get; set; }
        public int YayinYili { get; set; }
        public string Yonetmen { get; set; }
        public string Platform { get; set; }

        public Dizi(string ad, int baslangicYili, string tur, int yayinYili, string yonetmen, string platform)
        {
            Ad = ad;
            BaslangicYili = baslangicYili;
            Tur = tur;
            YayinYili = yayinYili;
            Yonetmen = yonetmen;
            Platform = platform;
        }

        public override string ToString()
        {
            return $"{Ad}, {BaslangicYili}, {Tur}, {YayinYili}, {Yonetmen}, {Platform}";
        }
    }

    class KomediDizisi
    {
        public string Ad { get; set; }
        public string Yonetmen { get; set; }

        public KomediDizisi(string ad, string yonetmen)
        {
            Ad = ad;
            Yonetmen = yonetmen;
        }

        public override string ToString()
        {
            return $"{Ad}, {Yonetmen}";
        }
    }
}