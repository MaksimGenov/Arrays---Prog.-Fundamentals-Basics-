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

            int[] leftNumbers = new int[k];
            int[] rightNumbers = new int[k];
            int[] middleNumbers = new int[2 * k];
            int[] finalResult = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                leftNumbers[i] = numbers[i];
                rightNumbers[i] = numbers[3 * k + i];
            }

            ReverseArray(leftNumbers);
            ReverseArray(rightNumbers);

            for (int i = 0; i < 2 * k; i++)
            {
                middleNumbers[i] = numbers[k + i];
            }

            for (int i = 0; i < k; i++)
            {
                finalResult[i] = leftNumbers[i] + middleNumbers[i];
                finalResult[k + i] = rightNumbers[i] + middleNumbers[k + i];
            }

            Console.WriteLine(string.Join(" ", finalResult));
        }

        private static void ReverseArray(int[] arrayToReverse)
        {
            var lenghtOfArray = arrayToReverse.Length;

            for (int i = 0; i < lenghtOfArray / 2; i++)
            {
                var tempElement = arrayToReverse[i];
                arrayToReverse[i] = arrayToReverse[(lenghtOfArray - 1) - i];
                arrayToReverse[(lenghtOfArray - 1) - i] = tempElement;
            }
        }
    }
}
