﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число n = ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Второе число будет равно {n / 10 % 10}");
