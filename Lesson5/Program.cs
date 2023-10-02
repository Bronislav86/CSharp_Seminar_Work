﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.




// void ReleaseArray(int[] array)
// {
//     int sum_p = 0; int sum_o = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0)
//             sum_p += array[i];
//         else 
//             sum_o += array[i];
//     Console.WriteLine($"Сумма пол:{sum_p}, \nCумма отр: {sum_o}");
// }


// Console.Clear();
// Console.Write("Введите кол-во эл-тов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);

//-----------------------------------------------------------------------------

// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
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

//--------------------------------------------------------------------------------

// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// string ReleaseArray(int[] array, int x)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == x)
//             return "yes";
//     }
//     return "no";
// }


// Console.Clear();
// Console.Write("Введите кол-во эл-тов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите искомое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine(ReleaseArray(array, x));

//------------------------------------------------------------

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите
// количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 100); 
// }

// int ReleaseArray(int[] array)
// {
//     count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] >= 10 && array[i] <=99)
//             count ++;

//     return count;

// }   


// Console.Clear();
// Console.Write("Введите кол-во эл-тов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine(ReleaseArray(array));

//----------------------------------------------------------

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

int ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write(array[i] * array[array.Length - 1 - i] + " ");
}


Console.Clear();
Console.Write("Введите кол-во эл-тов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);



// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 10); // [-9; 9]
// }

// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2 +  array.Length % 2; i++)
//         Console.Write(array[i] * array[array.Length - 1 - i] + " ");

// }   

//  // 0 1 2 3 4 5 6 7 index
//  // 4 8 3 9 5 6 7 2
// Console.Clear();
// Console.Write("Введите кол-во эл-тов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);