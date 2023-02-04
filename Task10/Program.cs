// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int.TryParse(Console.ReadLine(), out int number);
while (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
    Console.Write("Введите трёхзначное число: ");
    int.TryParse(Console.ReadLine(), out number);
}
Console.WriteLine($"Вторая цифра числа {number}: {(number % 100) / 10}");