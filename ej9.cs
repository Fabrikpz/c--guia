using System;
using System.Collections;

class Program9
{
    static void bubbleSort(ArrayList list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if ((int)list[j] > (int)list[j + 1])
                {
                    int temp = (int)list[j];
                    list[j] = (int)list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        ArrayList nums = new ArrayList() { 9, 2, 5, 12, 8 };
        bubbleSort(nums);

        Console.WriteLine("ArrayList ordenado:");
        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
    }
}
