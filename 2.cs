using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        Queue<string> fila = new Queue<string>();

   
        fila.Enqueue("Ana");
        fila.Enqueue("Carlos");
        fila.Enqueue("Beatriz");
        fila.Enqueue("Daniel");

       
        Console.WriteLine($"Elemento removido: {fila.Dequeue()}");

    
        Console.WriteLine("Elementos restantes na fila:");
        foreach (string nome in fila)
        {
            Console.WriteLine(nome);
        }
    }
}



