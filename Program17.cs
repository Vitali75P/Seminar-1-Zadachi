//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите числа через пробел!");
int[] array = Console.ReadLine()!.Split(' ').Select(x => int.Parse(x)).ToArray();

int GetPositivNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
    {
        result = result + 1;
    }
    return result;
}
Console.WriteLine($"Чисел больше 0:  {GetPositivNumbers(array)} !");
