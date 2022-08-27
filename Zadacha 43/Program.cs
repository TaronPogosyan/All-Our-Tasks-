// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Вариант 1
double[,] matrix = new double[2, 2];
double[] sum = new double[2];

void BothMatrix()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine($"{i + 1}-ое заданных уравнениями (y = k * x + b).");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значения k: ");
            else Console.Write($"Введите значения b: ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
BothMatrix();

double[] Solution(double[,] matrix)
{
    sum[0] = (matrix[1, 1] - matrix[0, 1]) / (matrix[0, 0] - matrix[1, 0]);
    sum[1] = sum[0] * matrix[0, 0] + matrix[0, 1];
    return sum;
}


void PrintMatrix(double[,] matrix)
{
    if (matrix[0, 0] == matrix[1, 0] && matrix[0, 1] == matrix[1, 1])
    {
        Console.Write($"Совпадают");
    }
    else if (matrix[0, 0] == matrix[1, 0] && matrix[0, 1] != matrix[1, 1])
    {
        Console.Write($"Не совпадают");
    }
    else
    {
        Solution(matrix);
        Console.Write($"Точка пересечения двух прямых: ({sum[0]}, {sum[1]})");
    }
}
PrintMatrix(matrix);
