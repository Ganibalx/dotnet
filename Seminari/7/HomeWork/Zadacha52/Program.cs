int[,] Input(int a, int b)
{
    int[,] array = new int[a, b];
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(0, 101);
        }
    }
    return array;
}

double[] Calculation(int [,] array)
{
    double [] result = new double [array.GetLength(1)];
    for(int i = 0; i<array.GetLength(1); i++)
    {
        for(int j = 0; j<array.GetLength(0); j++)
        {
            result[i] += array[j,i];
        }
        result[i]= result[i]/array.GetLength(0);
    }
    return result;
}

void print(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = Input(5, 10);
print(array);
Console.WriteLine();
Console.WriteLine(string.Join('\t',Calculation(array)));