﻿// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
namespace Dictionary;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Working...");
        StringsDictionaryKSE dict = new StringsDictionaryKSE();
       
        

        string[] words = File.ReadAllLines("../../dictionary.txt");
        // int t = 0;
        foreach (var word in words)
        {   
            
            string[] splitted = word.Split(new[] { ';' }, 2);
            // t++;
            dict.Add(splitted[0], splitted[1]);
        }
        
        
        
        // Console.WriteLine(t);
        // Console.WriteLine(dict.Get("CAR"));
        while (true)
        {
            Console.WriteLine("Enter word(caps): ");
            var input = Console.ReadLine();
            Console.WriteLine(dict.Get(input));
        }
    }
}
