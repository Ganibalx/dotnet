int Input()
{
    int i = 0;
    bool flag = false;
    while(!flag)
    {
        Console.WriteLine("Введите число");
        flag = int.TryParse(Console.ReadLine(), out i);
    }      
    return Math.Abs(i);
}

bool Calculate(int a, int b)
{
    bool result = false;
    if (a*a == b) result = true;
    return result;
} 

void Output(bool a)
{
    if(a)
    Console.WriteLine("Яфляется квадратом");
    else
    Console.WriteLine("Не является квадратом");    
}

Output(Calculate(Input(), Input()));