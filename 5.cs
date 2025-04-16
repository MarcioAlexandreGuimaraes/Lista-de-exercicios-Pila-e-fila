using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();

     
        Stack<char> pilha = new Stack<char>();

    
        foreach (char letra in palavra)
        {
            pilha.Push(letra);
        }

    
        Console.WriteLine("Palavra invertida:");
        while (pilha.Count > 0)
        {
            Console.Write(pilha.Pop());
        }

        Console.WriteLine(); 
    }
}

