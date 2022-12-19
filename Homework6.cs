// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 1-ый вариант
// int[] Array(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write("Введите число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ModShowArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine(count);
// }
// System.Console.Write("Введите длину: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = Array(size);
// ModShowArray(array);

// 2-ой вариант
// int High(int size)
// {
//     string str = string.Empty;
//     int count = 0;
//     int fix = 0;
//     while (count < size)
//     {
//         System.Console.Write("Введите число: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         str = str + num + " ";
//         if (num > 0)
//         {
//             fix ++;
//         }
//         count++;
//     }
//     System.Console.WriteLine(str);
//     return fix;
// }
// System.Console.Write("Введите длину: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int fix = High(size);
// System.Console.WriteLine(fix);


// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void Show(double k1, double k2, double b1, double b2)
// {   
//     double x = (b2 - b1) / (k1 - k2);
//     double y1 = (k1 * x) + b1;
//     double y2 = (k2 * x) + b2;
//     System.Console.WriteLine(y1 + " " + y2);
// }
// System.Console.Write("Введите число k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Show(k1, k2, b1, b2);