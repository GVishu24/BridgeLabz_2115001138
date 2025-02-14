using System;
using System.Collections.Generic;

class StockSpanProblem
{
    public static int[] CalculateStockSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>(); 

        for (int i = 0; i < n; i++)
        {
            // Pop elements from stack while stack is not empty and top price <= current price
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                stack.Pop();

            // If stack is empty, all previous prices are smaller, so span = i + 1
            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

            // Push current index onto stack
            stack.Push(i);
        }

        return span;
    }

    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

        int[] span = CalculateStockSpan(prices);

        Console.WriteLine("Stock Prices: " + string.Join(", ", prices));
        Console.WriteLine("Span Values:  " + string.Join(", ", span));
    }
}
