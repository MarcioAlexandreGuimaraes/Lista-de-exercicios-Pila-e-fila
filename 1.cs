using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
  
        Stack<int> pilha = new Stack<int>();

  
        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(3);
        pilha.Push(4);
        pilha.Push(5);

     
        Console.WriteLine("Elementos da pilha:");

        foreach (int elemento in pilha)
        {
            Console.WriteLine(elemento);
        }
    }
}


