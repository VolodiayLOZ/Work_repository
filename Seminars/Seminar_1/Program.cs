
// Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"number {a * a}");

// Задача_1
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.

// Console.Write("Input 1 number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input 2 number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b == a * a)
// {
//     System.Console.WriteLine("STOP CAR");
// }
// else
// {
//     System.Console.WriteLine("NOT");
// }

// Задача_2
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int start = -a;
// while (start <= a)
// {
//     System.Console.Write(start + " ");
//     start++; // start = start + 1
// }

// Задача_3
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a >= 99 && a <= 999) // && - двойной амперсант
// {
//     int ed = a % 10;
//     int sot = a / 100;
//     System.Console.WriteLine($"Sum of {ed} and {sot} -> {ed + sot}");
// }
// else 
// System.Console.WriteLine("You input not three-digital number");