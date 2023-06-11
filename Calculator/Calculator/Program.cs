Console.WriteLine("Введите первое число");

var input1 = Console.ReadLine();

var a = Convert.ToDouble(input1);

Console.WriteLine("Введите знак операции");

var input2 = Console.ReadLine();

var symbol = Convert.ToChar(input2);

/*while (symbol != '+' || symbol != '-' || symbol != '/' || symbol != '*' || symbol != '%') 
{
    Console.WriteLine("Ошибка! Это не знак операции"); 
    Console.WriteLine("Введите знак операции");
    input2 = Console.ReadLine();
//Не понимаю почему при вводе знака операции программа все равно действует по пути что введен не знак операции
}*/

Console.WriteLine("Введите второе число");

var input3 = Console.ReadLine();

var b = Convert.ToDouble(input3);

switch (input2)
{
    case "+":
        Console.WriteLine("Сумма двух чисел равна " + (a + b));
        break;
    case "-":
        Console.WriteLine("Разность двух чисел равна " +  (a - b));
        break;
    case "*":
        Console.WriteLine("Произведение двух чисел равна " + (a * b));
        break;
    case "/":
        Console.WriteLine("Частное двух чисел равна " + (a / b));
        break;
    case "%":
        Console.WriteLine("Остато от деления двух чисел равен " + (a % b));
        break;
    default:
        Console.WriteLine("Ошибка! Введен не знак операции");
        break;
}