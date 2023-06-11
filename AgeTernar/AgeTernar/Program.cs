Console.WriteLine("Введите возраст");

var age = Convert.ToInt32(Console.ReadLine());

var IsAdult = age >= 18 ? "Adult" : "NotAdult";

Console.WriteLine(IsAdult);