using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {/* ALGORİTMA 1
             Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
             Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
             Kullanıcını girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/

             Console.WriteLine("lütfen pozitif bi sayi giriniz");
             int sayi1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("lütfen " + sayi1 + " tane daha sayi giriniz.");
             int[] arrays = new int[sayi1];
             for (int i = 0; i < arrays.Length; i++) 
             {
                 arrays[i] = Convert.ToInt32(Console.ReadLine());  

             }
             Console.WriteLine("------çift sayılar------");
             for (int i = 0;i < arrays.Length; i++) {
                 if (arrays[i] % 2 == 0) { Console.WriteLine(arrays[i]); }
             }
             Console.ReadKey();  
        }
    }
}
