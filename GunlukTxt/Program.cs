﻿using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace GunlukTxt
{
    internal class Program
    {
       class Gunluk
       {
           public DateTime KayitTarihi { get; set; }
           public DateTime GuncellemeTarihi { get; set; }
           public string Aciklama { get; set; }
       }
        static List<Gunluk>gunlukler = new List<Gunluk>();
        static int siradakiKayit = 0;
        static void TxtKaydet()
        {
            using StreamWriter writer = new StreamWriter("Gunluk.txt");
            foreach ( var item in gunlukler)
            {
                writer.WriteLine($"{item.Aciklama} | {item.KayitTarihi.ToString("dd/MM/yyyy")}");
            }
        }
        static void GirisYap(bool ilkAcilisMi = false)
        {
            string kul_Adi = "polatturk.1";
            string kul_Sifre = "1212";

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("    Giriş Yap");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------");
            Console.ResetColor();

            Console.Write("Kullanıcı Adınız: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifreniz: ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == kul_Adi && sifre == kul_Sifre)
            {
                MenuGoster(true);
            }
            else
            {
                Console.WriteLine("\nKullanıcı adınız veya şifreniz yanlış!");
                Console.WriteLine("\nGirişe dönmek için bir tuşa basın");
                Console.ReadKey(true);
                Console.Clear();
                GirisYap();
            }
        }
        static void MenuGoster(bool ilkAcilisMi = false)
        {
            Console.Clear();

            if (ilkAcilisMi)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("        Hoş geldiniz");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("----------------------------");
            }
            Console.ResetColor();
            Console.WriteLine(" 1 - Kayıtları Listele \n 2 - Yeni Kayıt Ekle \n 3 - Tüm Kayıtları Sil \n 4 - Çıkış Yap");
            Console.Write("Seçiminiz: ");
            char inputSecim = Console.ReadKey().KeyChar;

            switch (inputSecim)
            {
                case '1':
                    KayitlariListele();
                    break;
                case '2':
                    YeniEkle();
                    break;
                case '3':
                    KayitlariSil();
                    break;
                case '4':
                    CikisYap();
                    break;
                default:
                    Console.WriteLine("\nböyle bir seçenek yok !!");
                    MenuyeDon();
                    MenuGoster();
                    break;
            }
        }
        static void MenuyeDon(bool ilkAcilisMi = false)
        {
            Console.WriteLine("\nMenüye dönmek için bir tuşa basın");
            Console.ReadKey(true);
            MenuGoster();
        }
        static void VerileriYukle()
        {
            using StreamReader reader = new StreamReader("Gunluk.txt");
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        static void KayitlariListele() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("    Tüm Kayıtlar");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-----------------------");
            Console.ResetColor();
            if (siradakiKayit < gunlukler.Count)
            {
                var gunluk = gunlukler[siradakiKayit++];
                Console.WriteLine($"- {gunluk.Aciklama} | {gunluk.KayitTarihi.ToString("dd/MM/yyyy")}\n");
            }
            else
            {
                siradakiKayit = 0;
                Console.WriteLine("Başka bir kayıt yok!");
            }
            Console.Write("(S)onraki Kayıt | (K)ayıt Güncelle | (A)na Menü | (D)üzenle | (x)Sil\n");
            Console.Write("\nİşleminiz: ");
            char islem = Console.ReadKey().KeyChar;

            switch (islem)
            {
                case 's':
                    KayitlariListele();
                    break;
                case 'k':
                    TarihGuncelle();
                    break;
                case 'a':
                    MenuGoster();
                    break;
                case 'd':
                    KayitDuzenle();
                    break;
                case 'x':
                    KayitlariSil();
                    break;
                default:
                    Console.WriteLine("\nböyle bir seçenek yok !!");
                    MenuyeDon();
                    MenuGoster();
                    break;
            }
            MenuyeDon();
        }
        static void KayitlariSil()
        {
            Console.Clear();
            Console.Write("Silmek istediğiniz kaydın numarasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int kayitNo) && kayitNo > 0 && kayitNo <= gunlukler.Count)
            {
                gunlukler.RemoveAt(kayitNo - 1);
                Console.WriteLine("Seçilen Kayıt silindi.");
                MenuyeDon();
                TxtKaydet();
            }
            else
            {
                Console.WriteLine("Geçersiz kayıt numarası!");
            }
            MenuyeDon();
        }
        static void TarihGuncelle()
        {
            Console.Clear();
            Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy")} Tarihinde Kayıt Tarihinizi Başarıyla Güncellediniz...");
        }
        static void CikisYap()
        {
            Console.Clear();
            Console.WriteLine("Hadi Eyvallah...");
            Environment.Exit(0);
        }
        static void KayitDuzenle()
        {
            Console.Clear();
            Console.Write("Düzenlemek istediğiniz kaydın numarasını girin: ");
            if (int.TryParse(Console.ReadLine(), out int kayitNo) && kayitNo > 0 && kayitNo <= gunlukler.Count)
            {
                Console.Write("Kaydınızın düzenlenmiş halini yazın: ");
                string duzenlenenKayit = Console.ReadLine();

                var duzenlenenGunluk = gunlukler[kayitNo - 1];
                duzenlenenGunluk.Aciklama = duzenlenenKayit;
                duzenlenenGunluk.GuncellemeTarihi = DateTime.Now;

                Console.WriteLine("\nKaydınız başarıyla düzenlenmiştir.");
                TxtKaydet();
            }
            MenuyeDon();
        }
        static DateTime sonEklenenTarih = DateTime.MinValue;
        static void YeniEkle()
        {
            Console.Clear();
            if (sonEklenenTarih.Date != DateTime.Now.Date)
            {
                Console.Write("Yeni kaydınızı yazınız: ");
                string eklemek = Console.ReadLine();

                Gunluk gunluk = new Gunluk();
                gunluk.Aciklama = eklemek;
                gunluk.KayitTarihi = DateTime.Now;
                gunluk.GuncellemeTarihi = DateTime.Now;
                gunlukler.Add(gunluk);
                Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy")} Tarihinde Kayıt eklendi.");

                sonEklenenTarih = DateTime.Now.Date;
                TxtKaydet();
            }
            else
            {
                Console.WriteLine("Bugün günlük kaydı girdin, aynı tarihte yeni bir kayıt eklemek ister misin?");
                Console.WriteLine("(E)vet | (H)ayır");
                Console.Write("\nCevabınız: ");
                char kayitCevap = Console.ReadKey().KeyChar;

                if (kayitCevap == 'e' || kayitCevap == 'E') 
                {
                    Console.Clear();
                    Console.Write("Yeni kaydınızı yazınız: ");
                    string eklemek = Console.ReadLine();

                    Gunluk gunluk = new Gunluk();
                    gunluk.Aciklama = eklemek;
                    gunluk.KayitTarihi = DateTime.Now;
                    gunluk.GuncellemeTarihi = DateTime.Now;
                    gunlukler.Add(gunluk);
                    Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy")} Tarihinde Kayıt eklendi.");

                    sonEklenenTarih = DateTime.Now.Date;
                    TxtKaydet();
                }
                else if( kayitCevap == 'h' || kayitCevap == 'H')
                {
                    MenuyeDon();
                }
            }
            MenuyeDon();
        }
        static void Main(string[] args)
        {
            GirisYap();
            VerileriYukle();
        }
    }
}
