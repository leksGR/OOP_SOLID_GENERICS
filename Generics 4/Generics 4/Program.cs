int a = 3, b = 4;
Console.WriteLine($"До обмена: a = {a}; b = {b}");
Swap<int>(ref a, ref b);
Console.WriteLine($"После обмена: a = {a}; b = {b}");

double c = 3.3, d = 4.6;
Console.WriteLine($"До обмена: c = {c}; d = {d}");
Swap<double>(ref c, ref d);
Console.WriteLine($"После обмена: c = {c}; d = {d}");

static void Swap<T>(ref T x, ref T y)
{
    T temp = x;
    x = y;
    y = temp;
}
