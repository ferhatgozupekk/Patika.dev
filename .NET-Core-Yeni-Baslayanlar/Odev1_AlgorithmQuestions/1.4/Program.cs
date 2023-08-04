namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ALGORİTMA 4
            Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */

            string str;
            int i, wrd, l;

            Console.WriteLine("lütfen ekrana bir cümle yazdırın");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

         
            while (l <= str.Length - 1)
            {
               
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Cümledeki toplam kelime sayısı : {0}\n", wrd);
            Console.ReadKey(); 
        }
    }
}