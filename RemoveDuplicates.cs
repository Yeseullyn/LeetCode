/*
Given an integer array nums sorted in non-decreasing order,
remove the duplicates in-place such that each unique element appears only once.
The relative order of the elements should be kept the same.
Then return the number of unique elements in nums.

Consider the number of unique elements of nums to be k,
to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums
contain the unique elements in the order they were present in nums initially.
The remaining elements of nums are not important as well as the size of nums.
Return k.
*/

public class SolutionRemoveDuplicates {
    public int RemoveDuplicates(int[] nums)
    {
        // If nums is null or empty, return 0
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        // Declare the index of unique elements
        int k = 0;

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            // For the first element or if the current element is different from the previous one,
            // update nums[k] and increment k
            if(i == 0 || nums[i] != nums[i-1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        // Return the count of unique elements
        return k;
    }
}