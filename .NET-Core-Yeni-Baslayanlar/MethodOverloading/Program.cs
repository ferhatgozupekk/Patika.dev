using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        class Metotlar
        {
            public void Topla ( int a , int b , out int toplam)
            {
                toplam = a + b;
            }
            public void ekranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }                                               //overload
            public void ekranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
        }
        static void Main(string[] args)
        {
            // out paramatreler
            string sayi = "999";


            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(sayi);
            }
            else
            {
                Console.WriteLine("başarısız");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            // metot overloading
            int ifade = 999;
            instance.ekranaYazdir(12);
        }               
    }
}
