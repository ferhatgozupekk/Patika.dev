using System;

namespace KarakterTerstenYazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz:");
            string cumle = Console.ReadLine().TrimEnd().TrimStart();
            string sonuc = string.Empty;

            for (int i = cumle.Length - 1; i >= 0; i--)
            {
                sonuc += cumle[i];
            }
            Console.WriteLine("Cümlenin Ters Cevirilmis Hali: " + sonuc);
            Console.ReadKey();

        }
    }
}