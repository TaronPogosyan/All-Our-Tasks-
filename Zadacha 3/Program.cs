// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница 


Console.WriteLine("введите число");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 1) Console.WriteLine($"{num} -> Пн");
else if (num == 2) Console.WriteLine($"{num} -> вт");
else if (num == 3) Console.WriteLine($"{num} -> Среда");
else if (num == 4) Console.WriteLine($"{num} -> чт");
else if (num == 5) Console.WriteLine($"{num} -> Пя");
else if (num == 6) Console.WriteLine($"{num} -> сб");
else if (num == 7) Console.WriteLine($"{num} -> вс");
else Console.WriteLine($"{num} -> не дня недели");

