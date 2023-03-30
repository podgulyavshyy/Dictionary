// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
namespace Dictionary;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        StringsDictionaryKSE test = new StringsDictionaryKSE();
        test.Add("one","onevalue");
        test.Add("two","twovalue");
        test.Add("three","threevalue");
        test.Add("four","fourvalue");
        test.Add("five","fivevalue");
        test.Add("six","sixvalue");
        Console.WriteLine("Hello, World!");
        var one = test.Get("one");
        
        Console.WriteLine(one);
    }
}
