namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ALGORİTMA 3
              Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
              Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
              Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */

            Console.WriteLine("lütfen pozitif bir sayi giriniz");
            bool sonuc = true;
            while (sonuc)
            {
                int sayi = int.Parse(Console.ReadLine());
                if (sayi < 0)
                {
                    Console.WriteLine("pozitif bir sayi girmeniz gerekiyor");
                    break;
                }
                //else if bloğuyla girilen verinin string olma durumu kontrol edilebilir
                else
                {
                    Console.WriteLine("lütfen " + sayi + " adet kelime giriniz.");
                    string[] kelimeler = new string[sayi];
                    for (int i = 0; i < kelimeler.Length; i++)
                    {
                        kelimeler[i] = Console.ReadLine();
                    }
                    for (int i = kelimeler.Length-1 ; i >=0 ; i--)
                    {
                        Console.WriteLine(kelimeler[i]);
                    }                 
                    break;
                }

            }
            Console.ReadKey(); 
        }
    }
}