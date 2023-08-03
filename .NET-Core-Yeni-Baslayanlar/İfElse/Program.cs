namespace İfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11) { Console.WriteLine("günaydın."); }
            else if (time < 18) { Console.WriteLine("iyi günler"); }
            else { Console.WriteLine("iyi geceler"); }

            string sonuc = time <= 18 ? "iyi günler" : "iyi geceler "; // ? = ise : = değilse anlamına gelir.
            Console.WriteLine(sonuc);   
        }
    }
}