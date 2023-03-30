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
        int hash = Math.Abs(CalculateHash(key));
        var idx = hash % InitialSize;

        var pair = new KeyValuePair(key, value);
        
        _buckets[idx].Add(pair);
        
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
        var temp = key;
        var val = "";
        for (int i = 0; i < _buckets.Length; i++)
        {
            if (_buckets[i].GetItemWithKey(temp.ToString()).Value != "not found")
            {
                return _buckets[i].GetItemWithKey(temp.ToString()).Value;
            }
        }
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string test = temp;
        foreach (var letter in letters)
        {
            test = temp.Replace(temp[0], letter);
            for (int i = 0; i < _buckets.Length; i++)
            {
                if (_buckets[i].GetItemWithKey(test.ToString()).Value != "not found")
                {
                    return _buckets[i].GetItemWithKey(test.ToString()).Value;
                }
            }
        }
        return "No similarities";
        
        
        // return GetClosest(key);
    }

    private int CalculateHash(string key)
    {
        // function to convert string value to number 
        // to do
        return key.GetHashCode(); // placeholder
    }
}