Console.WriteLine("Введите любое число!");
int N = int.Parse(Console.ReadLine());
string str = N.ToString();
if (N < 100)
Console.WriteLine("Третьей цифры нет!");
else
Console.WriteLine(str[2]);

