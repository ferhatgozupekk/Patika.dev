using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bitkiler :Canlılar
    {
        public void FotosentezYapmak()
        {
            Console.WriteLine("bitkiler fotosentez yapar");
        }
    }
    public class tohumluBitkiler : Bitkiler
    {
        public void TohumlaCogalma()
        {
                Console.WriteLine("tohumlu bitkiler tohumla çoğalır");     
        }
    }
}


