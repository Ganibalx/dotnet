int input(int a, int b)
{
    return new Random().Next(a, b);
}

int Parity(int [] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            n += 1;
        }
    }
    return n;
}

int[] NewArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = input(100, 1000);
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

int[] array = NewArray(input(20, 50));
print(array);
printresult(Parity(array));