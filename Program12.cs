//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11    82 -> 10   9012 -> 12 
Console.WriteLine("Введите число!");
int numbers = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNumbers(numbers));
int SumNumbers (int numbers)
{
    int sum = 0;
    for (int i = 0; i <= numbers; i++)
    {
      sum = sum + numbers % 10;
      numbers = numbers / 10;
    }
    return sum;
}
//
