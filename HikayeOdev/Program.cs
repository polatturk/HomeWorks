namespace HikayeOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("MERHABALAR HİKAYEYE HOŞGELDİNİZ");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("Ben Polat saat 23:30 evde çok sıkıldım ve gece yürüyüşüne çıkmak istiyorum nereye gideyim? ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("A - Ormana");
            Console.WriteLine("B - Sahile");

            Console.Write("CEVAP : ");
            
            string secim1 = Console.ReadLine();
            Console.Clear();

            if(secim1 == "a" || secim1 == "A")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Ormana geldim burası çok sessiz gece yürüyüşü biraz korkutucu");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("A - Devam et!");
                Console.WriteLine("B - Geri dön!");

                Console.Write("CEVAP : ");

                string secimOrman = Console.ReadLine();
                Console.Clear();

                if(secimOrman == "a" || secimOrman == "A")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Bence de devam etmeliyim,asıl eğlence şimdi başlıyor.Hem en kötü ne olabilir ki? Şu ağaçların arasından gideyim bari...Eyvah bir ses duydum neyse ki yanıma silahımı almıştım.");

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("A - Silahını çek ve yürümeye devam et");
                    Console.WriteLine("B - Bulunduğun yerden biraz uzaklaş farklı yollara gir");

                    Console.Write("CEVAP : ");

                    string secimOrman1 = Console.ReadLine();
                    Console.Clear();

                    if(secimOrman1 == "a" || secimOrman1 == "A")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Karşıma birisi çıkıp bana saldırmaya kalktı bende vurdum onu katil yaptın beni!!");
                        Console.ReadLine();
                    }
                    if (secimOrman1 == "b" || secimOrman1 == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Yolumu değiştirip biraz daha yürüdükten sonra eve gittim rehberlik için teşekkürler...");
                        Console.ReadLine();
                    }
                }
                if(secimOrman == "b" || secimOrman== "B")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Sende amma korkak çıktın! hemen eve yolladın beni. Al işte evdeyim oldu mu?");
                    Console.ReadLine();
                }

            }
            if (secim1 == "b" || secim1 == "B")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Sahile geldim burda hava çok güzel acaba şarkı mı dinlesem yoksa denizin güzel sesiyle mi yürüyüşüme devam etsem ?");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("A - Kulaklığı takıp şarkı dinle");
                Console.WriteLine("B - Deniz sesinin keyfini çıkar");

                Console.Write("CEVAP : ");

                string secimsahil = Console.ReadLine();
                Console.Clear();

                if (secimsahil == "a" || secimsahil == "A")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Bu güzel fikirmiş en sevdiğim şarkılarımı açtım...");
                    Console.ReadLine();
                }
                if(secimsahil =="b" || secimsahil=="B")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("denizin sesi,insanların sesi derken yanıma yürüyüş yapan birisi tanışmak için geldi...");

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("A - Tanış onunla");
                    Console.WriteLine("B - Tanışma yürüyüşüne devam et");

                    Console.Write("CEVAP : ");

                    string secimsahil2 = Console.ReadLine();
                    Console.Clear();

                    if(secimsahil2 == "a" || secimsahil2 == "A")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Gelen yabancıyla tanıştım sayende yürüyüş yaparken arkadaş edindim...");
                        Console.ReadLine();
                    }
                    if (secimsahil2 == "b" || secimsahil2 == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Kendi halimde Takıldım zaten ne gerek vardı ki? Neyse bu kadar yürüyüş yeterli eve dönme vakti...");
                        Console.ReadLine();
                    }
                }


            }

        }
    }
}

