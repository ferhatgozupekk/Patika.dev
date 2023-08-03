namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };

            int[] dizi;
            dizi = new int[5];

            // dizilere değer atama ve erişim

            renkler[0] = "mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngüler dizi

            Console.WriteLine("lütfen dizinin uzunlugunu giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] dizi1 = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("lütfen {0}. sayıyı giriniz", i+1);
                dizi1[i] = int.Parse(Console.ReadLine());
            }

            int toplam12 = 0;
            foreach (int sayi in dizi1) 
                toplam12 += sayi;
      
            Console.WriteLine("ortalama: " + toplam12 / diziUzunlugu);
        }
    }
}