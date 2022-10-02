int GetN()
{
    Console.Write("Введите N: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void Print(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.WriteLine($"{array[i]}^2 = {Math.Pow(array[i], 2)}");
        i++;
    }
}

int i = 0;
int N =GetN();
int[] array = new int [N];

while (i < N)
{
    array[i] = i + 1;
    i++;
}

Print(array);


