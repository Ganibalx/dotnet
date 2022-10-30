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

bool Calculate(int a)
{
    bool result = false;
    if (a % 7 == 0 || a % 23 ==0) result = true;
    return result;
} 

void Output(bool a)
{
    if(a)
    Console.WriteLine("Кратно");
    else
    Console.WriteLine("Не кратно");    
}

Output(Calculate(Input()));