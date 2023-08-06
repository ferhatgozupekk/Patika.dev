using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSyaılar = new ArrayList();
            ArrayList asalOlmayanSyaılar = new ArrayList();
            double ortalama_asal = 0;
            double ortalama_olmayan = 0;

            string sayi;
            int sayac = 0;

            for (int i = 0; i < 20
                ; i++)
            {
                Console.WriteLine("Sayı giriniz:");
                sayi = Console.ReadLine();
                if (int.TryParse(sayi, out int result) && result > 0)
                {
                    for (int j = 1; j <= result; j++)
                    {
                        if (result % j == 0)
                        {
                            sayac ++;
                        }         
                    }

                    if (sayac == 2 )
                    {
                        asalSyaılar.Add(result);
                    }
                    else
                    {
                        asalOlmayanSyaılar.Add(result);
                    }
                    sayac = 0;
                }
                else
                {
                    Console.WriteLine("hatalı giriş yaptınız.");
                    i--;
                }
            }

            if (asalSyaılar.Count > 0)
                {
                    Console.WriteLine("*** ASAL SAYILAR ***");

                    for (int j = 0; j < asalSyaılar.Count; j++)
                    {
                        ortalama_asal += Convert.ToDouble(asalSyaılar[j]);
                        Console.WriteLine(asalSyaılar[j]);  
                    }
                    ortalama_asal = ortalama_asal / asalSyaılar.Count;
                    Console.WriteLine("ekrana girdiğiniz asal sayıların ortalaması : {0}", ortalama_asal);
                    Console.WriteLine("eleman sayısı : {0}", asalSyaılar.Count);
                }

                if (asalOlmayanSyaılar.Count > 0)
                {
                    Console.WriteLine("*** ASAL OLMAYAN SAYILAR ***");

                    for(int j = 0; j < asalOlmayanSyaılar.Count; j++)
                    {
                        ortalama_olmayan += Convert.ToDouble(asalOlmayanSyaılar[j]);
                        Console.WriteLine(asalOlmayanSyaılar[j]);   
                    }
                    ortalama_olmayan = ortalama_olmayan / asalOlmayanSyaılar.Count;
                    Console.WriteLine("ekrana girdiğiniz asal olmayan sayıların ortalaması : {0}", ortalama_olmayan);
                    Console.WriteLine("eleman sayısı : {0}", asalOlmayanSyaılar.Count);
                }
                
                Console.ReadKey();

              
            
        }
    }
}
