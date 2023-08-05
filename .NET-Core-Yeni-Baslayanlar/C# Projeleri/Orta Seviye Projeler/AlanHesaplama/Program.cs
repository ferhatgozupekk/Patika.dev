using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Program
    {
        public static void AlanHesapla( double secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("Dairenin çapını giriniz");
                double yarıCap = double.Parse(Console.ReadLine());
                double alan = DaireAlan(yarıCap);

                Console.WriteLine("Dairenin alanı: {0}",alan );
            } 
            else if (secim == 2) 
            {
                Console.WriteLine("Dikdörtgenin kısa kenarını giriniz");
                double kısaKenar = double.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin uzun kenarını giriniz");
                double uzunKenar= double.Parse(Console.ReadLine());
                double alan = DikdortgenAlan(kısaKenar,uzunKenar);

                Console.WriteLine("Dikdörtgenin alanı: {0}", alan);
            }
            else if (secim == 3 )
            {
                Console.WriteLine("kenar giriniz");
                double kenar = double.Parse(Console.ReadLine());
                
                double alan = KareAlan(kenar);

                Console.WriteLine("Karenin alanı: {0}", alan);
            }
            else if (secim == 4)
            {
                Console.WriteLine("Taban giriniz");
                double taban = double.Parse(Console.ReadLine());
                Console.Write("Yükseklik giriniz: ");
                double yukseklik= double.Parse(Console.ReadLine());

                double alan = UcgenAlan(taban,yukseklik);

                Console.WriteLine("Üçgenin alanı: {0}", alan);
            }
            else
            {
                Console.Write("Hatalı giriş yaptınız");
            }
        }
        public static void CevreHesapla(double secim)
        {
            double cevre;
            if (secim == 1 )
            {
                Console.Write("Çap giriniz: ");
                double cap = double.Parse(Console.ReadLine());
                cevre = DaireCevre(cap);

                Console.WriteLine("Dairenin çevresi: " + cevre);
            }
            else if (secim == 2)
            {
                Console.Write("Kısa kenarı giriniz: ");
                double kısaKenar = double.Parse(Console.ReadLine());
                Console.WriteLine("Uzun kenarı giriniz: ");
                double uzunKenar = double.Parse(Console.ReadLine());
                cevre = DikdortgenCevre(kısaKenar, uzunKenar);

                Console.WriteLine("Dikdörtgenin çevresi: " + cevre);
            }
            else if (secim == 3)
            {
                Console.Write(" kenar giriniz: ");
                double kenar = double.Parse(Console.ReadLine());
                cevre = KareCevre(kenar);

                Console.WriteLine("Karenin çevresi: " + cevre);
            }
            else if (secim == 2)
            {
                Console.Write("Taban giriniz: ");
                double taban = double.Parse(Console.ReadLine());
                Console.WriteLine("Yükseklik giriniz: ");
                double yukseklik = double.Parse(Console.ReadLine());
                Console.WriteLine("Kenar giriniz: ");
                double kenar = double.Parse(Console.ReadLine());
                cevre = UcgenCevre(taban, yukseklik, kenar);

                Console.WriteLine("Üçgenin çevresi: " + cevre);
            }


        }
        public static double DaireAlan(double yarıCap)
        {
            double alan = Math.PI * yarıCap * yarıCap;
            return alan;
        }
        public static double DikdortgenAlan(double a , double b)
        {
            double alan = a * b;
            return alan;
        }
        public static double KareAlan(double a)
        {
            double alan = Math.Pow(a, 2);
            return alan;
        }
        public static double UcgenAlan(double a, double h)
        {
            double alan = (a * h) / 2;  
            return alan;    
        }
        public static double DaireCevre(double yarıCap)
        {
            double cevre = 2 * Math.PI * yarıCap;
            return cevre;
        }
        public static double DikdortgenCevre(double a , double b)
        {
            double cevre = (a *2 ) + (b *2);
            return cevre;   
        }
        public static double KareCevre( double a )
        {
            double cevre = a * 4;
            return cevre;
        }
        public static double UcgenCevre(double a , double b, double z)
        {
            double cevre = (a + b + z);
            return cevre;
        }
        static void Main(string[] args)
        {
            Console.Write("1-Daire 2-Dikdörtgen 3-Kare 4-Üçgen\n" +
            "Seçim yapınız: ");
            double secim1 = double.Parse(Console.ReadLine());
            Console.WriteLine("1-Alan\n2-Çevre");
            double secim2 = double.Parse(Console.ReadLine());
            
            if (secim2 == 1) 
            {
                AlanHesapla(secim1);
            }
            else if (secim2 == 2)
            {
                CevreHesapla(secim1);
            }

            Console.ReadKey();  
        }
    }


}
