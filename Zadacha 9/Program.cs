// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 10, 99 + 1
//Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// Вариант 1
// if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit});
// else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");

// Вариант 2
// int result = firstDigit > secondDigit ? firstDigit : secondDigit;   // переменный result = если firstDigit > secondDigit ? - тогда, мы записиваем переменную firstDigit, : - и наче secondDigit
// Console.WriteLine($"Наибольшая цифра числа {number} => {result}");

// Вариант 3
// int result = firstDigit == secondDigit ? "Цифры ровны" : firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {number} => {result}");

// Вариант 3 переделаем, потому что там "Цифры ровны" ругаеться, для этого int меняем на string, тогда ругаеться это firstDigit > secondDigit ? firstDigit : secondDigit, для этого это тоже меняем
// string result = firstDigit == secondDigit ? "Цифры ровны"
// : firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
// Console.WriteLine($"Наибольшая цифра числа {number} => {result}");

// int MaxDigit(int num)
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//     return result;
// }



// Вариант 1
// int result = MaxDigit(number);
// // Console.WriteLine(result); 
// // Чтобы результат было красиво делаем вот так 
// Console.WriteLine($"Наибольшая цифра числа {number} => {result}");


// Вариант 2 это не вариант а просто там добавляем еще строка
// int result = MaxDigit(number);
// int result2 = MaxDigit(56);
// Console.WriteLine($"Наибольшая цифра числа {number} => {result}");
// Console.WriteLine($"Наибольшая цифра числа {56} => {result2}"); // чтобы было каректный результат на строке 34 и 35 number меняем на num


// Вариант 3
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int result = MaxDigit(number);
string res = result == 0 ? "Цифры ровны" : result.ToString(); // Вырожение получилось гораздо компактный 

Console.WriteLine($"Наибольшая цифра числа {number} => {res}");

