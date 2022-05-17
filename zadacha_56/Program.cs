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

void FindMimSumRow(int[,] array)
{
    int indexMin = 0;
    int sumMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {      
        int sumTemp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumTemp = array[i, j] + sumTemp;
        }
        if (sumTemp < sumMin || i == 0)
        {
            sumMin = sumTemp;
            indexMin = i;
        }
    }
    System.Console.WriteLine($"{indexMin + 1}-я строка");
}

int[,] array = new int[20,20];
FillArrayRandom(array);
PrintArray(array);
System.Console.WriteLine();
FindMimSumRow(array);
