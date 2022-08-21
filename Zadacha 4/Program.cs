// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;


if (num2 > max)
{
    Console.WriteLine($"max = {num2}");
}
else if (num3 > max)
{
    Console.WriteLine($"max = {num3}");
}
else Console.WriteLine($"max = {max}");