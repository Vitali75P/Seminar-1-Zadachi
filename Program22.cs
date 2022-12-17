//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
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
void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}
void VozvratArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
        }
}
Console.WriteLine("Упорядочили строки по убыванию!");
int[] row = new int[colCount];
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
        row[j] = arr[j, i];
    VozvratArray(row);
    Insert(true, i, row, arr);
}
PrintArray(arr);
