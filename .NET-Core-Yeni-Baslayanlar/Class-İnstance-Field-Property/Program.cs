using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_İnstance_Field_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();
            calisan.Ad = "Ayse";
            calisan.Soyad = "gozupek";
            calisan.No = 12837123;
            calisan.Departman = "yönetim";
            calisan.CalisanBilgileri();


        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("calisan adi : {0} ", Ad);
            Console.WriteLine("calisan soyadı : {0} ", Soyad);
            Console.WriteLine("calisan no : {0} ", No);
            Console.WriteLine("calisan departmanı : {0} ", Departman);
        }

    }
}
//erişim belirleriyiciler
//public
//private
//internal
//protected