namespace Ortalama_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derinlik giriniz:");
            int depth = int.Parse(Console.ReadLine());
            int[] fibb = new int[depth];

            fibb[0] = 1;

            if( depth > 1 )
            {
                fibb[1] = 1;    
            }

            for (int i = 2; i < depth; i++)
            {
                fibb[i] = fibb[i - 1] + fibb[i - 2];
            }

            double sum = 0;
            for (int i = 0; i < depth; i++)
            {
                sum += fibb[i];
            }
            foreach (var item in fibb)
            {
                Console.Write(item);
            }
            Console.WriteLine($"fibonacci serisi ortalaması: {sum / depth}" ); 
        }
    }
}