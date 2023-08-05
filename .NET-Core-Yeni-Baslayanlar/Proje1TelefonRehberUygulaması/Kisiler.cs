using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1TelefonRehberUygulaması
{
    internal class Kisiler
    {
        private string name, surName, phoneNumber;

        public Kisiler(string name, string surName, string phoneNumber)
        {
            this.Name = name;
            this.SurName = surName;
            this.PhoneNumber = phoneNumber;
        }

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
