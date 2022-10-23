int[,] Filling(int a, int b)
{
    int[,] array = new int[a, b];
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(0, 30);
        }
    }
    return array;
}

int Input(string a)
{
    Console.WriteLine(a);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Calculation(int [,] array, int a, int b)
{    
    int res = -1;
    if(array.GetLength(0)>a) if(array.GetLength(1)>b) res=array[a,b]; 
    return res;
}

void print(int b)
{
    if(b!=-1)
    {
        Console.WriteLine($"По заданным индексам находится число {b}");
    }
    else
    {
        Console.WriteLine($"По заданным индексам элемента нет");
    } 
}

void printarray(int [,] array)
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

int a = Input("Введите число строк:");
int b = Input("Введите число столбцов:");
int [,] array = Filling(a, b);
printarray(array);
Console.WriteLine();
int x = Input("Введите № cтроки искомого числа(считая от 0):");
int y = Input("Введите № столбца искомого числа(считая от 0):");
print(Calculation(array, x, y));