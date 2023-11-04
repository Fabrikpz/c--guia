//no anda
using System;
using System.Collections.Generic;

class Program5
{
    public static void Main()
    {
        RunProgram();
    }

    public static void RunProgram()
    {
        Queue<int> myQueue = new Queue<int>();
        Queue<int> colaOrdenada = new Queue<int>();

        Console.WriteLine("Pone el nro de elems q vas a agregar a la cola:");
        int cantDeElems = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantDeElems; i++)
        {
            Console.Write($"Ingrese el valor {i + 1}: ");
            int value = int.Parse(Console.ReadLine());
            myQueue.Enqueue(value);
        }

        Console.WriteLine("Ahora pone 1 o -1: ");
        int nro = int.Parse(Console.ReadLine());
        while (myQueue.Count > 0)
        {
            int num = myQueue.Dequeue();

            if (myQueue.Count > 0)
            {
                int num2 = myQueue.Dequeue();
                if (nro == 1 && num > num2)
                {
                    colaOrdenada.Enqueue(num2);
                    myQueue.Enqueue(num);
                }
                else if (nro == -1 && num < num2)
                {
                    colaOrdenada.Enqueue(num2);
                    myQueue.Enqueue(num);
                }
                else
                {
                    colaOrdenada.Enqueue(num);
                    myQueue.Enqueue(num2);
                }
            }
            else
            {
                colaOrdenada.Enqueue(num);
            }
        }

        while (colaOrdenada.Count > 0)
        {
            Console.WriteLine(colaOrdenada.Dequeue());
        }
    }
}