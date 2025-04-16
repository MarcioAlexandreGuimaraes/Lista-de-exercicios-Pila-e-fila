using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite a sequência de parênteses: ");
        string sequencia = Console.ReadLine();
        bool balanceada = VerificarBalanceamento(sequencia);
        Console.WriteLine(balanceada ? "Sequência balanceada." : "Sequência não balanceada.");
    }

    static bool VerificarBalanceamento(string sequencia)
    {
        Stack<char> pilha = new Stack<char>();

        foreach (char c in sequencia)
        {
            if (c == '(')
            {
                pilha.Push(c);
            }
            else if (c == ')')
            {
                if (pilha.Count == 0)
                    return false;
                pilha.Pop();
            }
        }

        return pilha.Count == 0;
    }
}

