// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// void Test(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         int tin = num / 10 % 10;
//         System.Console.WriteLine(tin);
//     }
//     else
//     {
//         System.Console.WriteLine("Число не трёхзначное!");
//     }
// }

// Console.WriteLine("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void Test(int num)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     if (num > 99)
//     {
//         int one = num % 10;
//         System.Console.WriteLine("Третья цифра - " + one);
//     }
//     else
//     {
//         System.Console.WriteLine("Третьей цифры нет!");
//     }
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);

// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// void Day(int num)
// {
//     if (num < 6)
//     {
//         Console.WriteLine("Не является выходным.");
//     }
//     else if (num > 5 && num < 8)
//     {
//         System.Console.WriteLine("Выходной");
//     }
//     else
//     {
//         System.Console.WriteLine("Число не является днем недели.");
//     }
// }
// Console.WriteLine("Введите число обозначающее день недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Day(num);