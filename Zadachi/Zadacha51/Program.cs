int[,] input(int a, int b)
{
    int [,] array = new int[a,b];
    return array;
}

int random()
{
    return new Random().Next(1, 10);
}

int[,] filling(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j]=i+j;
        }
    }
    return array;
}

void print(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}

print(filling(input(random(), random())));