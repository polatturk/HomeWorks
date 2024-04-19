using System.ComponentModel.Design;

namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v1
            //Console.Write("kaç adet rakam toplamak istiyorsunuz?: ");
            //double inputadet = double.Parse(Console.ReadLine());

            //double toplam = 0;

            //for (int i = 1; i <= inputadet; i++)
            //{
            //    Console.Write(i + ".rakam: ");
            //    toplam += double.Parse(Console.ReadLine());
            //}

            //double ortalama = toplam / inputadet;

            //Console.WriteLine("toplam: " + toplam);
            //Console.WriteLine("ortalama: " + ortalama);

            //v2

            Console.WriteLine("                                              HESAP MAKİNESİNE HOŞGELDİNİZ..");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n1) Toplama \n2) Çıkarma \n3) Çarpma \n4) Bölme");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.Write("işleminizi buraya giriniz: ");
            int islem = int.Parse(Console.ReadLine());

          while(true) 
          {

            if (islem >= 5)
            {
                Console.WriteLine("uygulama sonlandırılıyor...");
                break;
            }
            
            Console.Write("kaç adet rakam ile işlem yapacaksınız?: ");
            int adet = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            //v3
            int cevap = 0;

            if (islem == 1)
            {
                for (int i = 1; i <= adet; i++)
                {
                    Console.Write(i + ".rakam: ");
                    cevap += int.Parse(Console.ReadLine());
                }
                Console.WriteLine("sonuç: " + cevap);
            }
            else if (islem == 2)
            {
                Console.Write("1.rakam: ");
                cevap = int.Parse(Console.ReadLine());

                for (int i = 2; i <= adet; i++)
                {
                    Console.Write(i + ".rakam: ");
                    cevap -= int.Parse(Console.ReadLine());
                }
                Console.WriteLine("sonuç : " + cevap);
            }
            else if (islem == 3)
            {
                Console.Write("1.rakam: ");
                cevap = int.Parse(Console.ReadLine());

                for (int i = 2; i <= adet; i++)
                {
                    Console.Write(i + ".rakam: ");
                    cevap *= int.Parse(Console.ReadLine());

                }
                Console.WriteLine("sonuç : " + cevap);
            }
            else if (islem == 4)
            {
                Console.Write("1.rakam: ");
                cevap = int.Parse(Console.ReadLine());

                for (int i = 2; i <= adet; i++)
                {
                    Console.Write(i + ".rakam: ");
                    cevap /= int.Parse(Console.ReadLine());

                }
                Console.WriteLine("sonuç : " + cevap);
            }

          }

        }
    }
}
