using System;

namespace _02.Rotate_and_Sum
{
    class RotateAndSum
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var rotateCount = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotateCount; i++)
            {
                RotateArray(numbers); 

                for (int j = 0; j < numbers.Length; j++)
                {
                        sum[j] = numbers[j] + sum[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static void RotateArray(int[] array)
        {
            var temp = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                if (i - 1 < 0)
                {
                    break;
                }

                array[i] = array[i - 1]; 
            }

            array[0] = temp;
        }
    }
}
