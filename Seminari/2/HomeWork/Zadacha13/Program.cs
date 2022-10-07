int Input()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}

void Output(int N)
{
    int a = N;
    int i = 0;
    while (a>0)
    {
        a = a/10;
        i++;
    }
    int [] array = new int[i];
    i = 0;
    while (N>0)
    {
        array[i] = N % 10;
        N = N/10;
        i++;
    }

    if (array.Length >=3)
    {
        Console.WriteLine($"Третье число {array[array.Length-3]}");
    }
    else
    {
        Console.WriteLine("Третье число отсутствует");
    }
}

Output(Input());