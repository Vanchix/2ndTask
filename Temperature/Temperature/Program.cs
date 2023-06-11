Console.WriteLine("Введите температуру");

var input1 = Convert.ToInt32(Console.ReadLine());

switch (input1)
{
    case (< 0):
        Console.WriteLine("Очень холодно");
        break;
    case (>=0) and (<10):
        Console.WriteLine("Холодно");
        break;
    case (>= 10) and (< 20):
        Console.WriteLine("Нормально");
        break;
    case (>= 20) and (< 30):
        Console.WriteLine("Тепло");
        break;
    case (>= 30):
        Console.WriteLine("Жарко");
        break;
    default:
        Console.WriteLine("Ошибка! Температура введена неверно");
        break;
}