using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Hayvanlar :Bitkiler
    {
        public void Adaptasyon()
        {

            Console.WriteLine("hayvanlar adaptan kurabilir");

        }
    }
    public class sürüngenler:Hayvanlar
    {

        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("kuşlar uçar");
        }

    }
    public class Kuslar:Hayvanlar
    {
        public void ucmak()
        {
            Console.WriteLine("kuslar ucar");
        }
    }

}
