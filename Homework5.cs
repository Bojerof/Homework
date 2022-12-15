// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] Array(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void Parit(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine($"Количетсво чётных чисел в массиве равно {count}.");
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = Array(size);
// ShowArray(array);
// Parit(array);

// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int[] Array(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void Find(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine($"Количество элементов массива из 123 случайных чисел в отрезке [10,99] равно {count}.");
// }

// int size = 123;
// System.Console.Write("Введите минимальную границу случайных чисел: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите максимальную границу случайных чисел: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] array = Array(size, minValue, maxValue);
// ShowArray(array);
// Find(array);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] Array(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void Summ(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {
//         sum = sum + array[i];
//     }
//     System.Console.WriteLine($"Суммв элементов стоящих на нечетных позициях равна {sum}.");
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите минимальную границу случайных чисел: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите максимальную границу случайных чисел: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] array = Array(size, minValue, maxValue);
// ShowArray(array);
// Summ(array);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] Array(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1) / 10.0);
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// double Diff(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (min > array[i])
//         {
//             min = array[i];
//                     }
//         else if (max < array[i])
//         {
//             max = array[i];
//         }
//     }
//     System.Console.WriteLine($"Минимальное число: {min}");
//     System.Console.WriteLine($"Максимальное число: {max}");
//     double diff = max - min;
//     return diff;
// }
// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите минимальную границу случайных чисел: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите максимальную границу случайных чисел: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// double[] array = Array(size, minValue, maxValue);
// ShowArray(array);
// double diff = Diff(array);
// System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round(diff, 1)}.");

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// int[] Array(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 11);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void NewArray(int[] array)
// {
//     int[] arr = new int [size];
//     int len = array.Length;
//     if (len % 2 == 0)
//     {
//         for (int i = 0, j = len - 1; i < len / 2; i++, j--)
//         {
//             System.Console.Write($"{array[i] * array[j]} ");
//         }
//     }
//     else
//     {
//         for (int i = 0, j = len - 1; i < len / 2; i++, j--)
//         {
//             System.Console.Write($"{array[i] * array[j]} ");
//         }
//         System.Console.WriteLine(array[(len) / 2]);
//     }
// }
// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = Array(size);
// ShowArray(array);
// NewArray(array);

