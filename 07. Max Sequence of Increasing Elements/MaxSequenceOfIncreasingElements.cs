using System;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var bestStart = 0;
            var longestLenght = 1;
            var currentLenght = 0;
            var currentStart = 0;

            var endOfLoop = arr.Length;

            for (int i = 1; i < endOfLoop; i++)
            {
                if (arr[i] == arr[i - 1] + 1)
                {
                    currentLenght++;
                }
                else
                {
                    currentLenght = 0;
                }

                if (currentLenght > longestLenght)
                {
                    longestLenght = currentLenght;
                    bestStart = currentStart;
                }
                else
                {
                    currentStart = i - 1;
                }
            }

            for (int i = bestStart; i <= bestStart + longestLenght; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
