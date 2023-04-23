// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i;
for (i = -n; i <=n; i++)
{
    if (i == n)
    {
         Console.WriteLine(i);
         break;
    }
    Console.Write($"{i}, ");
}