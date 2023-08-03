using System;
namespace TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion ( bilinçli dönüşüm)
            byte a = 1; 
            sbyte b = 2;    
            short sshort = 3;
            int d = a + b + sshort; 
            Console.WriteLine("d" + d);

            string asd = "sdfsd";
            Console.WriteLine(asd + d);

            //explicit converison ( bilinçsiz dönüşüm)

            int x = 12;
            byte y = (byte)x;
            Console.WriteLine(y);

            //to string methodu
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            //system.convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            //parse methodu
            Console.WriteLine("parse methodu");
            ParseMethod();




        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.20";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);   
            double1 =Double.Parse(metin2);

            Console.WriteLine(rakam1);  
            Console.WriteLine(double1); 

        }
    }
}