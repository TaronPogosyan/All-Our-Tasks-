// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// 3⁵ = 3*3*3*3*3, где:
// 3 — основание степени;
// 5 — показатель степени.



Console.WriteLine("введите число A");
int num1 = Convert.ToInt32(Console.ReadLine()); //Число A
Console.WriteLine("введите число B");
int num2 = Convert.ToInt32(Console.ReadLine()); // Число B
int tretChislo = num1;

for (int i = 1; i < num2; i++)
{
    tretChislo *= num1;
}
Console.WriteLine("A в натуральную степень B: " + tretChislo);