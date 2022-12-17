// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите значение N !!!");
int N = int.Parse(Console.ReadLine()!);
void PrintReverseOrder(int N)
{
    for(int i = N; i > 0; i--)
       Console.Write(i + ", ");
} 
PrintReverseOrder(N);
