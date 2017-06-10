using System;

namespace _03.Fold_and_Sum
{
    class FoldAndSum
    {
        static void Main()
        {
            int[] numbers =
                Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            var k = numbers.Length / 4;

            int[] finalResult = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                finalResult[0 + i] = numbers[k - 1 - i] + numbers[k + i];

                finalResult[(2 * k - 1) - i] = 
                    numbers[(3 * k - 1) - i] + numbers[3 * k + i];
            }

            Console.WriteLine(string.Join(" ", finalResult));

        }
    }
}
