using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> historico = new Stack<string>();
        string paginaAtual = null;

        while (true)
        {
            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Acessar uma nova página");
            Console.WriteLine("2 - Voltar à página anterior");
            Console.WriteLine("3 - Exibir página atual");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o endereço da nova página: ");
                    string novaPagina = Console.ReadLine();

                    if (paginaAtual != null)
                    {
                        historico.Push(paginaAtual);
                    }
                    paginaAtual = novaPagina;
                    Console.WriteLine($"Você acessou: {paginaAtual}");
                    break;

                case "2":
                    if (historico.Count > 0)
                    {
                        paginaAtual = historico.Pop();
                        Console.WriteLine($"Você voltou para: {paginaAtual}");
                    }
                    else
                    {
                        Console.WriteLine("Não há páginas anteriores no histórico!");
                    }
                    break;

                case "3":
                    if (paginaAtual != null)
                    {
                        Console.WriteLine($"Página atual: {paginaAtual}");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma página acessada ainda!");
                    }
                    break;

                case "4":
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
