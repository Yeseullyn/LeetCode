using System;
namespace Leetcode
{
    public class TwoSum
    {
        public TwoSum()
        {
        }

        public int[] FindTwoSumResult(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    break;
                }

                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }
    }
}
