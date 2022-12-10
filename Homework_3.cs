// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom(int num)
// {
//     if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
//     { 
//         System.Console.WriteLine("Является!");
//     }

//     else if (num > 99999)
//     {
//         System.Console.WriteLine("Ошибка! Введите пятизначное число!");
//     }
//     else 
//     {
//     System.Console.WriteLine("Не является");
//     }
// }

// System.Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindrom(num);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// void Distant(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     System.Console.Write($"Расстояние будет равно {Math.Round(dist, 2)}.");
// }

// System.Console.Write("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Distant(x1, y1, z1, x2, y2, z2);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Cub(int num)
// {
//     int cub = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         cub = i * i * i;
//         System.Console.Write(cub + " ");
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Cub(num);
