void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}: [{i},{j},{k}]   ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] array = new int[3,3,3] {{{31, 22, 16},
                                 {99, 80, 30},
                                 {55, 46, 71}},

                                {{11, 20, 97},
                                 {51, 42, 19},
                                 {88, 16, 47}},
                                
                                {{66, 70, 63},
                                 {43, 56, 33},
                                 {95, 10, 36}}};

PrintArray(array);