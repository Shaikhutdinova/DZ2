﻿/* Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру 
этого числа. 
456 - 5
782 - 8
918 - 1
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = num / 10 % 10;
Console.Write($"Вторая цифра у числа {num} - {result}");