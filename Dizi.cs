using System;

namespace Patikaflix;

public class Dizi
{
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
        return $"Ad: {Ad} - Başlangıç Yılı: {BaslangicYili} - Tür: {Tur} - Yayın Yılı: {YayinYili} - Yönetmen: {Yonetmen} - Platform: {Platform}";
    }
}