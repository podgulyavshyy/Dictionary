namespace Dictionary;

public class Node
{
    
    public string Id { get; }
    public KeyValuePair Pair { get; set; }
    public Node Next { get; set; }

    public Node(string id, KeyValuePair pair)
    {
        Id = id;
        Pair = pair;
        Next = null;
    }
}