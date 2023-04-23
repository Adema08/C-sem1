// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Enter a number of the day of the week: ");
int x = Convert.ToInt32(Console.ReadLine());
// if (x == 1)
// {
//     Console.WriteLine("Monday");
// }
// else if (x == 2)
// {
//     Console.WriteLine("Tuesday");
// }
// else if (x == 3)
// {
//     Console.WriteLine("Wednesday");
// }
// else if (x == 4)
// {
//     Console.WriteLine("Thursday");
// }
// else if (x == 5)
// {
//     Console.WriteLine("Friday");
// }
// else if (x == 6)
// {
//     Console.WriteLine("Saturday");
// }
// else if (x == 7)
// {
//     Console.WriteLine("Sunday");
// }
// else
// {
//     Console.WriteLine("Not a day of the week");
// }

switch(x)
{
    case 1:
    {
        Console.WriteLine("Monday");
        break;
    }
    case 2:
    {
        Console.WriteLine("Tuesday");
        break;
    }
    case 3:
    {
        Console.WriteLine("Wednesday");
        break;
    }
    case 4:
    {
        Console.WriteLine("Thursday");
        break;
    }
    case 5:
    {
        Console.WriteLine("Friday");
        break;
    }
    case 6:
    {
        Console.WriteLine("Saturday");
        break;
    }
    case 7:
    {
        Console.WriteLine("Sunday");
        break;
    }
    default:
    {
        Console.WriteLine("Not a day of the week");
        break;
    }

}