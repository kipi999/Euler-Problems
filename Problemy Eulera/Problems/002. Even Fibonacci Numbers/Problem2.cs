﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

    class Problem2 : IProblem
    {
        private const int firstStartingNumber = 1;
        private const int secondStartingNumber = 2;
        private const int maxNumber = 4_000_000;

        public void PrintSolution()
        {
            Console.Write($"Sum of all even Fibonacci numbers below {maxNumber}: {Solution()}");
        }

        public int Solution()
        {
            List<int> numbers = FillWithFibonacciNumbers();
            return numbers.Where(x => x.IsEven()).Sum();
        }

        private List<int> FillWithFibonacciNumbers()
        {
            List<int> numbers = new List<int>();
            numbers.Add(firstStartingNumber);
            numbers.Add(secondStartingNumber);

            while (true)
            {
                int next = numbers[numbers.Count - 1] + numbers[numbers.Count - 2];
                if (next > maxNumber) break;
                numbers.Add(next);
            }

            return numbers;
        }

    }
}
