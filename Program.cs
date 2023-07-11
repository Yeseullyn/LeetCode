using System;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();

            int[] result = twoSum.FindTwoSumResult(new int[] { 2, 7, 15, 11 }, 26);

            if (result.Length > 0) Console.WriteLine(result[0] + " " + result[1]);

        }
    }
}
