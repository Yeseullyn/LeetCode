/*
Given an array of integers nums which is sorted in ascending order, 
and an integer target, write a function to search target in nums. 
If target exists, then return its index. Otherwise, return -1.
*/
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