// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)

// void Step(int num1, int num2)
// {
//     int count = 1;
//     int sum = 1;
//     while (count <= num2)
//     {
//         sum = sum * num1;
//         count++;
//     }
//     System.Console.WriteLine(sum);
    

// }
// System.Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число степени: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Step(num1, num2);

// void Step(int num1, int num2)
// {
//     int sum = 1;
//     for (int i = 1; i <= num2; i++)
//     {
//         sum = sum * num1;
//     }
//     System.Console.WriteLine(sum);

// }
// System.Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число степени: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Step(num1, num2);

// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

// int Summ(int num)
// {
//     int one = 0;
//     int sum = 0;
//     while (num > 0)
//     {
//         one = num % 10;
//         sum = sum + one;
//         num = num / 10;
//     }
//     return sum;
// }
// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int showSum = Summ(num);
// System.Console.WriteLine(showSum);

// Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

// int[] Array(int num)
// {
//     int[] arr = new int [num];
//     for (int i = 0; i < num; i++)
//     {
//         System.Console.Write("Введите число: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }
// System.Console.Write("Введите длинну массива: ");
// int lengthMass = Convert.ToInt32(Console.ReadLine());
// ShowArray(Array(lengthMass));