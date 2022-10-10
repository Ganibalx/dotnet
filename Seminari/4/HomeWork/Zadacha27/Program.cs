int Input()
{
    int i = 0;
    bool falg = false;
    while (!falg)
    {
        Console.WriteLine("Введите число");
        falg = int.TryParse(Console.ReadLine(), out i);
    }
    return (Math.Abs(i));
}

int Calculation(int a)
{
    int result = 0;
    while(a>0)
    {
        result+=a%10;
        a/=10;
    }  
    return result;
}

int a = Input();
Console.WriteLine($"{a} -> {Calculation(a)}");