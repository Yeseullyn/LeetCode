// Given an array nums of size n, return the majority element.
// The majority element is the element that appears more than ⌊n / 2⌋ times. 
// You may assume that the majority element always exists in the array.

// Example 1:

// Input: nums = [3, 2, 3]
// Output: 3
// Example 2:

// Input: nums = [2, 2, 1, 1, 1, 2, 2]
// Output: 2

public class Solution
{
    public int MajorityElement(int[] nums)
    {

        var dict = new Dictionary<int, int>();
        var maxCount = 0;
        int maxNumber = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            if (!dict.ContainsKey(nums[i])) dict.Add(nums[i], 1);

            dict[nums[i]] += 1;
        }

        for (int i = 0; i < dict.Count; i++)
        {

            if (dict.ElementAt(i).Value > maxCount)
            {
                maxCount = dict.ElementAt(i).Value;
                maxNumber = dict.ElementAt(i).Key;
            }

        }
        return maxNumber;


    }
}