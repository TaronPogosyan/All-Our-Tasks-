// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[,] values = new double[2, 2];
double[] interPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < values.GetLength(0); i++)
    {
        Console.WriteLine($"Заданных уравнениями (y = k * x + b): {i + 1}");
        for (int j = 0; j < values.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значения k: ");
            else Console.Write($"Введите значения b: ");
            values[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] values)
{
    interPoint[0] = (values[1, 1] - values[0, 1]) / (values[0, 0] - values[1, 0]);
    interPoint[1] = interPoint[0] * values[0, 0] + values[0, 1];
    return interPoint;
}


void OutputResponse(double[,] values)
{
    if (values[0, 0] == values[1, 0] && values[0, 1] == values[1, 1])
    {
        Console.Write($"Совпадают");
    }
    else if (values[0, 0] == values[1, 0] && values[0, 1] != values[1, 1])
    {
        Console.Write($"Не совпадают");
    }
    else
    {
        Decision(values);
        Console.Write($"Точка пересечения двух прямых: ({interPoint[0]}, {interPoint[1]})");
    }
}

InputCoefficients();
OutputResponse(values);