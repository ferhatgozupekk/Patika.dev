using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list<T> class
            // System.Collections.Generic
            // T -> object türündedir.

            List<int> sayilistesi = new List<int>();
            sayilistesi.Add(90);
            sayilistesi.Add(86);
            sayilistesi.Add(43);
            sayilistesi.Add(56);
            sayilistesi.Add(45);
            sayilistesi.Add(12);
            sayilistesi.Add(23);
            sayilistesi.Add(12);

            List<string> renklistesi = new List<string>();
            renklistesi.Add("kırmızı");
            renklistesi.Add("beyaz");
            renklistesi.Add("turuncu");
            renklistesi.Add("pembe");
            renklistesi.Add("mavi");

            //count
            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayilistesi.Count);

            //foreach ile elemanlara erişim
            sayilistesi .ForEach(sayi => Console.WriteLine(sayi));
            renklistesi.ForEach(renk => Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayilistesi.Remove(4);
            renklistesi.Remove("beyaz");

            //liste içerisinde arama
            if (sayilistesi.Contains(90))
            {
                Console.WriteLine("90 sayı listesinden çıkartıldı");

            }

            //eleman ile indexe erişme

            Console.WriteLine(renklistesi.BinarySearch("mavi"));

            //diziyi liste çevirme

            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanlarListesi= new List<string>();

            //liste temizleme
            hayvanlarListesi.Clear();

            //list içerisinde nesne tutmak
            List<kullanıcılar> kullanıcıListesi = new List<kullanıcılar>;
            kullanıcılar kullanıcı1 = new kullanıcılar();
            kullanıcı1.Isim = " ayşe ";
            kullanıcı1.Soyisim = "soyak";
            kullanıcı1.Yas = 23;
            kullanıcılar kullanıcı2 = new kullanıcılar();
            kullanıcı1.Isim = " ferhat ";
            kullanıcı1.Soyisim = "gözüpek";
            kullanıcı1.Yas = 23;
            kullanıcılar kullanıcı3 = new kullanıcılar();
            kullanıcı1.Isim = " selin";
            kullanıcı1.Soyisim = "asdklş";
            kullanıcı1.Yas = 23;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);
            kullanıcıListesi.Add(kullanıcı3);






        }

        public class kullanıcılar
        {
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}
