// int age = 20;
// if (age >= 21)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine("Программа продолжает работу");


// int age = 15;
// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// else
// {
//     Console.WriteLine("Доступ запрещён");
//     Console.WriteLine("До совершеннолетия осталось лет: " + (18 - age));
// }


// int age = 14;
// if (age < 13)
// {
//     Console.WriteLine("Ребёнок");
// }
// else if (age < 18)
// {
//     Console.WriteLine("Подросток");
// }
// else if (age < 60)
// {
//     Console.WriteLine("Взрослый");
// }
// else
// {
//     Console.WriteLine("Пенсионер");
// }


// int age = 16;
// double height = 1.4;
// bool withAdult = true;

// if ((age >= 14 && height >= 1.5) || withAdult)
// {
//     Console.WriteLine("Можно кататься");
// }
// else
// {
//     Console.WriteLine("Пока нельзя");
// }


// //Задача А
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// if (number % 2 == 0)
// {
//     Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число нечётное");
// }


// //Задача Г
// Console.Write("Введите год: ");
// int year = int.Parse(Console.ReadLine());

// if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
// {
//     Console.WriteLine("Год високосный");
// }
// else
// {
//     Console.WriteLine("Год не високосный");
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// //Номер 1
// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// if (number > 0)
// {
//     Console.WriteLine("Положительное");
// }
// else if (number < 0)
// {
//     Console.WriteLine("Отрицательное");
// }
// else
// {
//     Console.WriteLine("Ноль");
// }


//Номер 3

Console.Write("Введите номер месяца (1-12): ");
int month = int.Parse(Console.ReadLine());

switch (month)
{
    case 12 or 1 or 2:
        Console.WriteLine("Зима");
        break;
    case 3 or 4 or 5:
        Console.WriteLine("Весна");
        break;
    case 6 or 7 or 8:
        Console.WriteLine("Лето");
        break;
    case 9 or 10 or 11:
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Неверный месяц");
        break;
}