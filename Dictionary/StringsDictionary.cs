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
        double loadFactor = GetLoadFactor();
        if (loadFactor >= 0.8)
        {
            int newSize = _buckets.Length * 2;
            var newBuckets = new LinkedList[newSize];
            for (int i = 0; i < newSize; i++)
            {
                newBuckets[i] = new LinkedList();
            }
            foreach (var bucket in _buckets)
            {
                while(bucket.head != null){
                    
                    var pair = bucket.head.Pair;
                    int hash = Math.Abs(CalculateHash(pair.Key));
                    int idx = hash % newSize;
                    newBuckets[idx].Add(pair);
                    bucket.head = bucket.head.Next;
                }
            }
            _buckets = newBuckets;
        }
        int bucketIndex = Math.Abs(CalculateHash(key)) % _buckets.Length;
        _buckets[bucketIndex].Add(new KeyValuePair(key, value));

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
    }
    
    public double GetLoadFactor()
    {
        int count = 0;
        foreach (var bucket in _buckets)
        {
            count += bucket.Count();
        }
        return (double)count / _buckets.Length;
    }
    private int CalculateHash(string key)
    {
        return key.GetHashCode(); // to do
    }
}