namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ekrana girilen sayıya kadar tek sayıları ekrana yazdır
            Console.WriteLine("lütfen bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;    
                }

            }
            Console.WriteLine("1000 e kadar olan tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("1000 e kadar olan cift sayıların toplamı: " + ciftToplam);




            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
        }
    }
}