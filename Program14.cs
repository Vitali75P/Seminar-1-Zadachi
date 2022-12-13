//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Задайте размер массива!");
int[] array = GetArray(ReadInt());
Console.WriteLine(GetArrayAsString(array));
Console.WriteLine($"Колличество четных чисел {GetArraySumm(array)}");

int[] GetArray (int length)
{
    int[] array = new int[length];

    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int GetArraySumm (int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] % 2 == 0)
            summ = summ + 1;
    }
    return summ;
}

int ReadInt()
{
    string s = Console.ReadLine();

    if (int.TryParse(s, out int i))
    return i;

    return 0;
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
//
