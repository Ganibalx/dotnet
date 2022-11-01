int Input()
{
    int i = 0;
    bool flag = false;
    while(!(flag && i>0 && i<5))
    {
        Console.WriteLine("Введите номер четверти");
        flag = int.TryParse(Console.ReadLine(), out i);
    }      
    return i;
}

string [] Calculate(int a)
{
    string [] result = new string [2];
    switch(a)
    {
        case 1:
        result[0] = "1...10";
        result[1] = "1...10";
        break;
        case 2:
        result[0] = "-1...-10";
        result[1] = "1...10";
        break;
        case 3:
        result[0] = "-1...-10";
        result[1] = "-1...-10";
        break;
        case 4:
        result[0] = "1...10";
        result[1] = "-1...-10";
        break;
    }
    return result;
} 

void Output(string [] a)
{    
    Console.WriteLine($"в данную четверь входят коардинаты X: {a[0]}; коардинаты Y: {a[1]}");     
}

Output(Calculate(Input()));