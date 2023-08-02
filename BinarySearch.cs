/*
Given an array of integers nums which is sorted in ascending order, 
and an integer target, write a function to search target in nums. 
If target exists, then return its index. Otherwise, return -1.
*/

// O(n)
public class SolutionSearch
{
    public int Search(int[] nums, int target)
    {
        //Searching nums array, if target exists
        for (int i = 0; i < nums.Length; i ++)
        {
            if(nums[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}


//  To achieve O(log n) runtime complexity for the given problem,
//  use the binary search algorithm.
public class SolutionSearchTwo
{
    public int Search(int[] nums, int target)
    {
        // Declare left and right which are indices index of nums array
        int left = 0;
        int right = nums.Length - 1;

        // Use binary search to find the target in the nums array
        while (left <= right)
        {
            // Calculate the middle index of the current search range
            int mid = left + (right - left) / 2;

            // If the middle element is the target, return the middle index
            if (nums[mid] == target)
            {
                return mid;
            }
            // If the mid is less than the target, search in the right half
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            // If the mid is greater than the target, search in the left half
            else
            {
                right = mid - 1;
            }
        }

        // If the target does not exist in the array, return -1
        return -1;
    }
}