using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar =  new Dictionary<int,string>();
            kullanıcılar.Add(10, "ferhat gözüpek");
            kullanıcılar.Add(12, "selin gözüpek");

            // dizinin elemanlarına erişim
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.Write(item);
            }
             

            //count
            Console.WriteLine(kullanıcılar.Count);

            //contains
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("ferhat gözüpek"));


            //remove
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);

            }

            //keys
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            //values

            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
