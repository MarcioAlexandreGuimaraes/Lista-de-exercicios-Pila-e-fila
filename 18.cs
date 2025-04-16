using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expressao = "3 4 + 2 *";
        double resultado = AvaliarPosfixada(expressao);
        Console.WriteLine("Resultado: " + resultado);
    }

    static double AvaliarPosfixada(string expressao)
    {
        Stack<double> pilha = new Stack<double>();
        string[] tokens = expressao.Split(' ');

        foreach (string token in tokens)
        {
            if (double.TryParse(token, out double numero))
            {
                pilha.Push(numero);
            }
            else
            {
                double b = pilha.Pop();
                double a = pilha.Pop();
                switch (token)
                {
                    case "+": pilha.Push(a + b); break;
                    case "-": pilha.Push(a - b); break;
                    case "*": pilha.Push(a * b); break;
                    case "/": pilha.Push(a / b); break;
                }
            }
        }

        return pilha.Pop();
    }
}

