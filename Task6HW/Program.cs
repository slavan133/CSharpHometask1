﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int delenoye = number%2;
if (delenoye != 0) Console.WriteLine("нет, число не является четным");
else Console.WriteLine("да, число четное");