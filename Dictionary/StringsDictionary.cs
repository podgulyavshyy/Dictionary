namespace Dictionary;

public class StringsDictionary
{
    private const int InitialSize = 10;

    private LinkedList[] _buckets = new LinkedList[InitialSize];
        
    public void Add(string key, string value)
    {
            
    }

    public void Remove(string key)
    {
            
    }

    public string Get(string key)
    {
        return ""; // placeholder
    }


    private int CalculateHash(string key)
    {
        // function to convert string value to number 
        return 10; // placeholder
    }
}