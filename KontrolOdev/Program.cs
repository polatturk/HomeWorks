namespace KontrolOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kontrol1 = "polatturk.1";
            string kontrol2 = "polat123";

            Console.Write("Kullanıcı Adınız : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifreniz : ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == kontrol1 && sifre == kontrol2) 
            {
                Console.WriteLine("Hoşgeldiniz...");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Hatalı kullanıcı adı veya şifre girdiniz Lütfen tekrar deneyiniz!");
                Console.ReadLine();
            }

        }
    }
}
