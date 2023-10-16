// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и 
// столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент  1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10); // [0; 10]
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[,] matrix)
// {
//     int minValue = matrix[0, 0]; indexRow = 0; indexColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < minValue)
//             {
//                 minValue = matrix[i, j];
//                 indexRow = i;
//                 indexColumn = j;
//             }
//         }
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10); // [0; 10]
//         }
//         Console.WriteLine();
//     }
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         if (i = indexRow)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 if (i != indexRow && j != indexColumn)
//                     Console.Write($"{matrox[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введитe размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // 4 3
// while (size[0] != size[1])
// {
//     Console.Write("Ошибка! Введите размер матрицы: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// ReleaseMatrix(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);

//--------------------------------------------РЕКУРСИЯ-------------------------------------------------------------

// Быстрая соортировка - изучить!

//Сложить 2 числа с помощью рекурсии (+1 и -1)

// int summ(int a, int b)
// {
//     if( b == 0)
//         return a;
//     return summ(a + 1, b - 1);
// }


// Console.Clear();
// Console.Write("Введитe Число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введитe Число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(summ(a, b));

//-----------------------------------------------------------------------------------------------------

// Задача 63:** Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

// string f(int n)
// {
//     if (n == 1)
//         return "1 ";

//     return f(n - 1) + $"{n} ";
// }


// Console.Clear();
// Console.Write("Введитe Число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

//--------------------------------------------------------------------------------------------------------------

// Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// string f(int m, int n)
// {
//     if (n == m)
//         return $"{m} ";

//     return f(m, n - 1) + $"{n} ";
// }

// Console.Clear();
// Console.Write("Введитe Число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введитe Число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n, m));

//-----------------------------------------------------------------------------------------------------------------

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

// int rec(int n)
// {
//     if (n == 0)
//         return 0;
//         //if (n < 10)
//         //    return n:
//     return rec(n / 10) + n % 10;
// }
// //rec(453)
// //              rec(45) + 3
// //            rec(4) + 5
// //          rec(0) + 4
// //                 0       

// Console.Clear();
// Console.Write("Введитe Число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));

//----------------------------------------------------------------------------------------------------------------------

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int rec(int n, int m)
// {
//     if (m == 0)
//         return 1;
//     return rec(n, m - 1) * n;
// }


// Console.Clear();
// Console.Write("Введитe Число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введитe Число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n, m));