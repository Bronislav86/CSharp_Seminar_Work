// Разбор ДЗ Задача 13

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// // Int64 n = Convert.ToInt64(Console.ReadLine());

// if (n < 100)
//     Console.WriteLine("третьей цифры нет");
// else
// {
//     while (n > 999)
//         n = n / 10;
//     Console.WriteLine(n % 10);
// }

//---------------------------------------------------------------------------------

// Задача 24: Напишите программу, которая принимает на вход число (А) и
//выдаёт сумму чисел от 1 до А.
// 7 -> 28 = 1 +1 + 2 + 3 + 4 + 5 + 6 + 7
// 4 -> 10 = 1 + 2 + 3 + 4
// 8 -> 36


// void f(double a)
// {
//     Console.WriteLine((1 + a) / 2 * a);
// }

// Console.Write("Введите число: ");
// double a = Convert.ToDouble(Console.ReadLine());
// f(a);

// double n = 5;
// Console.WriteLine(n / 2);

//-----------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
/*
int f(int a)
{
    int count = 0;
    while (a > 0)
    {
        a = a / 10; // a/=10
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));
*/

//-------------------------------------------------------------------------------

// Задача 28: Напишите программу, которая принимает на вход число N и
// выдаёт произведение чисел от 1 до N.

// void ProductNumbers(int n)
// {
//     int result = 0;
//     for(int i=1; i<=n; i++)
//         res *=i;
//         Console.WriteLine(res);          //код не работает!!! надо доделать
// }


// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int res = 1;
// Console.WriteLine(ProductNumbers(n));

//------------------------------------------------

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 3);

// Console.WriteLine($"[{string.Join(", ", array)}]");

