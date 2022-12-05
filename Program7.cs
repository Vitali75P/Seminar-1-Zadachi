Console.WriteLine("А сегодня выходной?");
//string day = Console.ReadLine(); 
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("Нет! Сегодня понедельник, рабочий день!");
        break;
    case 2:
        Console.WriteLine("Нет! Сегодня вторник, рабочий день!");
        break;
    case 3:
        Console.WriteLine("Нет! Сегодня среда, рабочий день!");
        break;
    case 4:
        Console.WriteLine("Нет! Сегодня четверг, рабочий день!");
        break;
    case 5:
        Console.WriteLine("Нет! Сегодня пятница, короткий рабочий день!");
        break;
    case 6:
        Console.WriteLine("Да! Суббота выходной день, отдыхаем!");
            break;
    case 7:
        Console.WriteLine("Да! Воскресенье выходной, отдыхаем, но завтра на работу!");
        break;
    default:
        Console.WriteLine("Увы но в неделе 7 дней, нет такого дня недели!");
        break;
 }