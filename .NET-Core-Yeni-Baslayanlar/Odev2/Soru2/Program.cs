using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Soru2
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            
            int[] sayılar = new int[6];
            int sayi;
            int ortalama1 = 0;
            int ortalama2 = 0;

            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine("sayı girin:");
                sayi = int.Parse(Console.ReadLine());
                sayılar[i] = sayi;
            }
            Array.Sort(sayılar);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("En küçük elemanlar: {}" , sayılar[i]);
                ortalama1 += sayılar[i];
            }
            ortalama1 = ortalama1 / 3;
            Console.WriteLine("kücük sayıların ortalaması: {}", ortalama1);

            Console.WriteLine("------------------------------------------");

            for (int i = sayılar.Length-3 ; i < sayılar.Length; i++)
            {
                Console.WriteLine("En büyük elemanlar: {}", sayılar[i]);
                ortalama2 += sayılar[i];
            }
            ortalama2 = ortalama2 / 3;
            Console.WriteLine("büyük sayıların ortalaması: {}", ortalama2);
            Console.WriteLine("ortalamaların toplamı : {}", ortalama1 + ortalama2);
            Console.ReadKey();  







        }
    }
}
