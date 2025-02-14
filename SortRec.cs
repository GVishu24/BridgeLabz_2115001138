using System;
using System.Collections.Generic;

class SortStackRecursively
{
    // Function to sort stack using recursion
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count <= 1)
            return;

        // Step 1: Pop the top element
        int top = stack.Pop();

        // Step 2: Sort the remaining stack
        SortStack(stack);

        // Step 3: Insert the popped element back in sorted order
        InsertSorted(stack, top);
    }

    // Helper function to insert an element in a sorted manner
    private static void InsertSorted(Stack<int> stack, int element)
    {
        // Base Case: If stack is empty or element is greater than top element
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
            return;
        }

        // Remove the top element
        int top = stack.Pop();

        // Recursive call to insert in correct position
        InsertSorted(stack, element);

        // Push the removed element back
        stack.Push(top);
    }

    // Function to print stack
    public static void PrintStack(Stack<int> stack)
    {
        foreach (var item in stack)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(5);
        stack.Push(1);
        stack.Push(3);
        stack.Push(8);
        stack.Push(2);

        Console.WriteLine("Original Stack:");
        PrintStack(stack);

        SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        PrintStack(stack);
    }
}
