int Input()
{
    int i = 0;
    bool flag = false;
    while(!(flag && i>0))
    {
        Console.WriteLine("Введите число");
        flag = int.TryParse(Console.ReadLine(), out i);
    }      
    return i;
}

int Calculate(int a)
{
    int result = 0;
    while(a>0)
    {
        a/=10;
        result++;
    }
    return result;
} 

void Output(int a)
{    
    Console.WriteLine($"Кол-во цифр в числе {a}");     
}

Output(Calculate(Input()));