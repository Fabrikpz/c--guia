using System;
using System.Collections;
using System.Linq;

class Program8
{
    static void SelectionSort(ArrayList list)
    {
        int length = list.Count;
        for (int i = 0; i < length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < length; j++)
            {
                if ((int)list[j] < (int)list[minIndex])
                {
                    minIndex = j;
                }
            }
            object temp = list[i];
            list[i] = list[minIndex];
            list[minIndex] = temp;
        }
    }

    public static void Main(string[] args)
    {
        ArrayList nums = new ArrayList() { 6, 2, 5, 12, 8 };
        SelectionSort(nums);

        Console.WriteLine("ArrayList ordenado:");
        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
    }
}
