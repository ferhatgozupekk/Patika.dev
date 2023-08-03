using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = "ferhat";
            Console.WriteLine(degisken + deger);
            string degisken2 = null;

            byte b = 5;
            sbyte b2 = 5;   //1 byte yer kaplar

            short sshort = 5;   //bellekte 2 byte yer kaplar
            ushort sshort2 = 5; //2 byte

            Int16 asd = 5;  //2 byte
            int i = 0;  // 4 byte
            Int32 asd2 = 5; // 4 byte 
            Int64 asd3 = 5; // 8 byte 

            uint asd4 = 5; // 4byte
            long asd5 = 5; //8 byte
            ulong asd6 = 5; // 8 byte

            float asd7 = 5; //4byte
            double asd8 = 5;//8byte
            decimal asd9 = 5; //16 byte
            
            char ch = 'a';
            string asdf = "asdfsad";

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            object o1 = "x";

            string str1 = string.Empty;
            str1 = "ferhat";

            // degişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();

            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            // 
            string dateTime2 = DateTime.Now.ToString("dd.MM.yyyy");  //"HH:mm" saat
            Console.WriteLine(dateTime);    

        }
    }
}
