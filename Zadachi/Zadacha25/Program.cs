int Input()
{
    int i = 0;
    bool flag = false;
    while(!(flag && i>0))
    {
        Console.WriteLine("Введите A");
        flag = int.TryParse(Console.ReadLine(), out i);
    }      
    return i;
}

int Calculate(int a)
{
    int result = 0;
    for(int i = 1; i <= a; i++)
    {
        result += i;
    }
    return result;
} 

void Output(int a)
{    
    Console.WriteLine($"сумма элементов от 1 до А равна {a}");     
}

Output(Calculate(Input()));