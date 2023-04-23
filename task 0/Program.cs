// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"{x} squared = {x * x}");