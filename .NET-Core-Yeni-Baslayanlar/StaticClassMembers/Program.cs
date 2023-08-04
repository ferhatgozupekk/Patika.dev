using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static olan claslara nesne oluşturmadan ulaşabiliriz program runlandığı an çalışmaya başlar
            Console.WriteLine("calısan sayisi : {0} ", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("ferhat","gözüpek","yönetim");
            Console.WriteLine("calısan sayisi : {0} ", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("ahmet", "can", "yönetim");
            Calisan calisan3 = new Calisan("pelin", "yaprak", "yönetim");
            Console.WriteLine("calısan sayisi : {0} ", Calisan.CalisanSayisi);

            Console.WriteLine("toplama işleminin sonucu : {0} ", Islemler.Topla(1, 1) );
            Console.WriteLine("cıkarma isleminin sonucu: {0} ", Islemler.Cıkar(10, 5));
            
            



            Console.ReadKey();  
        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        private string isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.Soyisim = soyisim; 
            this.Departman = departman;
            calisanSayisi++;
        }

        

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim1 { get => Soyisim; set => Soyisim = value; }
        public string Departman1 { get => Departman; set => Departman = value; }
    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
