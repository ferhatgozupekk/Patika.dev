namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BİR METİN VE İNDEX NUMARASI GİRİNİZ:");
            string text = Console.ReadLine();
            string word = text.Split(',')[0];
            int index;

            bool isInt = int.TryParse(text.Split(',')[1],out index);

            if( isInt == true && index < text.Length ) 
            {
                List<char> chars = word.ToList();
                chars.RemoveAt(index);

                foreach( char c in chars ) { Console.Write(c); }
            }
            else { Console.WriteLine("indexin uzunluğu ifadenin uzunluğundan fazla olamaz."); }
            Console.ReadKey();  
        }
        
    }
}