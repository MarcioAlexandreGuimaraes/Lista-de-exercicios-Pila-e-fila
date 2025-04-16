using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> filaDeClientes = new Queue<string>();
        string opcao;

        do
        {
            Console.WriteLine("\nSistema de Atendimento:");
            Console.WriteLine("1 - Adicionar cliente na fila");
            Console.WriteLine("2 - Atender próximo cliente");
            Console.WriteLine("3 - Exibir fila de clientes");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do cliente: ");
                    string cliente = Console.ReadLine();
                    filaDeClientes.Enqueue(cliente);
                    Console.WriteLine($"Cliente {cliente} adicionado à fila.");
                    break;

                case "2":
                    if (filaDeClientes.Count > 0)
                    {
                        string clienteAtendido = filaDeClientes.Dequeue();
                        Console.WriteLine($"Cliente atendido: {clienteAtendido}");
                    }
                    else
                    {
                        Console.WriteLine("Não há clientes na fila!");
                    }
                    break;

                case "3":
                    if (filaDeClientes.Count > 0)
                    {
                        Console.WriteLine("Clientes na fila:");
                        foreach (string c in filaDeClientes)
                        {
                            Console.WriteLine(c);
                        }
                    }
                    else
                    {
                        Console.WriteLine("A fila está vazia!");
                    }
                    break;

                case "4":
                    Console.WriteLine("Encerrando o sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        } while (opcao != "4");
    }
}
