int [,] generation(int m, int n)
{
    int [,] array = new int [m,n];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(0, 10);
        }
    }
    return array;
}

int input(string a)
{
    Console.WriteLine($"Введите {a}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int [,] multiplication(int [,] a, int [,] b)
{
    int x = a.GetLength(0);
    int y = b.GetLength(1);
    int [,] result = new int [x, y];
    for(int i = 0; i<x; i++)
    {
        for(int j = 0; j<y; j++)
        {
            for(int k = 0; k<x; k++)
            {                
              result[i,j]+= a[i,k]*b[k,j];                
            }
        }
    }
    return result;
}

void print(int [,] array)
{    
 for(int i = 0; i<array.GetLength(0); i++)
 {
    for(int j = 0; j<array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]}\t");
    }
    Console.WriteLine();
 }
 Console.WriteLine();
}

int[,] array1 = generation(input("Введите кол-во строк для матрицы 1"), input("Введите кол-во столбцов для матрицы 1"));
int[,] array2 = generation(input("Введите кол-во строк для матрицы 2"), input("Введите кол-во столбцов для матрицы 2"));
print(array1);
print(array2);
int[,] result = multiplication(array1, array2);
print(result);