using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan("ferhat", "gözüpek", 1234 , "yönetim");
            calisan1.CalisanBilgileri();

            Calisan calisan = new Calisan();
            calisan.Ad = "Ayse";
            calisan.Soyad = "gozupek";
            calisan.No = 12837123;
            calisan.Departman = "yönetim";

            calisan.CalisanBilgileri();
            Console.ReadKey();  
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan (string ad, string soyad, int no, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }
        public Calisan() { }
        public void CalisanBilgileri()
        {
            Console.WriteLine("calisan adi : {0} ", Ad);
            Console.WriteLine("calisan soyadı : {0} ", Soyad);
            Console.WriteLine("calisan no : {0} ", No);
            Console.WriteLine("calisan departmanı : {0} ", Departman);
        }

    }
}
