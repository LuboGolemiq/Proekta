using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> positiveNumbers = new List<int>();
            List<int> negativeNumbers = new List<int>();
            int nums;

            Console.WriteLine("Dai chisla, 0 za krai:");

            while (true)
            {
                nums = int.Parse(Console.ReadLine());

                if (nums == 0)
                    break;

                if (nums > 0)
                    positiveNumbers.Add(nums);
                else if (nums < 0)
                    negativeNumbers.Add(nums);
            }

            int positiveSum = 0;
            int negativeSum = 0;


            for (int i = 0; i < positiveNumbers.Count; i++)
            {
                positiveSum += positiveNumbers[i];
            }


            for (int i = 0; i < negativeNumbers.Count; i++)
            {
                negativeSum += negativeNumbers[i];
            }


            Console.Write(" Sum na polojitelnite: ");
            for (int i = 0; i < positiveNumbers.Count; i++)
            {
                if (i != 0)
                    Console.Write("+");
                Console.Write(positiveNumbers[i]);
            }
            Console.WriteLine("=" + positiveSum);


            Console.Write("Sum na otricatelnite: ");
            for (int i = 0; i < negativeNumbers.Count; i++)
            {
                if (i != 0)
                    Console.Write("-");
                Console.Write(Math.Abs(negativeNumbers[i]));
            }
            Console.WriteLine("=" + negativeSum);
        }
    }
}
    

