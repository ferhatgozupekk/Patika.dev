namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin girin: ");
            string input = Console.ReadLine();

            string[] kelime = input.Split(' ');
            string consonants = "bcdfghjklmnpqrstvwxyz";

            foreach (string word in kelime)
            {
                bool sessizHarfVarMı = false;

                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (consonants.Contains(word[i]) && consonants.Contains(word[i + 1]))
                    {
                        sessizHarfVarMı = true;
                        break;
                    }
                }

                Console.Write(sessizHarfVarMı + " ");
            }

            Console.WriteLine();
        }
    }
}