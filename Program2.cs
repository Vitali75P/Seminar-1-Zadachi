Console.WriteLine("Вводим три числа, найдем максимальное!");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Максимальное из этих чисел " + max + " !");

/
