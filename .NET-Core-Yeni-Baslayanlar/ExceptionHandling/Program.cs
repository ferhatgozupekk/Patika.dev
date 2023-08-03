namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmis oldugunuz sayi : " + sayi);
            }
            catch (Exception ex) 
            { 
                Console.Write(ex.Message.ToString());
            }
            // finally { Console.WriteLine("işlem tamamlandı"); }
            
            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");
            }
            catch (ArgumentException ex) 
            {
                Console.Write("veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            
        }
    }
}