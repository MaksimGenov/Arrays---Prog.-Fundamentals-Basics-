using System;

namespace _01.Largest_Common_End
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            var lenght = Math.Min(firstArray.Length, secondArray.Length);

            var matchCountLeftToRight = CountMatchesInArrays(firstArray, secondArray, lenght);

            firstArray = ReverseArray(firstArray);
            secondArray = ReverseArray(secondArray);

            var matchCountRightToLeft = CountMatchesInArrays(firstArray, secondArray, lenght);

            Console.WriteLine(Math.Max(matchCountLeftToRight, matchCountRightToLeft));
        }

        private static string[] ReverseArray(string[] array)
        {
            var backIndex = array.Length - 1;

            for (int frontIndex = 0; frontIndex < array.Length / 2; frontIndex++)
            {
                var temp = array[frontIndex];
                array[frontIndex] = array[backIndex];
                array[backIndex] = temp;
                backIndex--;
            }

            return array;
        }

        private static int CountMatchesInArrays(string[] firstArray, string[] secondArray, int lenght)
        {
            var matchCount = 0;

            for (int pos = 0; pos < lenght; pos++)
            {
                if (firstArray[pos] != secondArray[pos])
                {
                    break;
                }

                matchCount++;
            }

            return matchCount;
        }
    }
}

