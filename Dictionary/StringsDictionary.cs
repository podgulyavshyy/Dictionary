using System.Collections.Specialized;

namespace Dictionary;

public class StringsDictionaryKSE
{
    private const int InitialSize = 10;

    private LinkedList[] _buckets = new LinkedList[InitialSize];

    public StringsDictionaryKSE()
    {

        for (int i = 0; i < InitialSize; i++)
        {
            LinkedList temp = new LinkedList();
            _buckets[i] = temp;
        }
    }
        
    public void Add(string key, string value)
    {
        int temp = CalculateHash(key);

        var pair = new KeyValuePair(temp.ToString(), value);
        
        int numElements = _buckets.Sum(t => t.Count());

        int test = 0;
        if (numElements != 0)
        {
            test = temp % numElements;
        }
        for (int i = 0; i < _buckets.Length; i++)
        {
            if (Math.Abs(test) == i)
            {
                _buckets[i].Add(pair);
                break;
            }
        }
        
        // actual.Add(pair);
    }

    public void Remove(string key)
    {
        int temp = CalculateHash(key);
        for (int i = 0; i < _buckets.Length; i++)
        {
            _buckets[i].RemoveByKey(temp.ToString());
        }
    }

    public string Get(string key)
    {
        int temp = CalculateHash(key);
        var val = "";
        for (int i = 0; i < _buckets.Length; i++)
        {
            if (_buckets[i].GetItemWithKey(temp.ToString()).Value != "not found")
            {
                return _buckets[i].GetItemWithKey(temp.ToString()).Value;
            }
        }
        return "No";
    }


    private int CalculateHash(string key)
    {
        // function to convert string value to number 
        // to do
        return key.GetHashCode(); // placeholder
    }
}