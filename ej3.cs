using System;
using System.Collections.Generic;

class Program3
{
    public static void Main()
    {
        RunQueueProgram();
    }

    public static void RunQueueProgram()
    {
        Queue<int> myQueue = new Queue<int>();

        Console.WriteLine("Ingrese el número de elementos que desea agregar a la cola:");
        int cantDeElems = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantDeElems; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            int value = int.Parse(Console.ReadLine());
            myQueue.Enqueue(value);
        }
        Console.WriteLine("Números pares en la cola:");
        foreach (int nro in myQueue)
        {
            if (nro % 2 == 0)
            {
                Console.WriteLine(nro);
            }
        }
    }
}