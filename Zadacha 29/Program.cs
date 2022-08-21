﻿// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] NewArray()
{
    int[] array = new int[8];
    for (int i = 0; i <= 7; i++)
    {
        array[i] = new Random().Next(1, 99);
    }

    return array;
}

int[] array = NewArray();
void PrintArray()
{
    for (int i = 0; i <= 7; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }

    Console.Write(" -> [");
    for (int i = 0; i <= 7; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
PrintArray();