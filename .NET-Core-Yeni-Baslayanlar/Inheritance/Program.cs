using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tohumluBitkiler tohumluBitki = new tohumluBitkiler();
            tohumluBitki.Beslenme();
            tohumluBitki.FotosentezYapmak();
            tohumluBitki.Solunum();
            tohumluBitki.TohumlaCogalma();
            tohumluBitki.Bosaltim();

            Kuslar kuslar = new Kuslar();
            kuslar.ucmak();

        }
    }
}
