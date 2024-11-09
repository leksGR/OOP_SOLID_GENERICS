global using System.Collections.Generic;
using Generics_3;
class Program
{
    static void Main(string[] args)
    {
        Repository<Emloyee> repository = new Repository<Emloyee>();
        repository.Add(new Emloyee("Ben"));
        repository.Add(new Emloyee("Tom"));
        Console.WriteLine($"Первый элемент коллецкции: {(repository.Get(0)).Name}");
        Console.WriteLine($"Второй элемент коллецкции: {(repository.Get(1)).Name}");
    }
}