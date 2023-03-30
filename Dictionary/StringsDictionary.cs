using System.Collections.Specialized;

namespace Dictionary;

public class StringsDictionaryKSE
{
    private const int InitialSize = 10;

    private DictLinkedList _buckets = new DictLinkedList();

    // private LinkedList[] _buckets;

    public StringsDictionaryKSE()
    {
        //_buckets = new LinkedList[InitialSize]

        for (int i = 0; i < InitialSize; i++)
        {
            LinkedList temp = new LinkedList();
            _buckets.Add(temp);
        }
    }
        
    public void Add(string key, string value)
    {
        int temp = CalculateHash(key);

        var pair = new KeyValuePair(temp.ToString(), value);
        int leastElements = 0;
        
        DictNode curr = _buckets.head;
        LinkedList actual = curr.List;
        while (curr != null)
        {
            if (curr.List.Count() < leastElements)
            {
                leastElements = curr.List.Count();
                actual = curr.List;
            }

            curr = curr.Next;
        }
        actual.Add(pair);
    }

    public void Remove(string key)
    {
        int temp = CalculateHash(key);
        DictNode curr = _buckets.head;
        while (curr != null)
        {
            curr.List.RemoveByKey(temp.ToString());

            curr = curr.Next;
        }
    }

    public string Get(string key)
    {
        int temp = CalculateHash(key);
        DictNode curr = _buckets.head;
        while (curr != null)
        {
            return curr.List.GetItemWithKey(temp.ToString()).Value;
            
            curr = curr.Next;
        }
        return "Not found";
    }


    private int CalculateHash(string key)
    {
        // function to convert string value to number 
        // to do
        return key.GetHashCode(); // placeholder
    }
}