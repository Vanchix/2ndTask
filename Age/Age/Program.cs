Console.WriteLine("Введите возраст");

var age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Adult");
}
else 
{
    Console.WriteLine("Not Adult");
}