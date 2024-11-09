using Generics_1;

class Program
{
    static void Main(string[] args)
    {
        Pair<int, string> pair = new Pair<int, string> ( 21, "Созданный пароль" );
        Console.WriteLine($"Текущий Id: {pair.GetId()}");
        Console.WriteLine($"Текущий пароль: {pair.GetPassword()}");
        pair.ChangeId(50);
        pair.ChangePassword("Измененный пароль");
        Console.WriteLine($"Текущий Id: {pair.GetId()}");
        Console.WriteLine($"Текущий пароль: {pair.GetPassword()}");
    }
}