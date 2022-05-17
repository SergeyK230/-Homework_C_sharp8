void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int FindMaxCoordinate(int[,] array, int row, int column)
{
    int maxElement = array[row, column];
    int maxCoordinate = column;;
    for (int i = column + 1; i < array.GetLength(1); i++)
    {
        if (maxElement < array[row, i])
        {
            maxElement = array[row, i];
            maxCoordinate = i;
        }
    }
    return maxCoordinate;
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxCoordinate = FindMaxCoordinate(array, i, j);
            if (maxCoordinate != j)
            {
                int memory = array[i, j];
                array[i, j] = array[i, maxCoordinate];
                array[i, maxCoordinate] = memory;
            }
        }
    }
}

int[,] array = new int[5,5];
FillArrayRandom(array);
PrintArray(array);
System.Console.WriteLine();
SortArray(array);
PrintArray(array);