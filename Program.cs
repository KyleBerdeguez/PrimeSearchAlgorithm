using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            primes.Add(3);
            int currentNumber = 5;
            while (currentNumber < 250000)
            {
                bool isPrime = true;
                int innerWhileIndex = 0;
                while (innerWhileIndex < primes.Count - 1)
                { 
                    if (currentNumber % primes[innerWhileIndex] == 0)
                    {
                        isPrime = false;
                    }
                    innerWhileIndex++;
                }
                if (isPrime)
                {
                    primes.Add(currentNumber);
                }
                currentNumber++;
                currentNumber++;
            }
            int lastWhile = 0;
            while (lastWhile < primes.Count)
            {
                Console.WriteLine(primes[lastWhile]);
                lastWhile++;
            }
            Console.ReadKey();
        }
    }
}
