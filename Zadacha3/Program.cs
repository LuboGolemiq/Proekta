namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            Console.WriteLine("Vuvedi duma i napishi end za krai:");

            
            while (true)
            {
               
                string input = Console.ReadLine();

                
                if (input == "end")
                {
                    break;
                }

               
                string word = input;

                
                if (wordCounts.ContainsKey(word))
                {
                    
                    wordCounts[word]++;
                }
                else
                {
                   
                    wordCounts[word] = 1;
                }
            }

           
            Console.WriteLine("Rezultat:");
            List<string> keys = new List<string>(wordCounts.Keys);
            for (int i = 0; i < keys.Count; i++)
            {
                string key = keys[i];
                Console.WriteLine($"\"{key}\" -> {wordCounts[key]}");
            }
        }
    }
}
