using System;

TwoSum twoSum = new TwoSum();
    int[] nums = { 2, 7, 11, 15 };
    int target = 9;

    int[] result = twoSum.FindTwoSumResult(nums, target);

    Console.WriteLine(result[0] + " " + result[1]);
    Console.WriteLine(result);
