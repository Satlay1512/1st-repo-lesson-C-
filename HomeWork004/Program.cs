﻿// Задача 4: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
//  5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count<=N)
{
    if (count % 2 == 0) System.Console.Write(count + ", ");
    count++;
}
System.Console.WriteLine( );