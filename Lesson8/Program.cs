// Задача 53: Задайте двумерный массив. Напишите программу, которая
// поменяет местами первую и последнюю строку массива.

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
//     int temp = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;
//     }
// }

// void PrintMatrix(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 Console.Write($"{matr[i,j]} \t");
//             }
//             Console.WriteLine();
//         }
// }

// Console.Clear();
// Console.Write("Введитe размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // 4 3
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// ReleaseMatrix(matrix);

//--------------------------------------------------------------------------

// Задайте двумерный массив. Напишите программу, которая заменяет строки на
// столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Например, задан массив:

// 1 4 7 2  00 01 02 03
// 5 9 2 3  10 11 12 13
// 8 4 2 4  20 21 22 23
// 5 2 6 7  30 31 32 33

// В итоге получается вот такой массив:

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

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
//     int temp = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i+1; j < matrix.GetLength(1); j++)
//         {   
//             temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }

// }

// void PrintMatrix(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 Console.Write($"{matr[i,j]} \t");
//             }
//             Console.WriteLine();
//         }
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

//----------------------------------------------------------------------------------------------------------------

// Задача 57:** Составить частотный словарь элементов двумерного массива. Частотный
//словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 2 3 4 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
bool CheckValue(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == x)
            return false;
    }
    return true;
}

int InputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10); // [0; 10]

            if (CheckValue(array, matrix[i, j]))
            {
                array[k] = matrix[i, j];
                k++;
            }
        }
    }
    return k;
}

void ReleaseMatrix(int[,] matrix, int array_len, int[] array)
{
    int count = 0;
    for (int k = 0; k <= array_len; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i, j])
                count++;
            }
        }
        Console.WriteLine($"{array[k]} встретилось {count} раз");
        count = 0;
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введитe размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // 4 3
int[,] matrix = new int[size[0], size[1]];
int[] array = new int[size[0] * size[1]];
int array_len = InputMatrix(matrix, array);
InputMatrix(matrix, array);
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix, array_len, array);
Console.WriteLine();
Console.WriteLine(String.Join(" ", array));

// PrintMatrix(matrix);

//----------------------------------------------------------------------

//Попробовать решить самому! *(можно не удалять э-ты а просто их не выводить)

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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