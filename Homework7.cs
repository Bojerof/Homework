// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Creat2dArray(int rows, int cols, int min, int max)
// {
//     double[,] array = new double[rows, cols];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(min, max + 1) / 10.0);
//         }
//     }
//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.Write("Enter rows of array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter cols of array: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter min of array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter max of array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[,] array = Creat2dArray(rows, cols, min, max);
// Show2dArray(array);

// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Creat2dArray(int rows, int cols)
// {
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 50);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void Find2dArray(int[,] array, int findRows, int findCols)
// {
//     if (findRows >=  array.GetLength(0) || findCols >= array.GetLength(1)) Console.WriteLine("There is no such element");
//     else System.Console.WriteLine($"Your number {array[findRows, findCols]}");
// }

// System.Console.Write("Enter rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter findRows: ");
// int findRow = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter findCols: ");
// int findCol = Convert.ToInt32(Console.ReadLine());
// int[,] array = Creat2dArray(rows, cols);
// System.Console.WriteLine(); 
// Show2dArray(array);
// System.Console.WriteLine();
// Find2dArray(array, findRow, findCol);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] Creat2dArray(int rows, int cols)
// {
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 50);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void Summ2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double summ = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             summ = summ + array[j, i];
//         }
//         double dif = summ / array.GetLength(0);
//         System.Console.Write($"{Math.Round(dif, 1)} ");
//     }
// }

// System.Console.WriteLine("Enter rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = Creat2dArray(rows, cols);
// System.Console.WriteLine();
// Show2dArray(array);
// System.Console.WriteLine();
// Summ2dArray(array);