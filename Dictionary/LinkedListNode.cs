namespace Dictionary;

public class Node
{
    public string Id { get; }
    public KeyValuePair<string, string> Pair { get; set; }
    public Node Next { get; set; }

    public Node(string id, string key, string value)
    {
        Id = id;
        Pair = new KeyValuePair<string, string>(key, value);
        Next = null;
    }
}