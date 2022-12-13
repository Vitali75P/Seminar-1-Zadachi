//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]       6, 1, 33 -> [6, 1, 33] Random r = new Random();
int[] GetArray (int length)
{
    int[] array = new int[length];
    Random r = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = r.Next(0, 50);
    }
    return array;
}

string GetArrayAsString(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}, ";
    }
    return result;
}
Console.WriteLine($"[{GetArrayAsString(GetArray(8))}]");
//
