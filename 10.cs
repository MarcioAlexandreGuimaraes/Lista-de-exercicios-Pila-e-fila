using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> fila = new Queue<int>();
        fila.Enqueue(10);
        fila.Enqueue(20);
        fila.Enqueue(30);
        fila.Enqueue(40);

        Console.WriteLine("Fila original:");
        Mostrar(fila);

        Inverter(fila);

        Console.WriteLine("Fila invertida:");
        Mostrar(fila);
    }

    static void Inverter(Queue<int> fila)
    {
        Stack<int> pilha = new Stack<int>();

        while (fila.Count > 0)
            pilha.Push(fila.Dequeue());

        while (pilha.Count > 0)
            fila.Enqueue(pilha.Pop());
    }

    static void Mostrar(Queue<int> fila)
    {
        foreach (int item in fila)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}
