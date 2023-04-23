//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Enter a number: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if (n < 0)
// {
//     n *= -1;
// }
if (n > 99 && n < 1000) 
{
    Console.WriteLine($"The last digit of the number: {n % 10}");
}
else
{
    Console.WriteLine("Not a 3-digital number");
}