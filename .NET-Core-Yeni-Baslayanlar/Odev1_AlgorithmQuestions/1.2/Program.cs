using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ALGORİTMA 2
            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/

            Console.WriteLine("lütfen sayı listesinin uzunluğunu giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen sayı listesindeki her bir elemanı tek tek bölecek  sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen " + sayi1 + " adet daha pozitif tam sayi giriniz ");
            int[] sayilar = new int[sayi1];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("girmiş olduğunuz bölen sayısına eşit veya tam bölünen liste içindeki sayılar ");
            for (int i = 0;i < sayilar.Length; i++) 
            {
                if (sayilar[i] == sayi2 || sayilar[i] % sayi2 == 0 )
                {
                    Console.WriteLine(sayilar[i]);
                }

            }
            Console.ReadLine();
        }
    }
}
