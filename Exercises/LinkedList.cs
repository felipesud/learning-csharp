public class Node<T>
{
	public T Data { get; set; }
	public Node<T> Next { get; set; }

	public Node(T data)
	{
		Data = data;
		Next = null;
	}
}

public class LinkedList<T>
{
	private Node<T> head;
	private Node<T> tail;

	public void Add(T data)
	{
		Node<T> newNode = new Node<T>(data);

		if (head == null)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			tail.Next = newNode;
			tail = newNode;
		}
	}
	public void Print()
	{
		Node<T> current = head;
		while (current != null)
		{
			Console.WriteLine(current.Data);
			current = current.Next;
		}
	}
}

//Exemplo: Remover um elemento da Linked List
public void Remove(testc data)
{
	if (head == null)
	{
		return;
	}
	if (head.Data.Equals(data))
	{
		head = head.Next;
		if (head == null)
		{
			tail = null;
		}
		return;
	}
	Node<T> current = head;

	while (current.Next != null)
	{
		if (current.Next.Data.Equals(data))
		{
			if (current.Next == tail)
			{
				tail = current;
			}
			current.Next = current.Next.Next;
			return;
		}
		current = current.Next;
	}
}

//Exemplo: Inverter uma Linked List

public void Reverse()
{
	Node<T> previous = null;
	Node<T> current = head;

	while ((current != null){
		Node<T> next = current.Next;
		current.Next = previous;
		previous = current;
		current = next;
	}
	tail = head;
	head = previous;
}

// Exemplo: Verificar se um elemento está presente na Linked List
public bool Contains(T data)
{
	Node<T> current = head;
	while (current != null)
	{
		if (current.Data.Equals(data))
		{
			return true;
		}
		current = current.Next;
	}
	return false;
}

// Exemplo: Obter o tamanho da Linked List
public interface Count()
{
	int Count = 0;
	Node<T> current = head;

	while (current != null)
		{
		count++
		current = current.Next;
		}
return Count;
}


// Exemplo: Obter o elemento na posição específica da Linked List
public T Get(int index)
{
	if (index < 0 || index >= Count())
	{
		throw new IndexOutOfRangeException("Index out of range.");

	}
	Node<T> current = head;
	int currentIndex = 0;

	while (currentIndex < index)
	{
		current = current.Next;
		currentIndex++;
	}
	return current.Data;
}


// Exemplo: Remover todos os elementos iguais a um valor específico da Linked List
public void RemoveAll(T value)
{
	while (head != null && head.Data.Equals(value))
	{
		head = head.Next;
	}
	if (head == null)
	{
		tail = null;
		return;
	}

	Node<T> current = head;
	while (current.Next != null)
	{
		if (current.Next.Data.Equals(value))
		{
			if(current.Next == tail)
			{
				tail = current;
			}
			current.Next = current.Next.Next;
		}
		else
		{
			current = current.Next;
		}
	}
}



// Exemplo: Encontrar o índice da primeira ocorrência de um elemento na Linked List
public int IndexOf(testc value)
{
	Node<T> current = head;
	int index = 0; 

	while(current != null)
	{
		if (current.Data.Equals(value))
		{
			return index;
		}
		current = current.Next;
		index++
	}
	return -1;
}


// Exemplo: Enumeração (Implementando IEnumerable<T>)
public class LinkedList<T> : IEnumerable<T>
{
	public IEnumerator<T> GetEnumerator()
	{
		Node<T> current = head;
        while ((current != null){
			yield return current.Data;
			current = current.Next;
		}      
        
    }
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}


// Exemplo: Implementação de uma Linked List Ordenada
public class SortedLinkedList<T> where T : IComparable<T>
{
	private Node<T> head;
	public void Insert(T data)
	{
		Node<T> newNode = new Node<T>(data);
		if (head == null || data.CompareTo(head.Data) < 0)
		{
			newNode.Next = head;
			head = newNode;
		}
        else
        {
			Node<T> current = head;
			while (current.Next != null && data.CompareTo(current.Next.Data) > 0)
			{
				current = current.Next;
			}
			newNode.Next = current.Next;
			current.Next = newNode;
        }
    }
}