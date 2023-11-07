// Given an integer rowIndex, return the rowIndexth (0-indexed) 
// row of the Pascal's triangle. In Pascal's triangle, 
// each number is the sum of the two numbers directly above it as shown:

// Example 1:

// Input: rowIndex = 3
// Output: [1,3,3,1]
// Example 2:

// Input: rowIndex = 0
// Output: [1]
// Example 3:

// Input: rowIndex = 1
// Output: [1,1]

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {

        var result = new List<IList<int>>();

        if (rowIndex < 0)
        {
            var tresult = new List<int>();
            return tresult;
        }
        if (rowIndex >= 0)
        {
            result.Add(new List<int>() { 1 });
        }

        if (rowIndex >= 1)
        {
            result.Add(new List<int>() { 1, 1 });
        }

        for (int i = 2; i <= rowIndex; i++)
        {

            var tempResult = new List<int>();
            tempResult.Add(1);

            for (int y = 1; y < i; y++)
            {

                tempResult.Add(result[i - 1][y - 1] + result[i - 1][y]);

            }
            tempResult.Add(1);
            result.Add(tempResult);
        }
        return result[rowIndex];
    }
}