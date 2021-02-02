using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LoopTasks
{
    public static class LoopTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static int SumOfOddDigits(int n)
        {
            if (n < 0) return 0;

            return n.ToString().ToCharArray().
                Where(c => (int)c % 2 != 0).
                Sum(c => Convert.ToInt32(c.ToString()));
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int NumberOfUnitsInBinaryRecord(int n)
        {
            if (n < 0) return 0;

            var bitArray = new BitArray(new int[] { n });

            return bitArray.Cast<bool>().Select(bit => bit ? 1 : 0).Sum();
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            if (n < 0) return 0;

            var fibs = new List<int>();

            Enumerable.Range(0, n)
                .ToList()
                .ForEach(f => fibs.Add(f > 1 ? fibs[f - 2] + fibs[f - 1] : f));

            return fibs.Sum();
        }
    }
}