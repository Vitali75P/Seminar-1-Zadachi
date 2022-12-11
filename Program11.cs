//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)   2, 4 -> 16
Console.WriteLine("Введите число A!");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B!");
int B = int.Parse(Console.ReadLine()!);

int Function1(int A, int B)
{
    int result = 1;
    int i = 1;
    while (i <= B)
    {
        result = result * A;
        i++;
    }
    return result;
}
Console.WriteLine(Function1(A, B));

int Function2(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
      result = result * A;
    }
    return result;
}
Console.WriteLine(Function2(A, B));
//
