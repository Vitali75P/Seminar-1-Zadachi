//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.WriteLine("Задайте размер массива!");
int[] array = GetArray(ReadInt());
Console.WriteLine(GetArrayAsString(array));
Console.WriteLine($"Сумма элементов на нечетных позициях {GetArraySumm(array)}");

int[] GetArray (int length)
{
    int[] array = new int[length];

    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

int GetArraySumm (int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length;i++)
    {
        if (i % 2 != 0)
            summ = summ + array[i];
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