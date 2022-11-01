int Input()
{
    int i = 0;
    bool flag = false;
    while(!(flag && i!=0))
    {
        Console.WriteLine("Введите число не равное 0");
        flag = int.TryParse(Console.ReadLine(), out i);
    }      
    return i;
}

int Calculate(int a, int b)
{
    int result = 0;
    if(a>0)
    {
        if(b>0) result = 1;
        else result = 4;
    }
    else
    {
        if(b>0) result = 2;
        else result = 3;
    } 
    return result;
} 

void Output(int a)
{    
    Console.WriteLine($"Точка находится в {a} четверти");     
}

Output(Calculate(Input(), Input()));