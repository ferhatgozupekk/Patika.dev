namespace Loops_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlayarak konsoldan girilen sayıya kadar  sayı dahil ortalama hesaplayıp console a yazdıran program
            Console.WriteLine("lütfen bir sayi girinmiz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;


            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;

            }
            Console.WriteLine(toplam / sayi);

            char c = 'a';   
            while (c < 'z') {
            Console.WriteLine(c);   
                c++;    
            }

            Console.WriteLine("foreach");
            string[] arabalar = { "bmw", "toyota", "asdfsda" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}