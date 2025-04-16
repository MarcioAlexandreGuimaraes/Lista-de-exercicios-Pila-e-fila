using System;
using System.Collections.Generic;

class Program
{
    static Stack<string> estacionamento = new Stack<string>();
    const int capacidade = 5;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Entrar no carro");
            Console.WriteLine("2. Sair do carro");
            Console.WriteLine("3. Mostrar estacionamento");
            Console.WriteLine("4. Sair do programa");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    EntrarCarro();
                    break;
                case "2":
                    SairCarro();
                    break;
                case "3":
                    MostrarEstacionamento();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void EntrarCarro()
    {
        if (estacionamento.Count >= capacidade)
        {
            Console.WriteLine("Estacionamento cheio!");
            return;
        }

        Console.Write("Digite a placa do carro: ");
        string placa = Console.ReadLine();
        estacionamento.Push(placa);
        Console.WriteLine($"Carro {placa} entrou no estacionamento.");
    }

    static void SairCarro()
    {
        if (estacionamento.Count == 0)
        {
            Console.WriteLine("Estacionamento vazio!");
            return;
        }

        Console.Write("Digite a placa do carro: ");
        string placa = Console.ReadLine();

        if (!estacionamento.Contains(placa))
        {
            Console.WriteLine("Carro não está no estacionamento.");
            return;
        }

        Stack<string> aux = new Stack<string>();

        while (estacionamento.Peek() != placa)
        {
            aux.Push(estacionamento.Pop());
        }

        estacionamento.Pop();
        Console.WriteLine($"Carro {placa} saiu do estacionamento.");

        while (aux.Count > 0)
        {
            estacionamento.Push(aux.Pop());
        }
    }

    static void MostrarEstacionamento()
    {
        if (estacionamento.Count == 0)
        {
            Console.WriteLine("Estacionamento vazio.");
            return;
        }

        Console.WriteLine("Carros no estacionamento:");
        foreach (var carro in estacionamento)
        {
            Console.WriteLine($"- {carro}");
        }
    }
}

