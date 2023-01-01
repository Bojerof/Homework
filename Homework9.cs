// Написать рекурсивную функцию перевода из десятичной 
// системы исчисления в двоичную.

// void ShowNumber(int numb)
// {
//     if (numb > 1) ShowNumber(numb / 2);
//     Console.Write($"{numb % 2} ");
// }

// Console.Write("Enter the number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// ShowNumber(numb);


// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// int ShowNumber(int n, int m)
// {
//     if (Math.Min(n, m) != Math.Max(n, m))
//     {
//         ShowNumber(Math.Max(n, m), Math.Min(n, m) + 1);
//         return ShowNumber(Math.Max(n,m), Math.Min(n, m) + 1) + Math.Min(n, m);
//     }
//     else return n;
// }


// Console.Write("Enter the number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int summ = ShowNumber(n, m);
// System.Console.WriteLine(summ);