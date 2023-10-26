// Given an integer numRows, return the first numRows of Pascal's triangle.
// Example 1:
// Input: numRows = 5
// Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
// Example 2:
// Input: numRows = 1
// Output: [[1]]

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {

        var result = new List<IList<int>>();


        // numRows 0, []
        if (numRows == 0) return result;

        // numRows 1, [1]
        if (numRows == 1)
        {

            var temResult = new List<int>() { 1 };
            result.Add(temResult);
            return result;
        }
        result.Add(new List<int>() { 1 });
        result.Add(new List<int>() { 1, 1 });


        if (numRows == 2)
        {
            return result;
        }

        for (int n = 2; n < numRows; n++)
        {
            var temResult = new List<int>();

            temResult.Add(1);


            for (int k = 1; k < n; k++)
            {
                //a n k = a(n-1)(k-1) + a(n-1)(k) 

                temResult.Add(result[n - 1][k - 1] + result[n - 1][k]);

            }
            temResult.Add(1);
            result.Add(temResult);
        }
        return result;
    }
}