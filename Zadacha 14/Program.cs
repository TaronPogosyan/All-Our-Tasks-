// 14. Напишите программу, которая принимает на 
// вход чисо и проверяет, кратно ли оно 
// одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Вывод число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write($"Число {num} кратно одновременно 7 и 23");
}
else
{
    Console.Write($"Число {num} не кратно одновременно 7 и 23");
}