using System;

namespace _04.Sieve_of_Eratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            var endOfRange = int.Parse(Console.ReadLine());

            bool[] primes = new bool[endOfRange + 1];
            for (int i = 0; i <= endOfRange; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 2; i <= endOfRange; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");

                    for (int p = i * i; p <= endOfRange; p += i)
                    {
                        primes[p] = false;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}

