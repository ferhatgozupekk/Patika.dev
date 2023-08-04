using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.DayOfWeek);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortDateString());



            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            //DATETİME FORMAT
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("MM")); //VS 

            //MATH KÜTÜPHANESİ

            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10)); // cos tan 

            //round yuvarlama
            Console.WriteLine(Math.Round(25.43));

            // floor alta yuvarlama ceiling üste yuvarlama

            //pow  sqrt
            Console.WriteLine(Math.Pow(3,4)); //3^4
            Console.WriteLine(Math.Sqrt(9)); // karekök alr = 3
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki log karşılığını getirir.
            Console.WriteLine(Math.Exp(3)); // e üzeir 3 verir
            Console.WriteLine(Math.Log10(10)); // 10 sayısının log 10 tabanındaki karşılığı




            Console.ReadKey();
        }
    }
}
