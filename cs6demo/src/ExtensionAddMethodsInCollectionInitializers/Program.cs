using System;
using System.Collections.Generic;

namespace ExtensionAddMethodsInCollectionInitializers
{
    public class Program
    {
        public void Main(string[] args)
        {
            var list = new List<int> { "1", "2", "3" };

            Console.WriteLine(String.Join(", ", list));
        }
    }

    static class SomeCollectionExtensions
    {
        public static void Add(this List<int> list, string value)
        {
            list.Add(int.Parse(value));
        }
    }
}
