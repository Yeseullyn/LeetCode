/*
You are given an array prices where prices[i] is 
the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock 
and choosing a diffrenet day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction.
If you cannot achieve any profit, return 0.
*/

public class SolutionBuyandSellStock
{
    public int MaxProfit(int[] prices) //Input: prices = [7,1,5,3,6,4] or [7,6,4,3,1]
    {
        // If prices is null or empty return 0
        if (prices == null || prices.Length == 0)
        {
            return 0;
        }

        int maxProfit = 0;
        int minPrice = prices[0];

        // Iterate prices to find maximum profit
        for (int i = 1; i < prices.Length; i++)
        {
            // Calculate potential profit by subtracting the current minPrice from the current price
            int potentialProfit = prices[i] - minPrice;

            // If current price is smaller than the minimum price
            if (prices[i] < minPrice)
            {
                // Update minPrice 
                minPrice = prices[i];
            }
            // If potential profit is greater than the maximum profit
            if (potentialProfit > maxProfit)
            {
                // Update maxProfit
                maxProfit = potentialProfit;
            }
        }

        // Return maximum profit
        return maxProfit;
    }
}