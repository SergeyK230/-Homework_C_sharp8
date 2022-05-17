void FillArraySpiral(int[,] array, int row = 0, int column = 0, int znachenie = 1)
{
    for (; column < array.GetLength(1); column++)
    {
        if (array[row, column] == 0)
        {
            array[row, column] = znachenie;
            znachenie++;
        }
        else break;
    }
    if (array[row + 1, column - 1] == 0) FillArrayColumnDown(array, row + 1, column - 1, znachenie);
    else return;
}

void FillArrayColumnDown(int[,] array, int row, int column, int znachenie)
{
    for (; row < array.GetLength(0); row++)
    {
        if (array[row, column] == 0)
        {
            array[row, column] = znachenie;
            znachenie++;
        }
        else break;
    }
    if (array[row - 1, column - 1] == 0) FillArrayRowLeft(array, row - 1, column - 1, znachenie);
    else return;
}

void FillArrayRowLeft(int[,] array, int row, int column, int znachenie)
{
    for (; column >= 0; column--)
    {
        if (array[row, column] == 0)
        {
            array[row, column] = znachenie;
            znachenie++;
        }
        else break;
    }
    if (array[row - 1, column + 1] == 0) FillArrayColumnUp(array, row - 1, column + 1, znachenie);
    else return;
}

void FillArrayColumnUp(int[,] array, int row, int column, int znachenie)
{
    for (; row >= 0; row--)
    {
        if (array[row, column] == 0)
        {
            array[row, column] = znachenie;
            znachenie++;
        }
        else break;
    }
    if (array[row + 1, column + 1] == 0) FillArraySpiral(array, row + 1, column + 1, znachenie);
    else return;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0, 3} ", array[i, j]);
        }
        System.Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillArraySpiral(array);
PrintArray(array);
