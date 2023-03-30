namespace Dictionary;

public class DictLinkedList
{
    public DictNode head { get; set; }
    private int count;

    public DictLinkedList()
    {
        head = null;
        count = 0;
    }
    
    public void Add(LinkedList list)
    {
        DictNode newNode = new DictNode(list);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            DictNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        count++;
    }
}