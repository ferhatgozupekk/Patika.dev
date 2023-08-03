namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month; 

            switch (month) 
            { 
            case 1:
                    Console.WriteLine("ocak ayındasınız");
                    break;
            case 2:
                    Console.WriteLine("şubat ayındasınız");
                    break;
            case 3:
                    Console.WriteLine("mart ayındasınız");
                    break;
            case 4:
                    Console.WriteLine("nisan ayındasınız");
                    break;  
            case 5:
                    Console.WriteLine("mayıs ayındasınız");
                    break;  
            case 6:
                    Console.WriteLine("haziran ayındasınız");
                    break;  
            case 7:
                    Console.WriteLine("temmuz ayındasınız");
                    break;
                default:Console.WriteLine("yanlış veri girdinzi");
                    break;
        }
    }
}