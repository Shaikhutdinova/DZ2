﻿/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 - да
7 - да
1 - нет 
*/

Console.Write("Введите цифру от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if (num == 7 || num == 6)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}