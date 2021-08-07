using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 1; i < 21; i++)
            {
                numbers.Add(random.Next(1, 50));
            }
            foreach (var number in numbers)
            {
                Console.WriteLine($"Random number: {number}");
            }

            var squaredNumbers = new List<int>();

            foreach (var number in numbers)
            {
                var squaredNumber = number * number;
                squaredNumbers.Add(squaredNumber);
                Console.WriteLine($"Squared numbers: {squaredNumber}");
            }

            squaredNumbers.RemoveAll(number => number % 2 != 0);

            foreach (var number in squaredNumbers)
            {
                Console.WriteLine($"Odd Numbers Removed: {number}");
            }
        }
    }
}
