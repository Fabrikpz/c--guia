using System;
using System.Collections.Generic;

class Program4
{
    public static void Main()
    {
        esPalindromo();
    }

    public static void esPalindromo()
    {
        Console.WriteLine("Ingrese palabra: ");
        string input = Console.ReadLine();
        Queue<char> palabraQueue = new Queue<char>();
        Queue<char> palabraQueueInvertida = new Queue<char>();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            palabraQueueInvertida.Enqueue(input[i]);
        }

        foreach (var character in input)
        {
            palabraQueue.Enqueue(character);
        }

        if (palabraQueue == palabraQueueInvertida)
        {
            Console.WriteLine("es palin");
        }
        else
        {
            Console.WriteLine("no es palin");
        }
    }
}