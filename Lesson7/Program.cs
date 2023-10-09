//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ->
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10); // [0; 10]
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
                matrix[i, j] *= matrix[i, j];
                //matrix[i, j] = Conver.ToInt32(Math.Pow(matrix[i, j], 2)); 
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }

}


Console.Clear();
Console.Write("Введитe размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // 4 3
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
*/

//---------------------------------------------------------------------------------

//Найти сумму элементов главной диагонали


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10); // [0; 10]
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum += matrix[i, j];
                //matrix[i, j] = Conver.ToInt32(Math.Pow(matrix[i, j], 2)); 
            
        }
        Console.WriteLine();
    }
    Console.Write($"Сумма основной диагонали массива: {sum}");

}

Console.Clear();
Console.Write("Введитe размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // 4 3
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);