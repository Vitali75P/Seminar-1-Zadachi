//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите значения двух прямых!");
double b1 = double.Parse(Console.ReadLine()!);
double k1 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);
double k2 = double.Parse(Console.ReadLine()!);
double x = (b1 - b2) / (k1 - k2);
double y = (k2*b1-k1*b2)/(k2-k1);
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
