int[] intArray = { 6, 2, 7, 1, 8 };
double[] doubleArray = { 4.1, 4.8, 2.2, 1.5 };
string[] stringArray = { "red", "green", "blue", "dark" };
Console.WriteLine($"Минимальный элемент массива intArray: {FindMin<int>(intArray)}");
Console.WriteLine($"Минимальный элемент массива doubleArray: {FindMin<double>(doubleArray)}");
Console.WriteLine($"Минимальный элемент массива stringArray: {FindMin<string>(stringArray)}");
T FindMin<T>(T[] array) where T : IComparable<T>
{
    T min =array[0];
    foreach (T element in array)
    {
        if (element.CompareTo(min) < 0)
        {
            min = element;
        }
    }
    return min;
}
