﻿// task 43

Console.Clear();

Console.WriteLine("Введите b1 k1 b2 k2: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int b1 = array[0];
int k1 = array[1];
int b2 = array[2];
int k2 = array[3];
double x = (b2 - b1) * 1.0 / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых: ({x} ; {y})");