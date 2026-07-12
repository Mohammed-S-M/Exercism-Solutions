public class Deque<T>
{
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public int Length { get; set; }
    
    public class Node 
    {
        public T Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(T value) 
        {
            Value = value;
        } 
    }
    
    public void Push(T value)
    {
        Node newNode = new Node(value);

        if (Length == 0) 
        {
            Head = newNode;
            Tail = newNode;
        }
        else 
        {
            newNode.Prev = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }

        Length++;
    }

    public T Pop()
    {
        if (Length == 0) return default;

        Node temp = Tail;

        if (Length == 1) 
        {
            Head = null;
            Tail = null;
        }
        else 
        {
            Tail = Tail.Prev;
            Tail.Next = null;
            temp.Prev = null;
        }

        Length--;
        return temp.Value;
    }

    public void Unshift(T value)
    {
        Node newNode = new Node(value);

        if (Length == 0) 
        {
            Head = newNode;
            Tail = newNode;
        }
        else 
        {
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
        }

        Length++;
    }

    public T Shift()
    {
        if (Length == 0) return default;

        Node temp = Head;

        if (Length == 1)
        {
            Head = null;
            Tail = null;
        }
        else 
        {
            Head = Head.Next;
            Head.Prev = null;
            temp.Next = null;
        }

        Length--;
        return temp.Value;
    }
}