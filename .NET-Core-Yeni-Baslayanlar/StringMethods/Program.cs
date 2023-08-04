namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken1 = "merhaba benim adım ferhat gozupek";
            string degisken2 = "sanada merhaba";

            //length
            Console.WriteLine(degisken1.Length);

            // toupper tolower
            Console.WriteLine(degisken1.ToUpper());    
            Console.WriteLine(degisken1.ToLower());

            //concat
            Console.WriteLine(String.Concat(degisken1, "Merhaba"));
            Console.WriteLine(String.Compare(degisken1, degisken2, true));
            Console.WriteLine(String.Compare(degisken1, degisken2, false));

            //contains 
            Console.WriteLine(degisken1.Contains(degisken2));
            Console.WriteLine(degisken1.EndsWith("gozupek"));

            //indexof
            Console.WriteLine   (degisken2.IndexOf("ana"));

            // insert
            Console.WriteLine(degisken2.Insert(0,"Merhaba"));

            // padleft , padright

            Console.WriteLine(degisken1 + degisken2.PadLeft(30));
            Console.WriteLine(degisken1 + degisken2.PadLeft(30,'*'));

            //Remove

            Console.WriteLine(degisken1.Remove(10));
            Console.WriteLine(degisken1.Remove(5,3));

            //replace

            Console.WriteLine(degisken1.Replace("sanada", "sanadaaaaaaa"));

            //split

            Console.WriteLine(degisken1.Split(' ')[1]);

            //substring

            Console.WriteLine(degisken1.Substring(4));
            Console.WriteLine(degisken1.Substring(4,6));
        }
    }
}