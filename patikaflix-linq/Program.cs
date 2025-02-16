using System;
using System.Collections.Generic;

class Dizi
{
    public string Adi { get; set; }
    public int YapimYili { get; set; }
    public string Turu { get; set; }
    public int YayinlanmayaBaslamaYili { get; set; }
    public string Yonetenler { get; set; }
    public string IlkPlatform { get; set; }
}

class KomediDizi
{
    public string Adi { get; set; }
    public string Turu { get; set; }
    public string Yonetenler { get; set; }
}

class Program
{
    static void Main()
    {
        // Diziler listesini tanımlıyoruz.
        List<Dizi> diziler = new List<Dizi>();

        Console.WriteLine("Dizi bilgilerini girmek için aşağıdaki adımları takip edin.");

        while (true)
        {
            Dizi yeniDizi = new Dizi();

            Console.Write("Dizi Adı: ");
            yeniDizi.Adi = Console.ReadLine();

            Console.Write("Yapım Yılı: ");
            yeniDizi.YapimYili = Convert.ToInt32(Console.ReadLine());

            Console.Write("Türü: ");
            yeniDizi.Turu = Console.ReadLine();

            Console.Write("Yayınlanmaya Başlama Yılı: ");
            yeniDizi.YayinlanmayaBaslamaYili = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yönetmenler: ");
            yeniDizi.Yonetenler = Console.ReadLine();

            Console.Write("İlk Platform: ");
            yeniDizi.IlkPlatform = Console.ReadLine();

            // Yeni diziyi listeye ekliyoruz.
            diziler.Add(yeniDizi);

            Console.Write("Başka bir dizi eklemek ister misiniz? (e/h): ");
            string devam = Console.ReadLine();
            if (devam.ToLower() != "e")
            {
                break; // Kullanıcı "e" dışında bir şey gelirse döngüyü durdur.
            }
        }

        // Komedi dizilerini tutacak listeyi tanımlıyoruz.
        List<KomediDizi> komediDizileri = new List<KomediDizi>();

        // Diziler listesinden komedi dizilerini ayıklıyoruz.
        foreach (var dizi in diziler)
        {
            if (dizi.Turu.ToLower() == "komedi") // Türü "komedi" olanları alıyoruz.
            {
                KomediDizi yeniKomediDizi = new KomediDizi
                {
                    Adi = dizi.Adi,
                    Turu = dizi.Turu,
                    Yonetenler = dizi.Yonetenler
                };
                komediDizileri.Add(yeniKomediDizi);
            }
        }

        // Komedi dizilerini ekrana yazdırıyoruz.
        Console.WriteLine("\nEklenen Komedi Dizileri:");
        foreach (var komediDizi in komediDizileri)
        {
            Console.WriteLine($"Dizi Adı: {komediDizi.Adi}, Türü: {komediDizi.Turu}, Yönetmenler: {komediDizi.Yonetenler}");
        }
    }
}
