int input(int a, int b)
{
    return new Random().Next(a, b);
}

int Calculation(int [] array)
{
    int n = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
       n+=array[i];
    }
    return n;
}

int[] NewArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = input(-100, 101);
    }
    return array;
}

void print(int [] array)
{
    Console.WriteLine(string.Join(' ',array));
}

void printresult(int n)
{
    Console.WriteLine(n);
}

int[] array = NewArray(input(5, 20));
print(array);
printresult(Calculation(array));