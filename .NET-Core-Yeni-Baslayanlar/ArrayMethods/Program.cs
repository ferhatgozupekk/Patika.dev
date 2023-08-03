using System;

namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sort sıralamak için kullanılır
            int[] sayiDizisi = { 23, 12, 4, 25, 43, 2, 64, 34 };
            Console.WriteLine("**** sırasız dizi ****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            
            Console.WriteLine("**** sirali dizi ****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //clear 
            Console.WriteLine("*** array clear ***");
            Array.Clear(sayiDizisi,2,2); // 2. indexten itibaren iki adet elemanı sıfıralr
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //reverse
            Console.WriteLine("*** array reverse ***");
            Array.Reverse(sayiDizisi); // diziyi sondan başa doğru yazar
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("*** array index of ***");
           
                Console.WriteLine(Array.IndexOf(sayiDizisi, 25)); // istenilen elemanın kaçıncı indexte olduğunu söyler

            //resize
            Console.WriteLine("*** array resize***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 90;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


        }
    }
}