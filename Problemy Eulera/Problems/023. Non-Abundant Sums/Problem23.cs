﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //A perfect number is a number for which the sum of its proper divisors is exactly equal to the number.For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

    //A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

    //As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.

    //Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
    class Problem23 : IProblem
    {
        private const int limit = 28123;
        private List<int> abundantNumbers;

        public void PrintSolution()
        {
            Console.WriteLine($"Sum of all positive integers which cannot be written as the sum of two abundant numbers: {Solution()}");
        }

        private int Solution()
        {
            abundantNumbers = FillWithAbundantNumbers();
            bool[] isSumOfTwoAbundantNumbers = new bool[limit + 1];
            int sum = 0;

            for(int i = 0; i < abundantNumbers.Count; i++)
                for(int j = i; j < abundantNumbers.Count; j++)
                {
                    if (abundantNumbers[i] + abundantNumbers[j] > limit) break;
                    isSumOfTwoAbundantNumbers[abundantNumbers[i] + abundantNumbers[j]] = true;
                }

            for (int i = 0; i <= limit; i++)
                if (!isSumOfTwoAbundantNumbers[i])
                    sum += i;

            return sum;
        }

        private List<int> FillWithAbundantNumbers()
        {
            List<int> abundantNumbers = new List<int>();

            for (int i = 2; i <= limit; i++)
                if (IsAbundant(i))
                    abundantNumbers.Add(i);
            return abundantNumbers;
        }

        private bool IsAbundant(int n)
        {
            if (n.DivisorsSum() > n)
                return true;
            return false;
        }
    }


}
