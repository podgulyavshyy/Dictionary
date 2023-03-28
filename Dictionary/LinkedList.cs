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

    public bool Remove(string id)
    {
        if (head == null)
        {
            return false;
        }

        if (head.Id == id )
        {
            head = head.Next;
            count--;
            return true;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Id == id)
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
        // get pair with provided key, return null if not found
        return new KeyValuePair("", ""); // placeholder
    }
}