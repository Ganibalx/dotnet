int Input()
{
    int i = 0;
    bool flag = false;
    while(!(flag && i>0))
    {
        Console.WriteLine("Введите сколько вывести четных кубов");
        flag = int.TryParse(Console.ReadLine(), out i);
    }      
    return i;
}

int [] Calculate(int a)
{
    int [] result = new int[a];
    int per = 1;
    for(int i = 1; i < result.Length; i++)
    {
        while(Math.Pow(per,3)%2 != 0)
        per += 1;
        result[i] = Convert.ToInt32(Math.Pow(per,3));
        per += 1;
    }
    return result;
} 

void Output(int [] a)
{    
    Console.WriteLine($"Кубы :{string.Join(' ', a)}");     
}

Output(Calculate(Input()));