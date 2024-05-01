// void NumToQuad(int num)
// {
//     System.Console.WriteLine(num * num);
// }

// System.Console.WriteLine("input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// NumToQuad(a);   

// Задача 1
// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// // цифру этого числа.
// // Примеры
// // a = 256 => 26
// // a = 891 => 81

// int DelDigTwo(int num) // или void DelDigTwo(int num)
// {
//     if (num >= 100 && num <= 999) // && - двойной амперсант
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return sot * 10 + ed; // если void то System.Console.WriteLine(sot * 10 + ed)
//     }
//     else
//     {
//         System.Console.WriteLine("Введи трех значное");
//         return 0;
//     }
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DelDigTwo(num));

// Задача 2
// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int ВозвестиВСтепень(int num) // или void DelDigTwo(int num)
// {
//     if (num >= 100 && num <= 999) // && - двойной амперсант
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++)
//         {
//            result = result * dec;
//         }
//         return result;
//     }   
//     else
//     {
//         System.Console.WriteLine("Введи трех значное");
//         return 0;
//     }
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(ВозвестиВСтепень(num));

// Задача 3
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1