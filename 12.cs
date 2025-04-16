using System;
using System.Collections.Generic;

public class ConversorDecimalBinario
{
    public static string ConverterParaBinario(int numeroDecimal)
    {
        if (numeroDecimal == 0) return "0";
        
        Stack<int> pilha = new Stack<int>();

        while (numeroDecimal > 0)
        {
            pilha.Push(numeroDecimal % 2);
            numeroDecimal /= 2;
        }

        char[] binario = new char[pilha.Count];
        int i = 0;
        
        while (pilha.Count > 0)
        {
            binario[i++] = pilha.Pop().ToString()[0];
        }

        return new string(binario);
    }

    public static void Main()
    {
        Console.Write("Digite um número decimal: ");
        int numeroDecimal = int.Parse(Console.ReadLine());
        string binario = ConverterParaBinario(numeroDecimal);
        Console.WriteLine($"O número binário é: {binario}");
    }
}



