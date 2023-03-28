namespace Dictionary;

public class LinkedList
{
    private Node head;
    private int count;

    public LinkedList()
    {
        head = null;
        count = 0;
    }

    public void Add(string id, KeyValuePair<string, string> pair)
    {
        Node newNode = new Node(id, pair);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        count++;
    }

    public bool RemoveByKey(string key)
    {
        if (head == null)
        {
            return false;
        }

        if (head.Pair.Key == key )
        {
            head = head.Next;
            count--;
            return true;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Pair.Key == key)
            {
                current.Next = current.Next.Next;
                count--;
                return true;
            }
            current = current.Next;
        }

        return false;
    }

    
    public int Count()
    {
        return count;
    }

    public KeyValuePair GetItemWithKey(string key)
    {
        Node current = head;
        
        while (current != null)
        {
            if (current.Pair.Key == key)
            {
                return current.Pair;
            }
            current = current.Next;
        }
        
        return null;
    }
}