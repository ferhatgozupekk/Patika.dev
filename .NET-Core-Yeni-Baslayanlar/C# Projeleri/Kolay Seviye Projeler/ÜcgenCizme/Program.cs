using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜcgenCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ücgenin Boyutunu giriniz");
            int secim = int.Parse(Console.ReadLine());

            for (int i = 1; i <= secim; i++)
            { 
                for ( int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
