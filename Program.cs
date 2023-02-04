/* // Задача 2
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

 */





 //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите трёхзначкое чисто: ");
int a = Convert.ToInt32(Console.ReadLine());

int a1 = a / 100;
int a2 = (a - a1 * 100) / 10; 

Console.WriteLine( a2 );




//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите чисто: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100)
{
    while (a > 999)
    {
        a = a / 10;
    }
int a3 = a % 10;
Console.WriteLine(a3);    
}
else
{
    Console.WriteLine("третьей цифры нет");
}


 

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n < 1 ||n < 6 )
    Console.WriteLine("Это будний день");
else
    Console.WriteLine("Этот день выходной");