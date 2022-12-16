//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2  
//1 -3,3 8 -9,9 
//8 7,8 -7,1 9
Console.WriteLine("Введите значение m !");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n !");
int n = int.Parse(Console.ReadLine()!);
double [,] array = new double[m, n];

void GetArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 10 *GenerationMinus();
            array[i, j] = Math.Round(array[i, j],1);
        }
    }    
}

int GenerationMinus()
{
    Random random = new Random();
    if (random.Next(10) > 5) return 1;
    return -1;
}

void FullArray (double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}  ");
        }
    Console.WriteLine();
    }
}
GetArray(array);
Console.WriteLine();
FullArray(array);
//
