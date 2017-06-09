using System;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            var bestStart = 0;
            var longestLenght = 0;
            var MatchCount = 0;

            var endOfLoop = arr.Length;

            for (int i = 0; i < endOfLoop; i++)
            {
                for (int j = i; j < endOfLoop; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        MatchCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (MatchCount > longestLenght)
                {
                    longestLenght = MatchCount;
                    bestStart = i;
                }
                MatchCount = 0;
            }

            for (int i = bestStart; i < (bestStart + longestLenght); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}