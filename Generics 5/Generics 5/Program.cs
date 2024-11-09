global using System.Collections.Generic;
using Generics_5;

class Program
{
    static void Main(string[] args)
    {
        IStorage<int> intStorage = new ListStorage<int>();
        intStorage.Add(5);
        intStorage.Add(10);
        Console.WriteLine($"Первый элемент списка intStorage: {intStorage.Get(0)}");
        Console.WriteLine($"Второй элемент списка intStorage: {intStorage.Get(1)}");

        IStorage<string> stringStorage = new ListStorage<string>();
        stringStorage.Add("cat");
        stringStorage.Add("dog");
        Console.WriteLine($"Первый элемент списка stringStorage: {stringStorage.Get(0)}");
        Console.WriteLine($"Второй элемент списка stringStorage: {stringStorage.Get(1)}");
    }
}
