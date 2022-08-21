// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int rez = 0;

while (number > 0)
{
    int num = number % 10;
    number = number / 10;
    rez = rez + num;
}
Console.WriteLine($"Сумму цифр в числе -> {rez}");





