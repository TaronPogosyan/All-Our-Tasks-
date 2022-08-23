// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

// Вариант 1 (хороший)
Console.Write("Введите сторону A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону C: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}
bool result = Triangle(num1, num2, num3);
Console.WriteLine(result ? "Является треугольником" : "Не является треугольником");


// Вариант 2
// Console.WriteLine("Введите сторону треугольника AB: ");
// int ab = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите сторону треугольника BC: ");
// int bc = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите сторону треугольника CA: ");
// int ca = Convert.ToInt32(Console.ReadLine());

// if (ab > 0 && bc > 0 && ca > 0)
// {
//     if (DoesTriangleExist(ab, bc, ca)) Console.WriteLine("Треугольник с такими сторонами может существовать");
//     else Console.WriteLine("Треугольник с такими сторонами НЕ может существовать ");
// }
// else Console.WriteLine("Треугольника с отрицательными сторонами НЕ существует ");

// bool DoesTriangleExist(int ab, int bc, int ca)
// {
//     if (ab + bc > ca && ca + ab > bc && bc + ca > ab) return true;
//     else return false;
// }