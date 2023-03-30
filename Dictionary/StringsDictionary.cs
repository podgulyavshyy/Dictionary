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
        return GetClosest(key);
    }

    
    private string GetClosest(string wordStart)
    {
        /*string[] letters = new[]
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z"
        };*/
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string test = "";
        for (int i = 0; i < letters.Length; i++)
        {
            test = wordStart.Replace(wordStart[0], letters[i]);
            if (this.Get(test) != "No")
            {
                return test;
            }
        }
        return "No similarities";
    }
    
    private int CalculateHash(string key)
    {
        // function to convert string value to number 
        // to do
        return key.GetHashCode(); // placeholder
    }
}