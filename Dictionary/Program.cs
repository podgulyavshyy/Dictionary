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
        Console.WriteLine("Hello, World!");
        var one = test.Get("one");
        
        Console.WriteLine(one);
    }
}
