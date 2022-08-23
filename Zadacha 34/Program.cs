// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



Console.Write("Задайте массив с трёхзначными числам: ");
int size = Convert.ToInt32(Console.ReadLine());

int count = 0;

int[] array = new int[size];
CreateArrayRndInp(array);

void CreateArrayRndInp(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
PrintArray(array);

for (int a = 0; a < array.Length; a++)
{
    if (array[a] % 2 == 0)
        count++;
}
Console.WriteLine($"Количество чётных чисел в массиве: {count}.");