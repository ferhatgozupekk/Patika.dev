using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1TelefonRehberUygulaması
{
    internal class Rehber
    {
        List<Kisiler> kisiler = new List<Kisiler>();    
        public Rehber ()
        {
            kisiler.Add(new Kisiler("ferhat", "gözüpek", "1234567891"));
            kisiler.Add(new Kisiler("ahmet", "can", "1234567892"));
            kisiler.Add(new Kisiler("selin", "gözüpek", "1234567893"));
            kisiler.Add(new Kisiler("emir", "can", "1234567894"));
            kisiler.Add(new Kisiler("arda", "güler", "1234567895"));
        }

       public void NumaraEkle()
        {
            Console.WriteLine("****** YENİ NUMARA KAYDETME ******");
            string name = "";
            string surName = "";
            string phoneNumber = "";
            
            bool nameIsValid = false;   
            bool surnameIsValid = false;
            bool phoneIsValid = false;

            while (!nameIsValid || !surnameIsValid || !phoneIsValid) 
            {
                if (!nameIsValid) 
                {
                    Console.WriteLine("İsim Giriniz: ");
                    name = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("HATA !");
                        Console.WriteLine("İsim Boş Bırakılamaz");
                    }
                    else { nameIsValid = true; }
                }
                else if (!surnameIsValid)
                {
                    Console.WriteLine("Soyad Giriniz: ");
                    surName= Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(surName))
                    {
                        Console.WriteLine("HATA !");
                        Console.WriteLine("Soyad Boş Bırakılamaz");
                    }
                    else { surnameIsValid = true; }
                }
                else if (!phoneIsValid)
                {
                    Console.WriteLine("Lütfen 10 Haneli Telefon Nuamarası Giriniz: ");
                    phoneNumber = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(phoneNumber))
                    {
                        Console.WriteLine("HATA !");
                        Console.WriteLine("Numara Boş Bırakılamaz");
                    }
                    else if (phoneNumber.Length == 10)
                    {
                        if (long.TryParse(phoneNumber,out long converted_no) == false)
                        {
                            Console.WriteLine("Geçersiz Telefon Numarası Girdiniz");
                        }
                        else { phoneIsValid = true; }
                    }
                    
                }
            }
            kisiler.Add(new Kisiler(name, surName, phoneNumber));
            Console.WriteLine("Ekleme İşlemi Başarılı");


        }

        public void DeleteNo()
        {
            string name = "";
            string surName = "";

            bool nameIsValid = false;
            bool surnameIsValid = false;

            while (!nameIsValid || !surnameIsValid)
            {
                if (!nameIsValid)
                {
                    Console.WriteLine("Numarasını Silmek İstediğiniz Kişinin adını giriniz");
                    name = Console.ReadLine().Trim(); 
                    if (string.IsNullOrEmpty(name)) 
                    {
                        Console.WriteLine("İsim Boş Bırakılamaz");
                    } 
                    else 
                    { 
                        nameIsValid =  true; 
                    }

                }
                else if (!surnameIsValid)
                {
                    Console.WriteLine("Numarasını Silmek İstediğiniz Kişinin soyadını giriniz");
                    surName = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(surName))
                    {
                        Console.WriteLine("Soyad Boş Bırakılamaz");
                    }
                    else
                    {
                        surnameIsValid = true;
                    }

                }
            }
            var result = kisiler.Find(x => x.Name == name && x.SurName == surName);
            if (result != null) 
            {
                kisiler.Remove(result);
                Console.WriteLine("Silme işlemi tamamlandı");            }
            else { Console.WriteLine("Kişi Bulunamadı"); }

        }

        public void List()
        {
            bool secimIsValid = false;
            string secim = "";
            Console.WriteLine("Rehberi Listele");
            Console.WriteLine("---------------");

            while (!secimIsValid) 
            {
                if (!secimIsValid)
                {
                    Console.WriteLine("A dan Z ye sıralamak için (1) \n Z den A ya doğru sıralamak için (2) ");
                    secim = Console.ReadLine();
                    if (string.IsNullOrEmpty(secim))
                    {
                        Console.WriteLine("Lütfen doğru seçim yapınız");
                    }
                    else
                    {
                        secimIsValid = true;
                    }

                }              
            }
            if (secim == "1") 
            {
                Console.WriteLine("Telefon Listesi");
                Console.WriteLine("***************");
                List<Kisiler> sortedList = kisiler.OrderBy(x => x.Name).ToList();
                foreach (var item in sortedList) 
                {
                    Console.WriteLine("Ad: " + item.Name);
                    Console.WriteLine("Soyad : " + item.SurName);
                    Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);

                }
            }


        }

        public void Search()
        {
            Console.WriteLine("İsim ve soyisme göre arama yapmak için '1'\n" +
                "Telefon numarasına göre arama yapmak için '2' seçiniz: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("İsim giriniz: ");
                string name = Console.ReadLine();
                Console.Write("Soyisim giriniz: ");
                string surname = Console.ReadLine();

                var result = kisiler.Find(x => x.Name == name && x.SurName == surname);
                if (result != null)
                {
                    Console.Write(result.Name + " ");
                    Console.Write(result.SurName + " ");
                    Console.WriteLine(result.PhoneNumber);
                }
                else
                {
                    Console.WriteLine("Kişi bulunamadı");
                }
            }
            else if (secim == "2")
            {
                Console.WriteLine("Telefon numarası giriniz:");
                string no = Console.ReadLine();

                var result = kisiler.Find(x => x.PhoneNumber == no); 
                if (result != null)
                {
                    Console.WriteLine(result.Name);
                    Console.WriteLine(result.SurName);
                    Console.WriteLine(result.PhoneNumber);
                }
                else
                { Console.WriteLine("Kişi bulunamadı"); }
            }
        }
        public void UpdateNo()
        {
            string name = "";
            string surname = "";
            string phoneNumber = "";
            bool nameIsValid = false;
            bool surnameIsValid = false;
            bool phoneIsValid = false;

            while (!nameIsValid || !surnameIsValid || !phoneIsValid)
            {
                if (!nameIsValid)
                {
                    Console.Write("Numarasını güncellemek istediğiniz kişinin adını giriniz: ");
                    name = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("İsim boş bırakılamaz");
                    }
                    else
                    {
                        nameIsValid = true;
                    }
                }
                else if (!surnameIsValid)
                {
                    Console.Write("Numarasını güncellemek istediğiniz kişinin soyadını giriniz: ");
                    surname = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(surname))
                    {
                        Console.WriteLine("Soyad boş bırakılamaz");
                    }
                    else
                    {
                        surnameIsValid = true;
                    }
                }
                    else if (!phoneIsValid)
                {
                    Console.Write("10 haneli telefon numaranızı giriniz: ");
                    phoneNumber = Console.ReadLine().Trim();               
                    var result = kisiler.Find(x => x.PhoneNumber == phoneNumber);

                    if (string.IsNullOrEmpty(phoneNumber))
                    {
                        Console.WriteLine("Uyarı !!!");
                        Console.WriteLine("Telefon numarası boş geçilemez");
                    }
                    else if (phoneNumber.Length < 10 || phoneNumber.Length >10)
                    {
                        Console.WriteLine("Lütfen 10 Haneli Telefon Numarası Giriniz");
                    }
                    else if (result != null)
                    {
                        Console.WriteLine("Kişi bulundu");
                        Console.Write("Yeni telefon numarasını giriniz:");
                        string new_no = Console.ReadLine();
                        if (string.IsNullOrEmpty(new_no))
                        {
                            Console.WriteLine("Numara boş geçilemez !");
                        }
                        else if (new_no.Length == 10)
                        {
                            if (long.TryParse(phoneNumber, out long converted_no) == false)
                            {
                                Console.WriteLine("Geçersiz telefon numarası");
                            }
                            else
                            {
                                var sonuc = kisiler.Find(x => x.PhoneNumber == phoneNumber);
                                sonuc.PhoneNumber = new_no;
                                Console.WriteLine("Güncelleme başarıyla gerçekleştirildi");
                                phoneIsValid = true;
                            }
                        }
                        else { Console.WriteLine("Geçersiz telefon numarası!"); }
                    }
                    else
                    {
                        Console.WriteLine("Kişi bulunamadı. Lütfen bir seçim yapınız");
                        Console.WriteLine("Güncellenemyi sonlandırmak için :'1'\n" +
                                          "Yeniden denemek için:           :'2'");
                        string secim = Console.ReadLine();
                        if (secim == "1")
                        {
                            break;
                        }
                        else if (secim != "2")
                        {
                            Console.WriteLine("Hatalı giriş yaptınız");
                        }
                    }
                }
            }
        }
    }
}
