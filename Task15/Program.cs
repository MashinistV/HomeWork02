﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру, обозначающую день недели: ");
int.TryParse(Console.ReadLine(), out int number);
while (number < 1 || number > 7)
{
    Console.WriteLine("Вы ввели неверную цифру");
    Console.Write("Введите цифру, обозначающую день недели: ");
    int.TryParse(Console.ReadLine(), out number);
}
if (number > 5) Console.WriteLine("Этот день является выходным");
else Console.WriteLine("Этот день является рабочим");