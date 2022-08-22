// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Задайте одномерный массив: ");
int size = Convert.ToInt32(Console.ReadLine());

int count = 0;

int[] array = new int[size];
CreateArrayRndInp(array);

void CreateArrayRndInp(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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

for (int a = 0; a < array.Length; a += 2)
{
    count = count + array[a];
}

Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях: {count}.");