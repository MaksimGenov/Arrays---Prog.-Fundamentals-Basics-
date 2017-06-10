using System;

namespace _05.Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            char[] arr01 =
                Array.ConvertAll(Console.ReadLine()
                .Split(), char.Parse);
            char[] arr02 =
                Array.ConvertAll(Console.ReadLine()
                .Split(), char.Parse);
            
            var arr01IsBigger = true;

            if (arr01.Length > arr02.Length)
            {
                arr01IsBigger = true;
            }
            else if (arr01.Length < arr02.Length)
            {
                arr01IsBigger = false;
            }
            else
            {
                var endOfLoop = Math.Max(arr01.Length, arr02.Length);

                for (int i = 0; i < endOfLoop; i++)
                {
                    if (Convert.ToInt32(arr01[i]) >
                        Convert.ToInt32(arr02[i]))
                    {
                        arr01IsBigger = true;
                        break;
                    }
                    else if (Convert.ToInt32(arr01[i]) <
                        Convert.ToInt32(arr02[i]))
                    {
                        arr01IsBigger = false;
                        break;
                    }
                }
            }

            if (arr01IsBigger)
            {
                Console.WriteLine(string.Join("", arr02));
                Console.WriteLine(string.Join("", arr01));
            }
            else
            {
                Console.WriteLine(string.Join("", arr01));
                Console.WriteLine(string.Join("", arr02));
            }
        }
    }
}
