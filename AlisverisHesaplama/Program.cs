namespace AlisverisHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v1
            //double toplamFiyat = 0;
            //string[] urunler = ["Ayçiçek Yağı", "Ton Balığı", "Süt", "Çay"];
            //double[] fiyatlar = [210, 79.50, 64.90, 199];

            //Console.WriteLine("                                             Alışveriş Hesaplamasına Hoş Geldiniz...");
            //Console.WriteLine("========================================================================================================================");
            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} {urunler[i]} - {fiyatlar[i]}" + " TL ");
            //}
            //Console.WriteLine("========================================================================================================================");
            //while (true)
            //{
            //    Console.Write("Lütfen Almak İstediğiniz Ürünü Seçin ( T - Toplamı Göster): ");
            //    string secim = Console.ReadLine();

            //    if (secim == "1")
            //    {
            //        Console.WriteLine("Ürün Sepetinize eklendi");
            //        Console.WriteLine(fiyatlar[0] + " TL ");
            //        toplamFiyat += fiyatlar[0];
            //    }
            //    else if (secim == "2") 
            //    {
            //        Console.WriteLine("Ürün Sepetinize eklendi");
            //        Console.WriteLine(fiyatlar[1] + " TL ");
            //        toplamFiyat += fiyatlar[1];
            //    }
            //    else if (secim == "3")
            //    {
            //        Console.WriteLine("Ürün Sepetinize eklendi");
            //        Console.WriteLine(fiyatlar[2] + " TL ");
            //        toplamFiyat += fiyatlar[2];
            //    }
            //    else if (secim == "4")
            //    {
            //        Console.WriteLine("Ürün Sepetinize eklendi");
            //        Console.WriteLine(fiyatlar[3] + " TL ");
            //        toplamFiyat += fiyatlar[3];
            //    }
            //    if (secim == "t" || secim == "T")
            //    {
            //        Console.Write("Toplam Sepet Tutarınız :  " + toplamFiyat );
            //        break;

            //    }
            //}

            //v2

            Console.WriteLine("                                             Alışveriş Hesaplamasına Hoş Geldiniz...");
            Console.WriteLine("========================================================================================================================");
            string[] urunler = ["Ayçiçek Yağı", "Ton Balığı", "Süt", "Çay", "Taze Kaşar", "Beyaz Peynir", "Yoğurt", "Kangal Sucuk", "Turşu", "Patates Kg"];
            double[] fiyatlar = [210, 79.50, 64.90, 199, 149.50, 99, 47, 150, 32.90, 15.75];

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i + 1} {urunler[i]} - {fiyatlar[i]}" + " TL ");
            }

            Console.WriteLine("========================================================================================================================");

            Console.Write("Kaç adet ürün almak istediğinizi giriniz: ");
            int adet = int.Parse(Console.ReadLine());

            double toplamTutar = 0;

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"Ürün {i + 1} seçiniz: ");
                int secilenUrun = int.Parse(Console.ReadLine());

                if(secilenUrun > 0 && secilenUrun <= urunler.Length)
                {
                    Console.Write($" {urunler[secilenUrun - 1]} Eklediniz | ");

                    double toplamFiyat = fiyatlar[secilenUrun -1];
                    Console.Write($"Toplam Fiyat: {toplamFiyat} TL\n");

                    toplamTutar += toplamFiyat;
                }
                else
                {
                    Console.WriteLine("Geçersiz ürün numarası girdiniz!");
                    i--; 
                }
            }

            Console.WriteLine($"Toplam Tutar: {toplamTutar} TL");

            //v3

            double paraUstu = 0;
            Console.WriteLine("========================================================================================================================");

            Console.WriteLine(" 1 - Nakit Ödeme ");
            Console.WriteLine(" 2 - Kredi Kartı Ödeme");
            Console.Write("Ödeme Yönteminizi Seçiniz : ");
            int odeme = int.Parse(Console.ReadLine());

            Console.Write("Ödeme tutarını giriniz : ");
            int girilentutar = int.Parse(Console.ReadLine());

            paraUstu = girilentutar - toplamTutar;
            while (true)
            {

                if (odeme == 1)
                {
                    if (girilentutar < toplamTutar)
                    {
                        Console.WriteLine("Eksik tutar girdiniz Ödeme Başarısız!");
                        break;
                    }

                    Console.WriteLine("Nakit ödemesi alındı");
                    Console.Write($"para üstü : {paraUstu} TL");
                    break;

                }
                if (odeme == 2)
                {
                    if (girilentutar < toplamTutar)
                    {
                        Console.WriteLine("Kart Bakiyeniz Yetersiz Ödeme Başarısız!");
                        break;
                    }

                    Console.WriteLine("Kredi Kartı Ödemesi alındı");
                    Console.Write($"para üstü : {paraUstu} TL");
                    break;
                }


            }
        }
    }
}
