double [,] CreateMatrix (int row, int column)
{
    double [,] matrix = new double [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i,j] = new Random().NextDouble() * 1000;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк в матрице ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк в матрице ");
int column = Convert.ToInt32(Console.ReadLine());
double [,] matrix = CreateMatrix(row, column);
PrintMatrix(matrix);