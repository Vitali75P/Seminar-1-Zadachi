Console.WriteLine("Вводим наши числа");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
Console.WriteLine("Вот наш результат!!!");
if (number1 > number2)
{
   max = number1;
   min = number2;
}
if (number1 < number2)
{
    min = number1;
    max = number2;
}
Console.WriteLine("Большее число " +  max +  "!  Меньшее число " + min + "!");
//
