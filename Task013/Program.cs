﻿/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 - 5
78 - третьей цифры нет
32679 - 6
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number/100 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int num = number / 100 % 10;
    Console.WriteLine(num);
}