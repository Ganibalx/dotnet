int[,] FillingArray(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            result[i, j] = new Random().Next(1, 10);
    return result;
}

int[,] Sorting(int[,] a)
{
    int per = 0;
    for (int i = 0; i<a.GetLength(0); i++)
    for (int j = 0; j<a.GetLength(1); j++)
    for (int k = 0; k<a.GetLength(1)-1; k++)
    if (a[i, k] < a[i, k+1])
    {
        per=a[i, k];
        a[i, k]=a[i, k+1];
        a[i, k+1]=per;
    }
    return a;
}

void Print(int[,] a)
{
    for (int i = 0; i<a.GetLength(0); i++)
    {
        for (int j = 0; j<a.GetLength(1); j++)
        {
            Console.Write($"{a[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = FillingArray(5, 5);
Print(array);
Console.WriteLine();
Print(Sorting(array));