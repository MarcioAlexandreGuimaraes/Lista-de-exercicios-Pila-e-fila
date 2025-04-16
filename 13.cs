public class FilaCircular<T>
{
    private T[] _itens;
    private int _inicio;
    private int _fim;
    private int _count;

    public FilaCircular(int capacidade)
    {
        _itens = new T[capacidade];
        _inicio = 0;
        _fim = 0;
        _count = 0;
    }

    public void Enqueue(T item)
    {
        if (_count == _itens.Length)
            throw new InvalidOperationException("A fila está cheia.");

        _itens[_fim] = item;
        _fim = (_fim + 1) % _itens.Length;
        _count++;
    }

    public T Dequeue()
    {
        if (_count == 0)
            throw new InvalidOperationException("A fila está vazia.");

        var item = _itens[_inicio];
        _inicio = (_inicio + 1) % _itens.Length;
        _count--;
        return item;
    }

    public T Peek()
    {
        if (_count == 0)
            throw new InvalidOperationException("A fila está vazia.");

        return _itens[_inicio];
    }

    public int Count
    {
        get { return _count; }
    }
}




