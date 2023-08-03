using System;
namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 3;
            int y = 4;  
            int z = x + y ;
            z *= x;
            z /= y;

            // mantıksal oparetorler
            // || %% !

            bool isTrue = false;    
            bool isFull = false;   

            if ( isTrue & isFull ) {
                Console.WriteLine("hello");
            }

            // ilişkisel oparetorler 
            // < , > , >= , <= , == , != 

            int a = 1;
            int b = 2;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);

            // % mod alır

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);  






        }
    }
}