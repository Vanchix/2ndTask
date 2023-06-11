Console.WriteLine("Введите температуру");

var input1 = Console.ReadLine();

switch (input1)
{
    case ("Декабрь") or ("Январь") or ("Февраль"):
        Console.WriteLine("Зима");
        break;
    case ("Мар") or ("Апрель") or ("Май"):
        Console.WriteLine("Весна");
        break;
    case ("Июнь") or ("Июль") or ("Август"):
        Console.WriteLine("Лето");
        break;
    case ("Сентябрь") or ("Октябрь") or ("Ноябрь"):
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Ошибка! Месяц введен неверно");
        break;
}