using System;
using System.Collections.Generic;
using System.Linq;

public class FilaPrioridade<T>
{
    private List<(T Item, int Prioridade)> _itens;

    public FilaPrioridade()
    {
        _itens = new List<(T, int)>();
    }

    public void Enqueue(T item, int prioridade)
    {
        _itens.Add((item, prioridade));
        _itens = _itens.OrderByDescending(x => x.Prioridade).ToList();  (maior primeiro)
    }

    public T Dequeue()
    {
        if (_itens.Count == 0)
            throw new InvalidOperationException("A fila está vazia.");

        var item = _itens[0].Item;
        _itens.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (_itens.Count == 0)
            throw new InvalidOperationException("A fila está vazia.");

        return _itens[0].Item; 
    }

    public int Count => _itens.Count;
}





