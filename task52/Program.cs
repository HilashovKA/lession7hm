// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateMatrix (int row, int column)
{
    int [,] matrix = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix [i,j] = new Random().Next(1,100);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
     
        }
    Console.WriteLine();
    }
}

void AverageColumn(int[,] matrix)
{
    for (int j =0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i,j];
        }
        Console.WriteLine($"Среднее значение элементов столбца {j} = {average/matrix.GetLength(0)}");
    }
}

Console.Write("Введите кол-во строк в матрице ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] matrix = CreateMatrix(row, column);
PrintMatrix(matrix);
AverageColumn(matrix);