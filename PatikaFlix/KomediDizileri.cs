using System;

namespace Patikaflix
{
    public class KomediDizisi
    {
        //bilgiler
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Yonetmen { get; set; }

        public KomediDizisi(string ad, string yonetmen)
        {
            Ad = ad;
            Tur = "Komedi";
            Yonetmen = yonetmen;
        }

        public override string ToString()
        {
            return $"Ad: {Ad} - Tür: {Tur} - Yönetmen: {Yonetmen}";
        }
    }
}