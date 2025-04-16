using System;
using System.Collections.Generic;

class Documento
{
    public string Nome { get; set; }
    public int Prioridade { get; set; } 

    public Documento(string nome, int prioridade)
    {
        Nome = nome;
        Prioridade = prioridade;
    }
}

class GerenciadorImpressao
{
    private Queue<Documento> filaAlta = new Queue<Documento>();
    private Queue<Documento> filaBaixa = new Queue<Documento>();

    public void AdicionarDocumento(string nome, int prioridade)
    {
        Documento doc = new Documento(nome, prioridade);
        if (prioridade == 1)
        {
            filaAlta.Enqueue(doc);
        }
        else
        {
            filaBaixa.Enqueue(doc);
        }
        Console.WriteLine($"Documento '{nome}' adicionado com prioridade {(prioridade == 1 ? "Alta" : "Baixa")}");
    }

    public void ImprimirProximo()
    {
        if (filaAlta.Count > 0)
        {
            Documento doc = filaAlta.Dequeue();
            Console.WriteLine($"Imprimindo documento (Alta): {doc.Nome}");
        }
        else if (filaBaixa.Count > 0)
        {
            Documento doc = filaBaixa.Dequeue();
            Console.WriteLine($"Imprimindo documento (Baixa): {doc.Nome}");
        }
        else
        {
            Console.WriteLine("Nenhum documento na fila de impressão.");
        }
    }

    public void MostrarFilas()
    {
        Console.WriteLine("\nFila Alta Prioridade:");
        foreach (var doc in filaAlta)
        {
            Console.WriteLine("- " + doc.Nome);
        }

        Console.WriteLine("\nFila Baixa Prioridade:");
        foreach (var doc in filaBaixa)
        {
            Console.WriteLine("- " + doc.Nome);
        }
    }
}

class Program
{
    static void Main()
    {
        GerenciadorImpressao gerenciador = new GerenciadorImpressao();

        gerenciador.AdicionarDocumento("Relatório Financeiro", 2);
        gerenciador.AdicionarDocumento("Urgente: Contrato", 1);
        gerenciador.AdicionarDocumento("Resumo de Reunião", 2);
        gerenciador.AdicionarDocumento("Urgente: Ata do Conselho", 1);

        gerenciador.MostrarFilas();

        Console.WriteLine("\nIniciando impressão:");
        for (int i = 0; i < 5; i++)
        {
            gerenciador.ImprimirProximo();
        }
    }
}
