// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];
CreateArrayRndInp(array);

void CreateArrayRndInp(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 10;
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
PrintArray(array);


double minMas = Int32.MaxValue;
double maxMas = Int32.MinValue;

for (int a = 0; a < array.Length; a++)
{
    if (array[a] > maxMas) maxMas = array[a];
    if (array[a] < minMas) minMas = array[a];
}

Console.WriteLine($"Разницу между максимальным и минимальным элементами массива: {maxMas - minMas}.");