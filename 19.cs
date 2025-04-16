using System;
using System.Collections.Generic;

class Editor
{
    private Stack<string> desfazer = new Stack<string>();
    private Stack<string> refazer = new Stack<string>();
    private string estadoAtual = "";

    public void Digitar(string texto)
    {
        desfazer.Push(estadoAtual);
        estadoAtual += texto;
        refazer.Clear();
        Console.WriteLine("Texto atual: " + estadoAtual);
    }

    public void Desfazer()
    {
        if (desfazer.Count == 0)
        {
            Console.WriteLine("Nada para desfazer.");
            return;
        }

        refazer.Push(estadoAtual);
        estadoAtual = desfazer.Pop();
        Console.WriteLine("Texto atual: " + estadoAtual);
    }

    public void Refazer()
    {
        if (refazer.Count == 0)
        {
            Console.WriteLine("Nada para refazer.");
            return;
        }

        desfazer.Push(estadoAtual);
        estadoAtual = refazer.Pop();
        Console.WriteLine("Texto atual: " + estadoAtual);
    }

    public void Mostrar()
    {
        Console.WriteLine("Texto atual: " + estadoAtual);
    }
}

class Program
{
    static void Main()
    {
        Editor editor = new Editor();
        while (true)
        {
            Console.WriteLine("\n1. Digitar texto");
            Console.WriteLine("2. Desfazer");
            Console.WriteLine("3. Refazer");
            Console.WriteLine("4. Mostrar texto");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o texto: ");
                    string texto = Console.ReadLine();
                    editor.Digitar(texto);
                    break;
                case "2":
                    editor.Desfazer();
                    break;
                case "3":
                    editor.Refazer();
                    break;
                case "4":
                    editor.Mostrar();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}


