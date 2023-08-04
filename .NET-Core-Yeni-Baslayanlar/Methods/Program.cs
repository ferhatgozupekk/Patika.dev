namespace Methods
{
    internal class Program
    {
        static int topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }

        class Metotlar
        {
            public void ekranayazdir(string veri) 
            {
                Console.WriteLine(veri);
            }

            public int arttirvetopla(int a , int b) {
                a += 1;
                b += 1;
                return a + b;

            }
        }
        static void Main(string[] args)
        {
            // erişim_belirteci geri_donustipi  metot_adi (paramereListesi / arguman)
            //{
            // komutlar
            //}

            int a = 2;
            int b = 3;  

            Console.WriteLine(a + b);
            int sonuc = topla(a , b);
            Console.WriteLine(sonuc);   

            Metotlar yeni = new Metotlar();
            yeni.ekranayazdir("selslsllsl");
            Console.WriteLine(yeni.arttirvetopla(10, 10));
        }
        
    }
    
}