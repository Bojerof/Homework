// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] Creat2dArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
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
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] Sort2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int maxPosition = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, maxPosition])
//                 {
//                     maxPosition = k;
//                 }
//             }
//             int temp = array[i, j];
//             array[i, j] = array[i, maxPosition];
//             array[i, maxPosition] = temp;
//         }
//     }
//     return array;
// }

// Console.Write("Enter rows for array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter cols for array: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = Creat2dArray(rows, cols);
// Show2dArray(array);
// int[,] sortArray = Sort2dArray(array);
// System.Console.WriteLine();
// Show2dArray(sortArray);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] Creat2dArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
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
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] Summ2dArray(int[,] array, int rows)
// {
//     int [] summArray = new int [rows];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         int summ = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             summ = summ + array[i, j];
//         }
//         summArray[i] = summ;
//     }
//     return summArray;
// }

// void ShowSummArray(int[] summArray)
// {
//     int minIndex = 0;
//     for (int i = 0; i < summArray.Length; i++)
//     {
//         int minNumber = i;
//         for (int j = 0; j < summArray.Length; j++)
//         {
//             if (summArray[j] < summArray[minNumber]) minNumber = j;
//         }
//         System.Console.Write(summArray[i]+ " ");
//         minIndex = minNumber;
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Строка {minIndex + 1}");
// }

// Console.Write("Enter rows for array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter cols for array: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// if (cols != rows) System.Console.WriteLine("Enter the same rows and cols");
// else
// {
//     int[,] array = Creat2dArray(rows, cols);
//     Show2dArray(array);
//     System.Console.WriteLine();
//     int[] summArray = Summ2dArray(array, rows);
//     ShowSummArray(summArray);
// }

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] Creat2dArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
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
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] MultiArray(int[,] array1, int[,] array2, int rows, int cols)
// {
//     int[,] multiArray = new int[rows, cols];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {
//             for (int k = 0; k < array1.GetLength(0); k++)
//             {
//                 multiArray[i, j] += array1[i, k] * array2[k, j];
//             }
//         }
//     }
//     return multiArray;
// }

// Console.Write("Enter rows for array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter cols for array: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// if (cols != rows) System.Console.WriteLine("Enter the same rows and cols");
// else
// {
//     int[,] array1 = Creat2dArray(rows, cols);
//     int[,] array2 = Creat2dArray(rows, cols);
//     Show2dArray(array1);
//     System.Console.WriteLine();
//     Show2dArray(array2);
//     int[,] multiArray = MultiArray(array1, array2, rows, cols);
//     System.Console.WriteLine();
//     Show2dArray(multiArray);
// }

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] Creat3dArray()
// {
//     int[,,] array = new int[2, 2, 2];
//     for (int i = 0; i < 2; i++)
//     {
//         for (int j = 0; j < 2; j++)
//         {
//             for (int k = 0; k < 2; k++)
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//             }    
//         }
//     }
//     return array;
// }

// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }

// int[,,] array = Creat3dArray();
// Show3dArray(array);

// Напишите программу, которая заполнит спирально массив 4 на 4.

// int [,] Creat2dArray(int size)
// {
//     int [,] array = new int [size,size];
//     array[0,0] = 1;
//     int count = 2;
//     int i = 0;
//     int j = 0;
//     for (int k = 0; k < (size * size); k++)
//     {
//         for (; j < size -1 && array[i,j+1] == 0; j++)
//         {
//             if (array[i,j+1] == 0)
//             {
//                 array[i,j+1] = count;
//                 count++;
//             }
//         }   
//         for (; i < size -1 && array[i+1,j] == 0; i++)
//         {
//             if (array[i+1,j] == 0)
//             {
//                 array[i+1,j] = count;
//                 count++;
//             }
//         }
//         for (; j > 0 && array[i,j-1] == 0; j--)
//         {
//             if (array[i,j-1] == 0)
//             {
//                 array[i,j-1] = count;
//                 count++;
//             }
//         }  
//         for (; i > 0 && array[i-1,j] == 0; i--)
//         {
//           array[i-1,j] = count;
//           count++;
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
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }


// Console.Write("Enter size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,] array = Creat2dArray(size);
// Show2dArray(array);

