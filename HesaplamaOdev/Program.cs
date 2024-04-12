namespace HesaplamaOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int siparistutar = 350;

            Console.Write("sipariş tutarını giriniz : ");
            int girilentutar = int.Parse(Console.ReadLine());

            if (girilentutar < 350)
            {
                Console.WriteLine("Eksik tutar girdiniz!!");
                Console.ReadLine();
            }

            Console.WriteLine(" 1 - Nakit Ödeme ");
            Console.WriteLine(" 2 - Kredi Kartı Ödeme");

            int odeme = int.Parse(Console.ReadLine());

            int kalan = girilentutar - siparistutar;
            
            Console.Clear();

            if(odeme == 1)
            {
                Console.WriteLine("Nakit ödemesi alındı");
                Console.Write("para üstü : " + kalan + " TL" );
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Kredi Kartı Ödemesi alındı");
                Console.ReadLine();
            }
        }
    }
}
