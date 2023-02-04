// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите целое число: ");
int.TryParse(Console.ReadLine(), out int number);
if (number > 99)
{
    Console.Write($"Третья цифра в числе: {number}: ");
    string s = number.ToString();
    Console.WriteLine(s[2]);
}
else Console.WriteLine($"В числе {number} третьей цифры нет");