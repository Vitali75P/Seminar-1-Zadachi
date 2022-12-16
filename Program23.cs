//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите размер матрицы:");
int rowCount = int.Parse(Console.ReadLine()!);
int colCount = int.Parse(Console.ReadLine()!);
int[,] arr = FullArray(rowCount, colCount);
int[,] FullArray(int t, int i)
{
    int[,] arr = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
        {
            for (int b = 0; b < i; b++)
            {
                arr[a, b] = random.Next(1, 9);
            }
        }
        return arr;
}
void PrintArray(int[,] arr)
{
    for (int a = 0; a < arr.GetLength(0); a++)
    {
        for (int b = 0; b < arr.GetLength(1); b++)
        {
            Console.Write(arr[a, b] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Исходный массив!");
PrintArray(arr);
void SumStringArray(int[,] arr)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        line += arr[index, j] + " ";
    }
    Console.WriteLine($"{index+1}  строка с минимальной суммой элементов: {line} !");
}
SumStringArray(arr);