namespace DereceOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("şu an bulunduğunuz havanın derecesini giriniz : ");
            int derece = int.Parse(Console.ReadLine());

            Console.Clear();

            if (derece <= 18)
            {
                Console.WriteLine("                                   havalar oldukça soğuk size giyim önerimiz ; ");

                Console.WriteLine(" . Mont veya kalın ceket");
                Console.WriteLine(" . Kazak veya sweat");
                Console.WriteLine(" . Bot veya kalın tabanlı ayakkabı");

                Console.ReadLine();
            }
            if (derece <= 28)
            {
                Console.WriteLine("                                    havalar biraz serin size giyim önerimiz ; ");

                Console.WriteLine(" . Sweat veya hırka");
                Console.WriteLine(" . Pantolon veya eşofman");
                Console.WriteLine(" . Spor ayakkabı veya benzeri");

                Console.ReadLine();
            }
            if (derece <= 40)
            {
                Console.WriteLine("                                    havalar oldukça sıcak size giyim önerimiz ; ");

                Console.WriteLine(" . Tişört veya atlet");
                Console.WriteLine(" . Şort veya benzeri");
                Console.WriteLine(" . Spor ayakkabı veya terlik");

                Console.ReadLine();
            }
        }
    }
}
