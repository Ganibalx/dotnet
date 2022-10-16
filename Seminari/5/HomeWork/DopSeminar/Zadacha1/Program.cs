int input(int a, int b)
{
    return new Random().Next(a, b);
}

int Calculation(int[] array, int a)
{
    int result = 0;
    if(a == 0)
    {
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) result += array[i];        
    }
    }
    else
    {
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<0) result += array[i];        
    }        
    }
    return result;
}

int[] NewArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = input(-9, 10);
    }
    return array;
}

void print(int[] array)
{
    Console.WriteLine(string.Join(' ', array));
}

void printresult(int n, string b)
{
    Console.WriteLine(b + " " + n);
}

int[] array = NewArray(12);
print(array);
printresult(Calculation(array, 0), "Сумма положительных -");
printresult(Calculation(array, 1), "Сумма отрицательных -");