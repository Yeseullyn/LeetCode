/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
determine if the input string is valid.

An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
*/

public class SolutionValidParentheses
{
    public bool IsValid(string s)
    {
        // Declare stack that sotre opening brackets
        Stack<char> stack = new Stack<char>();

        // Iterate each caracters in the string s
        foreach (char c in s)
        {
            // If c is a opening bracket, then store into stack
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            // If c is a closing bracket, then check stack has a value
            else if (c == ')' || c == '}' || c == ']')
            {
                // If stack is empty, then return false
                if (stack.Count == 0)
                {
                    return false;
                }

                // If stack is not empty, then declare stack into currentChar
                char currentChar = stack.Pop();

                // If the opening bracket is not matching, then return false 
                if (c == ')' && currentChar != '(' || c == '}' && currentChar != '{' || c == ']' && currentChar != '[')
                {
                    return false;
                }
            }
        }
        // return true if stack is empty
        return stack.Count == 0;
    }
}