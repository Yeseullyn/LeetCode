/**
 * Write a function to find the longest common prefix string amongst an array of strings.
 * If there is no common prefix, return an empty string "".
 * @param {string[]} strs
 * @return {string}
 */
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0 || strs == null)
            return "";

        // Declare strs[0] is commonPrefix
        string commonPrefix = strs[0];

        // Compare commonPrefix with all value of strs
        for (int i = 1; i < strs.Length; i++)
        {
            int j = 0;

            // Compare characters commonPrefix with strs[i] while they are equal
            while (j < commonPrefix.Length && j < strs[i].Length && commonPrefix[j] == strs[i][j])
            {
                j++;
            }

            // Set the matching part to the commonPrefix
            commonPrefix = commonPrefix.Substring(0, j);

            // Return "" when commonPrefix has 0 value
            if (commonPrefix.Length == 0)
                return "";
        }
        return commonPrefix;
    }
}