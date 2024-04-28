using System.Threading.Channels;

namespace Listeler
{
    internal class Program
    {
        static string Sor(string soru)
        {
            Console.Write(soru);
            return Console.ReadLine();
        }

        class Ogrenci
        {
            public string Cinsiyet { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
            public int Numara { get; set; }
            public DateTime DogumTarihi { get; set; }
        }

        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        static List<Ogrenci> OgrenciBul(string arananAd, int arananNumara, string arananCinsiyet) 
        {
            List<Ogrenci> bulunanOgrenciler = new List<Ogrenci>();

            foreach (var ogrenci in ogrenciler)
            {
                if (arananAd == ogrenci.Ad || arananNumara == ogrenci.Numara || arananCinsiyet == ogrenci.Cinsiyet)
                {
                    bulunanOgrenciler.Add(ogrenci);
                }
            }

            return bulunanOgrenciler;
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hoş geldiniz");
                Console.WriteLine("1 - Öğrencileri Listele");
                Console.WriteLine("2 - Öğrenci Ekle");
                Console.WriteLine("3 - Öğrenci Ara");
                Console.WriteLine("4 - Öğrenci Düzenle");
                Console.WriteLine("5 - Öğrenci Sil");
                Console.WriteLine("6 - Çıkış");

                int inputSecim = int.Parse(Sor("Seçimiz: "));
                   
                if (inputSecim == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Listesi");
                    foreach (Ogrenci ogrenci in ogrenciler)
                    {
                        Console.WriteLine($"{ogrenci.Cinsiyet} / {ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Yas} / {ogrenci.Numara} / {ogrenci.DogumTarihi.ToString("dd.MM.yyyy")}");
                    }
                    Console.Write(" 1 - Öğrenci Filtrele: ");
                    int filtre = int.Parse(Console.ReadLine());
                    
                    if(filtre == 1)
                    {
                        Console.Clear();
                        Console.Write("Nasıl filtreleme yapmak istersin?");
                        Console.WriteLine("\n 1 - Ad \n 2 - Cinsiyet");
                        Console.Write("Cevap: ");
                        int secımFiltre = int.Parse(Console.ReadLine());
                        
                        if(secımFiltre == 1)
                        {
                            string inputArananOgrenci = Sor("Adı: ");

                            List<Ogrenci> arananOgrenciler = OgrenciBul(inputArananOgrenci, -1, "");

                            if (arananOgrenciler.Count > 0)
                            {
                                Console.WriteLine("Öğrenciler bulundu:");
                                foreach (var ogrenci in arananOgrenciler)
                                {
                                    Console.WriteLine($"{ogrenci.Cinsiyet} / {ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Yas} / {ogrenci.Numara} / {ogrenci.DogumTarihi.ToString("dd.MM.yyyy")}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Böyle bir öğrenci yok!");
                            }
                        }
                        else if(secımFiltre == 2)
                        {
                            string inputCinsiyet = Sor("Öğrenci Cinsiyeti: ");

                            List<Ogrenci> arananOgrenciler = OgrenciBul("", - 1 , inputCinsiyet); 

                            if(arananOgrenciler.Count > 0)
                            {
                                foreach (var ogrenci in arananOgrenciler)
                                {
                                    Console.WriteLine($"{ogrenci.Cinsiyet} / {ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Yas} / {ogrenci.Numara} / {ogrenci.DogumTarihi.ToString("dd.MM.yyyy")}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Böyle bir öğrenci yok!");
                            }
                        }
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else if (inputSecim == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Ekle");
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Cinsiyet = Sor("Cinsiyet: ");
                    ogrenci.Ad = Sor("Ad: ");
                    ogrenci.Soyad = Sor("Soyad: ");
                    ogrenci.Yas = int.Parse(Sor("Yaş: "));
                    ogrenci.Numara = int.Parse(Sor("Öğrenci Numarası: "));
                    ogrenci.DogumTarihi = DateTime.Parse(Sor("Doğum Tarihi: "));

                    Console.WriteLine("Öğrenci Ekleme Başarılı...");
                    Console.ReadLine();

                    ogrenciler.Add(ogrenci);
                }
                else if (inputSecim == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Ara");

                    Console.WriteLine("\n 1 - Ad ile ara \n 2 - Numara ile ara");
                    Console.Write("Seçiminiz: ");
                    int secimarama = int.Parse(Console.ReadLine());

                    if(secimarama == 1) 
                    {
                        string inputArananOgrenci = Sor("Adı: ");

                        List<Ogrenci> arananOgrenciler = OgrenciBul(inputArananOgrenci, - 1,""); 

                        if (arananOgrenciler.Count > 0) 
                        {
                            foreach (var ogrenci in arananOgrenciler)
                            {
                                Console.WriteLine($"{ogrenci.Cinsiyet} / {ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Yas} / {ogrenci.Numara} / {ogrenci.DogumTarihi.ToString("dd.MM.yyyy")}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir öğrenci yok!");
                        }
                    }
                    else if (secimarama == 2)
                    {
                        
                        int arananNumara = int.Parse(Sor("Numara: "));

                        List<Ogrenci> arananOgrenciler = OgrenciBul("" , arananNumara , "");

                        if (arananOgrenciler.Count > 0)
                        {
                            foreach (var ogrenci in arananOgrenciler)
                            {
                                Console.WriteLine($"{ogrenci.Cinsiyet} / {ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Yas} / {ogrenci.Numara} / {ogrenci.DogumTarihi.ToString("dd.MM.yyyy")}");
                            }
                        }
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();

                }
                else if (inputSecim == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Düzenleme");

                    string inputArananOgrenci = Sor("Adı: ");

                    List<Ogrenci> arananOgrenciler = OgrenciBul(inputArananOgrenci, -1, "");

                    if (arananOgrenciler.Count > 0)
                    {
                        foreach (var ogrenci in arananOgrenciler)
                        {
                            Console.WriteLine($"{ogrenci.Cinsiyet} / {ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Yas} / {ogrenci.Numara} / {ogrenci.DogumTarihi.ToString("dd.MM.yyyy")}");
                        }

                        Console.WriteLine("Düzenlenecek halini yazın");
                        Ogrenci yeniOgrenci = new Ogrenci();

                        yeniOgrenci.Cinsiyet = Sor("Cinsiyet: ");
                        yeniOgrenci.Ad = Sor("Ad: ");
                        yeniOgrenci.Soyad = Sor("Soyad: ");
                        yeniOgrenci.Yas = int.Parse(Sor("Yaş: "));
                        yeniOgrenci.Numara = int.Parse(Sor("Öğrenci Numarası: "));
                        yeniOgrenci.DogumTarihi = DateTime.Parse(Sor("Doğum Tarihi: "));

                        ogrenciler.RemoveAll(ogrenci => arananOgrenciler.Contains(ogrenci));

                        ogrenciler.Add(yeniOgrenci);

                        Console.WriteLine("Öğrenci Düzenleme Başarılı...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir öğrenci yok!");
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else if (inputSecim == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Sil");

                    int arananNumara = int.Parse(Sor("Öğrenci Numarası (Eğer bilmiyorsanız '1' e basın): "));
                    
                    if (arananNumara == 1)
                    {
                        continue;
                    }
                    else
                    {
                        List<Ogrenci> arananOgrenciler = OgrenciBul("", arananNumara, "");

                        if (arananOgrenciler.Count > 0)
                        {
                            foreach (var ogrenci in arananOgrenciler)
                            {
                                Console.WriteLine($"{ogrenci.Cinsiyet} / {ogrenci.Ad} {ogrenci.Soyad} - {ogrenci.Yas} / {ogrenci.Numara} / {ogrenci.DogumTarihi.ToString("dd.MM.yyyy")}");
                            }
                            ogrenciler.RemoveAll(ogrenci => arananOgrenciler.Contains(ogrenci));

                            Console.WriteLine("Bu Öğrenci başarıyla silinmiştir!");
                        }
                        else
                        {
                            Console.WriteLine("Böyle bir öğrenci yok!");
                        }
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hoşçakalın...");
                    break;
                }   

            }

        }
    }
}