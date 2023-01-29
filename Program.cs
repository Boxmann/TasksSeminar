// Задача 2
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"a = {a};  b = {b} -> max = {a}");
else if (a < b)
    Console.WriteLine($"a = {a};  b = {b} -> max = {b} ");
else
    Console.WriteLine($"a = {a};  b = {b} -> a = b = {b}");



//Задача 4
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (c >= a || c >= b)
    Console.WriteLine($" max = {c}");
else if (a >= c || a >= b )
    Console.WriteLine($"max = {a} ");
else
    Console.WriteLine($" max = {b} ");


// Задача 6
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 != 0)
    Console.WriteLine($"Число {a} не чётное");
else
    Console.WriteLine($"Число {a} чётное");



//Задача 8
Console.Clear();
int i;
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
for ( i = 1; i <= a; i++)
    if (i % 2 == 0) 
        Console.Write($"{i} ");




