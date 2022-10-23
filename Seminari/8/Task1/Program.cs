int Input(string a)
{
    Console.WriteLine(a);
    return Convert.ToInt32(Console.ReadLine());
}

int Calculation(int a, int b)
{    
    if(a>b) return 0;    
    else
    {
        if(a==b) return 1;
        else
        {
            if(a*3<=b) return  (Calculation(a*3, b)+Calculation(a+1, b));
            else return Calculation(a+1, b);
        }
    }        
}

int a = Input("Введите число А");
int b = Input("Введите число b");
int c = 0;
if (a > b)
{
    c = a;
    a = b;
    b = c;
}
Console.WriteLine(Calculation(a, b));