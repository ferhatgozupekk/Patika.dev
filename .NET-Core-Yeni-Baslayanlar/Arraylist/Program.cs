using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();  
            liste.Add("AYŞE");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisindeki verilere erişm
            Console.WriteLine(liste[0]);
            Console.ReadKey();

            //add range
            Console.WriteLine(liste[0]);
            string[] renkler = { "kırmızı", "mavi", "sarı" };
            List<int> sayilar = new List<int>{ 1, 3, 45, 5, 3, 32 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            //binary searh

            Console.WriteLine(liste.BinarySearch(45));

            // reverse
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //clear
            liste.Clear();  
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }





        }
    }
}
