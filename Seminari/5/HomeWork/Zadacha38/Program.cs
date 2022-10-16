int input(int a, int b)
{
    return new Random().Next(a, b);
}

double Calculation(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

double[] NewArray(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = input(-100, 101) + (input(0, 100) * 0.01);
    }
    return array;
}

void print(double[] array)
{
    Console.WriteLine(string.Join(' ', array));
}

void printresult(double n)
{
    Console.WriteLine(Math.Round(n, 2));
}

double[] array = NewArray(input(5, 10));
print(array);
printresult(Calculation(array));