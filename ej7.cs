using System;
using System.Collections;

class Program7
{
    static bool linearSearch(ArrayList list, int num)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if ((int)list[i] == num)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList() { 2, 10, 15, 33 };
        int target = 23;

        if (linearSearch(list, target))
        {
            Console.WriteLine("numero encontrado");
        }
        else
        {
            Console.WriteLine("numero no encontrado");
        };
    }
}