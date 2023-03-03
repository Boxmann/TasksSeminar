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




/* 
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

 */
/* 
//Дополнительная задача(https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223)

Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int max = n, max2 = n;
while (n != 0)
{
    // программный код
    if (max < n)
    {
        max2 = max;
        max = n;
    }
    else if (max2 < n)
    {
        max2 = n;
    }
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"максимальное значение {max}");
Console.WriteLine($"второй по величине элемент {max2}"); 

*/

/* 
//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 100000 || n < 9999)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int n1 = n / 10000;
int n5 = n % 10;

if (n1 == n5)
{
    int n2 = (n - n1 * 10000) / 1000; 
    n = n / 10;
    int n4 = n % 10;
    if (n2 == n4)
    {
        Console.WriteLine("число является палиндромом");
    }
}
else 
{
    Console.WriteLine("число не является палиндромом");
}
 */

/*
//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

//первая точка
Console.Write("Введите x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());


//вторая точка
Console.Write("Введите x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
Console.Write($"расстояние между точками: {A}");
*/

/*
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
  Console.WriteLine($"{i} ^ 2 = {Math.Pow(i, 3)} ");


*/
/*
//Доп. задание не правильно сделано
Console.Clear();

Console.Write("Введите колличество кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
int a=0;

while (n <= 2 | n >= 1001)
{
        Console.Write("Вы ошиблись!\nВведите колличество кустов: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Всего кустов:{n} ");

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i} ");
}
for (int i = 1; i <= n; i=i+2)
{
    a = (i+1)+(i)+(i-1);
}
Console.WriteLine("");
Console.WriteLine(a);
*/


//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Clear();

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int z = 1;
for (int i = 1; i <= b; i++)
    z = z * a;

    Console.Write(z);

*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()), result = 0;

while (a != 0)
{
    result = result + a % 10;
    a = a / 10; 
}
Console.Write($"Результат: {result}");

*/
/* 
//
Console.Clear();
int[] array = {165, 163, 160, 160, 157, 157, 155, 154};
Console.WriteLine(string.Join(", ", array));

Console.WriteLine("введите рост Пети: ");
int n = Convert.ToInt32(Console.ReadLine());
int c = 1;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= n)
    {
        c++;
    }

}

Console.WriteLine($"Петя занял {c} место в строю");
  
  
 */
  
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Clear();



void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000); // [100, 999]
}

void ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    Console.WriteLine($"количество чётных чисел в массиве: {count}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
void InputArray(int[] array)
{
    
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10); // [1, 9]
    
}

void ReleaseArray(int[] array)
{
    int count = 0;
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum  += array[i];
        count++;
    }
    Console.WriteLine($"Сумма элементов cтоящих на нечётных позициях =  {sum}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
*/

// Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
 
void InputArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}

void ReleaseArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}
    


Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
ReleaseArray(array);

*/

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

Console.Clear();
Console.Write("Введите элементы через запятую: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0:  {count}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Clear();
Console.Write("Введите k1: ");
double  k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double  b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double  k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double  b2 = Convert.ToDouble(Console.ReadLine());
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
 
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
*/

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/* 
void InputMatrix(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Convert.ToDouble(new Random().Next(100,1000)) / 10;
  }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-99, 100); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix = new int[9, 9];
InputMatrix(matrix);
Console.WriteLine("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
 Console.WriteLine("такой позиции в массиве нет");
}
else
{
 Console.WriteLine($"На данной позиции находиться элемент  {matrix[n-1,m-1]}");
 
}
PrintMatrix(matrix);

*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 100); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

    for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / size[0];
    Console.Write(avarage + "; ");
}
*/

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 100); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1) -1; k++)
       {
            if (matrix[i, k] < matrix[i, k + 1])
            {
                int l = matrix[i, k + 1];
                matrix[i, k + 1] = matrix[i, k];
                matrix[i, k] = l;
            }
        }
        
    }
}
Console.WriteLine("____________________________________________ ");
PrintMatrix(matrix);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 100); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix = new int [5, 3];
InputMatrix(matrix);
PrintMatrix(matrix);

int count = 0;
int minsum =0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j]; 
    }    

    if (minsum==0 || minsum > sum)
    {
        minsum = sum;
        count = i;
    }
        
}
Console.WriteLine($"строка с наименьшей суммой элементов:  {count}");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер первого массива через пробел: ");
int[] size1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int [size1[0], size1[1]];
InputMatrix(matrix1);
PrintMatrix(matrix1);

Console.Write("Введите размер массива второго через пробел: ");
int[] size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int [size2[0], size2[1]];
InputMatrix(matrix2);
PrintMatrix(matrix2);

var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }
}
Console.WriteLine("____________________________________");
PrintMatrix(matrix3);

*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            matrix[i, j, k] = new Random().Next(1, 10);
        }
        
             
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            Console.Write($"{matrix[i, j, k],1}({i},{j},{k})\t"); 
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,,] matrix = new int [2, 2, 2];
InputMatrix(matrix);
PrintMatrix(matrix);

*/


//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
/*
Console.Clear();
Console.Write("Введите количество строк : ");
int n = int.Parse(Console.ReadLine());
int[][] array = new int[n][];
array[0] = new int[] { 1 };
for (int i = 1; i < array.Length; i++)
{
    array[i] = new int[i + 1];  
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i)
            array[i][j] = 1;
        else
        {
            array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
        }
    }
}
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array[i].Length; j++)
    {
        Console.Write("{0,-3} ", array[i][j]);
    }
    Console.WriteLine();
}
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
void InputMatrix(int[,] matrix, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { matrix [i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) matrix [i++, j] = value++;
        for (k = 0; k < n - 1; k++) matrix [i, j--] = value++;
        for (k = 0; k < n - 1; k++) matrix [i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        
        Console.Write($"{matrix[i, j]}\t"); 
        

        }
        Console.WriteLine();
    }
}

Console.Clear();
int q = 4;
int[,] matrix = new int [q, q];
InputMatrix(matrix, q);
PrintMatrix(matrix);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Clear();
Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int a = M;
int b = N;
if (M > N) 
{
    a = N;
    b = M;
}
int sum = (b+a)*(b-a+1)/2;
Console.WriteLine($"Сумма натуральных элементов: {sum}");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}      
Console.Clear();
Console.WriteLine(Akk(2, 3)); 
Console.WriteLine(Akk(3, 2)); 
