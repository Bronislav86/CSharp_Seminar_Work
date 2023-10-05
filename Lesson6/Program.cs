// **Задача 39:** Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 10);
// }

// void ReleaseArray(int[] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
    
        
// }

// Console.Clear();
// Console.Write("Введите кол-во эл-тов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

//---------------------------------------------------------------------------------------------

// **Задача 40:** Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника
// меньше суммы двух других сторон.

// Console.Clear();
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // ВВОД ДАННЫХ В ОДНУ СТРОКУ ЧЕККРЕЗ СПЛИТ!!!!
// Console.WriteLine($"[{string.Join(", ", size)}]");
// // Console.Write("Введите три числа: ");
// // int n = Convert.ToInt32(Console.ReadLine());

// foreach(int i in size)
// Console.WriteLine(i*2);

// void Togle(int[] size)
// {
//         if(size[0] < size[1] + size[2]
//             && size[1] < size[0] + size[2]
//             && size[2] < size[0] + size[1])
//             Console.WriteLine("Может");
//         else
//     Console.WriteLine("Не может");
// }
// Console.Clear();
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // ВВОД ДАННЫХ В ОДНУ СТРОКУ ЧЕККРЕЗ СПЛИТ!!!!
// Console.WriteLine($"[{string.Join(", ", size)}]");
// Togle(size);

//--------------------------------------------------------------------

// **Задача 42:** Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10
//11 -> 1011

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string res = string.Empty;
// while(n > 0)
// {
//     res = Convert.ToString(n % 2) + res;
//     n /=2; // n = n /2
// }
// Console.WriteLine(res);

//---------------------------------------------------------------------------------------------

// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

//   ! КАК ПРОИСХОДИТ СМЕЩЕНИЕ ПРИ КАЖДОЙ ЭТЕРАЦИИ !
// 0  1  1  2  3  5  8  13  21 34 55 
// x0 x1 x2
//    x0 x1 x2
//       x0 x1 x2

// ❗ **Числа Фибоначчи** — числовая ****последовательность, каждый
// элемент которой равен сумме двух предыдущих.

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int x0 = 0;
// int x1 = 1;
// int x2;

// for(int i = 0; i < n; i++)
// {
//     Console.Write($"{x0} ");
//     x2 = x0 + x1;
//     x0 = x1;
//     x1 = x2;
// }

//-----------------------------------------------------------------------------------

// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

// Console.Clear();

// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

// int[] newarray = new int[array.Length];

// for (int i = 0; i < array.Length; i++)
//     newarray[i] = array[i];

// newarray[0] = array [0];
// Console.WriteLine($"Первоначальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Скопированный массив: [{string.Join(", ", newarray)}]");