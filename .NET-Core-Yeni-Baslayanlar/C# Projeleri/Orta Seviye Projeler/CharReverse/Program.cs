namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boşluk bırakarak kelimeleri giriniz.");
            string[] str = Console.ReadLine().Split();

            foreach (var item in str)
            {
                char[] liste = item.ToCharArray();
                char tutucu = liste[0];
                liste[0] = liste[liste.Length - 1];
                liste[liste.Length - 1] = tutucu;

                string s = "";
                foreach (var c in liste)
                    s += c.ToString();
                Console.Write(s + " ");
            }
            Console.ReadKey();  
        }
    }
}