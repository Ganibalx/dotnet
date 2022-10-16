int Input()
{
    int i = 0;
    bool flag = false;
    while(!(flag && Math.Abs(i)>9))
    {
        Console.WriteLine("Введите число");
        flag = int.TryParse(Console.ReadLine(), out i);
    }
    return i;
}

int Calculation(int a)
{
    return (a / 100)*10 + a % 10;
}

Console.WriteLine(Calculation(Input()));