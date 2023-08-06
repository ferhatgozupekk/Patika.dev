using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir ifade giriniz: ");
            string cümle = Console.ReadLine().ToLower();
            char[] sesliharfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            string[] son = new string[cümle.Length];

            int sayac = 0;

            foreach (var item in cümle)
            {
                foreach (var item1 in sesliharfler)
                {
                    if (item == item1)
                    {
                        sayac++;
                        son[sayac] = item.ToString();
                    }
                }
            }

            foreach (var item in son)
            {
                Console.WriteLine(item);
                Console.WriteLine("---");
            }
            Console.ReadKey();  


        }
    }
}
