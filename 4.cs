using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Queue<string> fila = new Queue<string>();

     
        Console.WriteLine("A fila está vazia? " + (fila.Count == 0));

   
        fila.Enqueue("Ana");
        fila.Enqueue("Carlos");
        fila.Enqueue("Beatriz");

    
        Console.WriteLine("A fila está vazia? " + (fila.Count == 0));

   
        Console.WriteLine("Elementos na fila:");
        foreach (string elemento in fila)
        {
            Console.WriteLine(elemento);
        }
    }
}



