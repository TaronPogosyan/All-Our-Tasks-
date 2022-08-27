// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write($"Количество чисел, M ввел пользователь: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] masNum = new int[m];


int CreateNum(int[] masNum)
{
    int count = 0;
    for (int i = 0; i < masNum.Length; i++)
    {
        if (masNum[i] > 0) count += 1;
    }
    return count;
}

void PrintNum(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Число {i + 1}: ");
        masNum[i] = Convert.ToInt32(Console.ReadLine());
    }
}
PrintNum(m);

Console.WriteLine($"Пользователь ввел больше 0: {CreateNum(masNum)} чисел.");
