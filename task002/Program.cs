Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.Write($"Введите квадрат числа {number} :");
int square2 = Convert.ToInt32(Console.ReadLine());
if (square == square2)
{
    Console.Write("Правильно");
}
else
{
    Console.Write("Неправильно");
}