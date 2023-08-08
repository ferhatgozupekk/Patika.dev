using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutlakKareAlma
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var strings = input.Split(' ');
            int farkToplam = 0;
            int farkMutToplam = 0;
            string str = string.Empty;
            for (int i = 0; i < strings.Length; i++)
            {

                if (Convert.ToInt32(strings[i]) < 67)
                {
                    farkToplam = farkToplam + (67 - Convert.ToInt32(strings[i]));

                }
                else if (Convert.ToInt32(strings[i]) > 67)
                {

                    farkMutToplam = farkMutToplam + ((int)Math.Pow((Convert.ToInt32(strings[i]) - 67), 2));

                }
                else
                {

                    str += "67 ile eşit";
                }
            }
            str = farkToplam + " " + farkMutToplam;
            Console.WriteLine(str);
        }
    }
}