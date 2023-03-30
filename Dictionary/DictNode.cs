namespace Dictionary;

public class DictNode
{
    public LinkedList List { get; set; } //stores linked list as data
    public DictNode Next { get; set; }

    public DictNode(LinkedList list)
    {
        //Id = id;
        List = list;
        Next = null;
    }
    
    
}