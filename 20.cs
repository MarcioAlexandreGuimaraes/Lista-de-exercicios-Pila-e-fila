using System;
using System.Collections.Generic;

class LRUCache
{
    private int capacidade;
    private Queue<int> fila;
    private HashSet<int> conjunto;

    public LRUCache(int capacidade)
    {
        this.capacidade = capacidade;
        fila = new Queue<int>();
        conjunto = new HashSet<int>();
    }

    public void Acessar(int elemento)
    {
        if (conjunto.Contains(elemento))
        {
            Queue<int> novaFila = new Queue<int>();
            foreach (var item in fila)
            {
                if (item != elemento)
                    novaFila.Enqueue(item);
            }
            novaFila.Enqueue(elemento);
            fila = novaFila;
        }
        else
        {
            if (fila.Count >= capacidade)
            {
                int removido = fila.Dequeue();
                conjunto.Remove(removido);
            }
            fila.Enqueue(elemento);
            conjunto.Add(elemento);
        }

        MostrarCache();
    }

    public void MostrarCache()
    {
        Console.Write("Cache: ");
        foreach (var item in fila)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        LRUCache cache = new LRUCache(3);
        cache.Acessar(1);
        cache.Acessar(2);
        cache.Acessar(3);
        cache.Acessar(2);
        cache.Acessar(4);
        cache.Acessar(1);
        cache.Acessar(5);
    }
}


