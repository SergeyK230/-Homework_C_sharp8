int[,] FillArrayRandom(string arrayName)
{
    System.Console.WriteLine($"Введите количество строк для массива {arrayName}");
    int row = int.Parse(Console.ReadLine());
    System.Console.WriteLine($"Введите количество столбцов для массиба {arrayName}");
    int column = int.Parse(Console.ReadLine());
    int[,] arrayResult = new int[row, column];
    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            arrayResult[i, j] = new Random().Next(1,10);
        }
    }
    return arrayResult;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0, 4} ", array[i, j]);
        }
        System.Console.WriteLine();
    }
}

int Multiplication(int[,] matrix1, int[,] matrix2, int row, int column)
{
    int result = 0;
    for (int i = 0; i < matrix1.GetLength(1); i++)
    {
        result = result + (matrix1[row, i] * matrix2[i, column]);
    }
    return result;
}

int[,] matrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int row = 0; row < matrixResult.GetLength(0); row++)
    {
        for (int column = 0; column < matrixResult.GetLength(1); column++)
        {
            matrixResult[row, column] = Multiplication(matrix1, matrix2, row, column);
        }
    }
    return matrixResult;
}

int[,] matrix1 = FillArrayRandom("matrix1");
int[,] matrix2 = FillArrayRandom("matrix2");

PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
System.Console.WriteLine();

if (matrix1.GetLength(1) 
    != matrix2.GetLength(0)) 
{
    System.Console.WriteLine("Произведение невозможно");
}

else 
{
    int[,] matrix3 = matrixMultiplication(matrix1, matrix2);
    PrintArray(matrix3);
}
