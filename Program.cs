// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.Clear();
System.Console.WriteLine("Введи размер массива M на N");
int m = inputNumber("M = :");
int n = inputNumber("N = :");
double[,] array = new double[m, n];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.NextDouble();
        array[i, j] = Math.Round(rand.NextDouble(), 2);
        System.Console.Write(" | " + array[i, j] + " | ");
    }
    System.Console.WriteLine();
}


int inputNumber(string str)
{
  int number;
  string text;
  while (true)
{
   System.Console.Write(str);
   text = Console.ReadLine();
   if (int.TryParse(text, out number))
{
break;
}
Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}
*/



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
/*
Console.Clear();
System.Console.WriteLine("Введи размер массива M на N");
int m = inputNumber("M = :");
int n = inputNumber("N = :");
System.Console.WriteLine("Введите позиции элементов массива (столбцы и строки)");
int columns = inputNumber("столбцы = :");
int lines = inputNumber("строки = :");
int[,] array = new int[m, n];
Random rand = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(-10, 10);
    }
}

for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}


 if (columns<=m || lines<=n)
 {
    object result = array.GetValue(lines, columns);
    System.Console.WriteLine();
    System.Console.WriteLine($"элемент находящийся в ячейке {lines}, {columns} равен {result}");
 }
 else
 {
    System.Console.WriteLine("Такого элемента нет");
 }

int inputNumber(string str)
{
  int number;
  string text;
  while (true)
{
   System.Console.WriteLine(str);
   text = Console.ReadLine();
   if (int.TryParse(text, out number))
{
break;
}
Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}
*/



// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
Console.Clear();
System.Console.WriteLine("Введи размер массива M на N");
int m = inputNumber("M = :");
int n = inputNumber("N = :");
int[,] array = new int[m, n];
int[] sum = new int [n];
Random rand = new Random();


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(1, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[j] += array[i, j];
    }
}

for (int i=0; i<n; i++)
{
    Console.Write((sum[i] / m)  + ",   ");
}


int inputNumber(string str)
{
  int number;
  string text;
  while (true)
{
   System.Console.Write(str);
   text = Console.ReadLine();
   if (int.TryParse(text, out number))
{
break;
}
Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}
*/