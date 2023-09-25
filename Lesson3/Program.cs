//Найти максимальное из трех чисел

//................

// int maxi = n1;
// if (n2>maxi)
//     maxi = n2;
// if (n3>maxi)
//     maxi=n3;

// Console.WriteLine(maxi);

// --------------------------------------------------

// Задача 8: Показать четные числа от 1 до N

// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 2; i <= n; i++)
//     if (i % 2 == 0)
//         Console.Write($"{i} ");

///////////////////////////////////////////////////////////////////

//ПРОЦЕДУРЫ

// void f(ref int a) //ref - делаем чтобы а ссылалась на ту же яяейку памяти что и х
// {
//     a += 5;
//     Console.WriteLine(a);
// }
// int x = 10;
// Console.WriteLine(x);
// f(ref x);
// Console.WriteLine(x);


//ФУНКЦИИ

// int f(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }
// Console.WriteLine(f(5, 10));

// int maxi = f(5, 10);
// Console.WriteLine(maxi);

//---------------------------------------------------------------------------------

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

// I Способ

// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x > 0 && y < 0)
//     Console.WriteLine("IV");
// else if (x < 0 && y > 0)
// Console.WriteLine("II");
// if (x < 0 && y < 0)
//     Console.WriteLine("III");

// II способ

// string f(int x, int y)
// {
//     if (x > 0 && y > 0)
//         return "I";
//     else if (x > 0 && y < 0)
//         return "IV";
//     else if (x < 0 && y > 0)
//         return "II" ;
//     return "III";
// }

// Console.Write("Введите чило: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите чило: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(x, y));

//----------------------------------------------------------------------------------------------------

// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).

// string f(int x)
// {
//     if (x == 1)
//         return "x > 0, y > 0";
//     else if (x == 4)
//         return "x > 0, y < 0";
//     else if (x == 2)
//         return "x < 0, y > 0";
//         return "x < 0, y < 0";
// }

// Console.Write("Введите римское чило: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(x));

//---------------------------------------------------------------------

// Напишите программу, которая принимает на вход координаты двух
//точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите чило: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите чило: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите чило: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите чило: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 3);
// Console.WriteLine(d);

//-----------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите чило: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i ++)
    Console.Write($"{Math.Pow(i, 2)} ");