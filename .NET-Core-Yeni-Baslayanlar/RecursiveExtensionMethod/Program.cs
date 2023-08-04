using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveExtensionMethod
{
    internal class Program
    {
        public class islemler
        {
            public int Expo(int sayi  ,int üs)
            {
                if (üs<2) 
                    return sayi;
                return Expo(sayi, üs - 1) * sayi;
                
            }
            
        }
        static void Main(string[] args)
        {
            //rekürsif -- öz yinelemeli
            // 3^4 = 3*3*3*3

            int result = 1;
            for (int i = 1; i < 5; i++)         
                result = result * 3;  
            Console.WriteLine(result);

            islemler instance = new islemler();
            Console.WriteLine(instance.Expo(3, 4));

            //extension metotlar
            string ifade = "ferhat";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());   
            }
            Console.WriteLine(ifade.MakeUpperCase());
            //aynı ifadenin lowercase i yapılabilir

            int[] dizi = { 9, 5, 2, 6, 2 };
            dizi.SortArray();
            dizi.EkranaYazdir();    

        }

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" "); 
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join(" ", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper(); 
        }

        public static int[] SortArray(this int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)    
                Console.WriteLine(item);    
        }
    }
}
