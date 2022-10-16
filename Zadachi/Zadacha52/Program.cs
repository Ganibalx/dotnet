int[,] input(int a, int b)
{
    int[,] array = new int[a, b];
    return array;
}

int random()
{
    return new Random().Next(1, 10);
}

int[,] filling(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random();
        }
    }
    return array;
}

void print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Calculation(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i,j]=array[i,j]*array[i,j];
            }
        }
    }
    return array;
}

int[,] array = filling(input(random(), random()));
print(array);
Console.WriteLine();
print(Calculation(array));