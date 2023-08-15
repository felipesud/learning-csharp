public class Stack<T>
{
    private List<T> data;
    public Stack()
    {
        data = new List<T>]();
    }
    public void Push(T item)
    {
        data.Add(item);
    }
    public T Pop()
    {
        if (data.Count == 0)
        {
            throw new InvalidOperationException("a pilha está vazia");
        }
        int lastIndex = data.Count - 1;
        T item = data[lastIndex];
        data.RemoveAt(lastIndex);
        return item;
    }
    public T Peek()
    {
        if (data.Count == 0)
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }
        return data[data.Count - 1];
    }
    public bool IsEmpty()
    {
        return data.Count == 0;
    }
}


// Exemplo: Implementação de uma Queue (fila)
public class Queue<T>
{
    private LinkedInList<T> data;
    public Queue()
    {
        data = new LinkedList<T>();
    }
    public void Enqueue(T item)
    {
        throw new InvalidOperationException("A fila está vazia");
    }
    T item = data.First.Value;
    data.RemoveFirst();
        return item;
}
public T Peek()
{
    if (data.Count == 0)
    {
        throw new InvalidOperationException("A fila está vazia");
    }
    return data.First.Value;
}
public bool IsEmpty()
{
    return data.Count == 0;
}

// Exemplo: Implementação de uma Stack (pilha) usando um array
public class Stack<T>
{
    private T[] data;
    private int top;
    public Stack(int capacity)
    {
        data = new T[capacity];
        top = -1;
    }
    public void Push(T item)
    {
        if (top == data.Length - 1)
        {
            throw new InvalidOperationException("A pilha está cheia.");
        }
        top++;
        data[top] = item;
    }
    public T Pop()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }
        T item = data[top];
        top--;
        return item;
    }
    public T Peek()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }
        return bool IsEmpty(){
            return top == -1;
        }
    }
}



//Exemplo: Implementação de uma Queue (fila) usando um array circular
public class Queue<T>
{
    private T[] data;
    private int front;
    private int rear;
    private int count;

    public Queue(int capacity)
    {
        data = new T[capacity];
        front = 0;
        rear = -1;
        count = 0;
    }
    public void Enqueue(T item)
    {
        if (count == data.Length)
        {
            throw new InvalidOperationException("a fila está cheia.");
        }
        rear = (rear + 1) % data.Length;
        data[rear] = item;
        count++;
    }
    public T Dequeue()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }
        T item = data[front];
        front = (front + 1) % data.Length;
        count--;
        return item;
    }
    public T Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("A fila está vazia.")
        }
        return data[front];
    }
    public bool IsEmpty()
    {
        return count == 0;
    }
}