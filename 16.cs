using System;

class Deque<T>
{
    private T[] itens;
    private int inicio;
    private int fim;
    private int tamanho;
    private int capacidade;

    public Deque(int capacidade)
    {
        this.capacidade = capacidade;
        itens = new T[capacidade];
        inicio = -1;
        fim = 0;
        tamanho = 0;
    }

    public bool EstaVazio()
    {
        return tamanho == 0;
    }

    public bool EstaCheio()
    {
        return tamanho == capacidade;
    }

    public void InserirInicio(T item)
    {
        if (EstaCheio()) throw new InvalidOperationException("Deque cheio");

        if (inicio == -1)
        {
            inicio = 0;
            fim = 0;
        }
        else if (inicio == 0)
        {
            inicio = capacidade - 1;
        }
        else
        {
            inicio--;
        }

        itens[inicio] = item;
        tamanho++;
    }

    public void InserirFim(T item)
    {
        if (EstaCheio()) throw new InvalidOperationException("Deque cheio");

        if (inicio == -1)
        {
            inicio = 0;
            fim = 0;
        }
        else if (fim == capacidade - 1)
        {
            fim = 0;
        }
        else
        {
            fim++;
        }

        itens[fim] = item;
        tamanho++;
    }

    public T RemoverInicio()
    {
        if (EstaVazio()) throw new InvalidOperationException("Deque vazio");

        T valor = itens[inicio];
        if (inicio == fim)
        {
            inicio = -1;
            fim = 0;
        }
        else if (inicio == capacidade - 1)
        {
            inicio = 0;
        }
        else
        {
            inicio++;
        }

        tamanho--;
        return valor;
    }

    public T RemoverFim()
    {
        if (EstaVazio()) throw new InvalidOperationException("Deque vazio");

        T valor = itens[fim];
        if (inicio == fim)
        {
            inicio = -1;
            fim = 0;
        }
        else if (fim == 0)
        {
            fim = capacidade - 1;
        }
        else
        {
            fim--;
        }

        tamanho--;
        return valor;
    }

    public void Mostrar()
    {
        if (EstaVazio())
        {
            Console.WriteLine("Deque vazio");
            return;
        }

        int i = inicio;
        Console.Write("Deque: ");
        while (true)
        {
            Console.Write(itens[i] + " ");
            if (i == fim) break;
            i = (i + 1) % capacidade;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Deque<int> deque = new Deque<int>(5);
        deque.InserirFim(10);
        deque.InserirFim(20);
        deque.InserirInicio(5);
        deque.Mostrar();
        deque.RemoverFim();
        deque.Mostrar();
        deque.RemoverInicio();
        deque.Mostrar();
    }
}

