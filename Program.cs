using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        Stack<int> myStack = new Stack<int>();
        foreach (var num in numbers)
            myStack.Push(num);
        while (myStack.Count > 0)
        {
            Console.WriteLine(myStack.Pop());
        }
    }
}
