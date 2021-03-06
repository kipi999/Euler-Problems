﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemy_Eulera
{
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //Find the sum of all the multiples of 3 or 5 below 1000.

    public class Problem1 : IProblem
    {
        private const int maxNumber = 1000;
        private const int firstMultiple = 3;
        private const int secondMultiple = 5;

        public void PrintSolution()
        {
            Console.WriteLine($"Sum of all the multiplie of {firstMultiple} or {secondMultiple} below {maxNumber}: {Solution()}");
        }

        private int Solution()
        {
            int sum = 0;

            for(int i = firstMultiple; i < maxNumber; i++)
            {
                if (i.DividesBy(firstMultiple) || i.DividesBy(secondMultiple))
                    sum += i;
            }

            return sum;
        }

    }
}
