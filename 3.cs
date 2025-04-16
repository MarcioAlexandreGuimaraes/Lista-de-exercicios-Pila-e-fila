using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
     
        Stack<int> pilha = new Stack<int>();

     
        Console.WriteLine("A pilha está vazia? " + (pilha.Count == 0));

       
        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(3);

  
        Console.WriteLine("A pilha está vazia? " + (pilha.Count == 0));

    
        Console.WriteLine("Elementos na pilha:");
        foreach (int elemento in pilha)
        {
            Console.WriteLine(elemento);
        }
    }
}



