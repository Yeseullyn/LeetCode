// The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, 
// such that each number is the sum of the two preceding ones, starting from 0 and 1. 
// That is,
// F(0) = 0, F(1) = 1
// F(n) = F(n - 1) + F(n - 2), for n > 1.
// Given n, calculate F(n).

// First Solution
public class Solution
{
    public int Fib(int n)
    {

        int result = 0;
        int firstNumber = 0;
        int secondNumber = 1;

        // f(0) = 0|| f(1) = 1
        if (n == 0 || n == 1) return n;

        // f(n) = f(n-1) + f(n-2)
        for (int i = 2; i <= n; i++)
        {

            result = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = result;
        }
        return result;
    }
}

// Second solution
public class Solution {
    public int Fib(int n) {

        if(n == 0 || n == 1) return n;

        return Fib(n-1) + Fib(n-2);

    }
}
