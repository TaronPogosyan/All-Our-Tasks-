// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void PolinNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Число {number}, является ли оно палиндромом? -> да.");
    }
    else Console.WriteLine($"Число {number}, является ли оно палиндромом? -> нет.");
}

if (number!.Length == 5)
{
    PolinNumber(number);
}
else Console.WriteLine($"Вы ввели не правильное число, оно должно быть пятизначное");


