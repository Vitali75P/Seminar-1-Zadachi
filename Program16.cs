//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Задайте размер массива!");
int[] array = GetArray(ReadInt());
Console.WriteLine(GetArrayAsString(array));

Console.WriteLine($"Максимальное значение {GetMaxValue(array)}");
Console.WriteLine($"Минимальное значение {GetMinValue(array)}");
Console.WriteLine($"Разница между значениями составит {(GetMaxValue(array) - GetMinValue(array))}");


int[] GetArray (int length)
{
    int[] array = new int[length];

    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(10, 100);
    }
    return array;
}


int GetMinValue (int[] array)
{
    int min = array[0];

    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

int GetMaxValue (int[] array)
{
    int max = array[0];

    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

int ReadInt()
{
    string s = Console.ReadLine();

    if (int.TryParse(s, out int i))
    return i;

    return -1;
}

string GetArrayAsString (int[] array)
{
    string s = string.Empty;

    foreach (var item in array)
    {
        s += $"{item}, ";
    }

    return s;
}