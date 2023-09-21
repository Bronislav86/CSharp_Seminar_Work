// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int a1 = a/10;
int a2 = a%10;

if (a1>a2)
    Console.WriteLine(a1);
else
    Console.WriteLine(a2);




// Напишите программу, которая будет принимать на вход два числа и
//выводить, является ли второе число кратным первому. Если число 2
//не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
/*
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, {a % b}");
}
*/

//------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

/*
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine($"no");
}
*/