namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("dai chislo:");
          
            int n = int.Parse(Console.ReadLine());
            Console.Write("zadai granica:");
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
               
                if (i < k)
                {
                    counter++;
                    Console.WriteLine($"{i}");
                    
                }
            }
            Console.WriteLine($"broq e:{counter}");
        }
    }
}
