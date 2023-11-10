// Given a string s, return true if the s can be palindrome after deleting 
// at most one character from it.

// Example 1:

// Input: s = "aba"
// Output: true
// Example 2:

// Input: s = "abca"
// Output: true
// Explanation: You could delete the character 'c'.
// Example 3:

// Input: s = "abc"
// Output: false

public class Solution
{
    public bool ValidPalindrome(string s)
    {

        // if s.length == 0, return false, ==1 true
        if (s.Length == 0) return false;
        if (s.Length == 1) return true;

        // int startPoint = 0; endPoint = s.Length -1; deleteCount = 0;
        int startPoint = 0;
        int endPoint = s.Length - 1;
        int deleteCount = 0;

        while (endPoint > startPoint)
        {
            if (s[startPoint] == s[endPoint])
            {

                startPoint++;
                endPoint--;
            }
            else
            {
                deleteCount++;
                char tempStart = s[startPoint + 1];
                char tempEnd = s[endPoint - 1];

                if (tempStart == s[endPoint])
                {
                    startPoint++;
                }
                else if (tempEnd == s[startPoint])
                {
                    endPoint--;
                }
                else
                {
                    deleteCount++;
                    startPoint++;
                    endPoint--;
                }
            }
        }
        bool result = deleteCount <= 1;
        return result;
    }
}