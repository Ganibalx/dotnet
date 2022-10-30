int[,] FillingArray(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            result[i, j] = new Random().Next(1, 10);
    return result;
}

int Sorting(int[,] a)
{
    int result = 0;
    int min=0;
    for (int k = 0; k<a.GetLength(1); k++) min += a[0,k];   
    int summ = 0;
    for (int i = 1; i<a.GetLength(0); i++)
    {
        for (int j = 0; j<a.GetLength(1); j++)
        {
            summ += a[i,j];
        }
        if(summ<min)
        {
            min=summ;
            result=i;
        }
    }
    return result;
}

void Print_arr(int[,] a)
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

void Print(int a)
{
    Console.WriteLine($"Минимальная сумма элементов строке {a}");
}

int[,] array = FillingArray(5, 5);
Print_arr(array);
Console.WriteLine();
Print(Sorting(array));