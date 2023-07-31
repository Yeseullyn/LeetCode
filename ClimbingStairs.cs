/*
You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. 
In how many distinct ways can you climb to the top?
*/
public class Solution
{
    public int ClimbStairs(int n) //4
    {
        // how many distinct ways can you climb to the top?
        // int array[] = n + 1;
        int[] array = new int[n + 1];
        array[1] = 1;
        array[2] = 2;

        if (n == 1)
        {
            return n;
        }
        else if (n == 2)
        {
            return n;
        }

        // n = (n-1) + (n+2)
        for (int i = 3; i <= n; i++)
        {
            array[i] = (array[i - 1]) + (array[i - 2]);
        }

        return array[n];
    }
}
