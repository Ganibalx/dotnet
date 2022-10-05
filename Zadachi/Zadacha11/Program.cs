int RandomNumber()
{

}

void Output(int n)
{
    int a = n/10;
    int b = n%10;
    if (a=b)
    {
        Console.WriteLine(&"Числа равны {a}");
    }
    else
    {
        if (a>b)
        {
            Console.WriteLine(&"Наибольшее число {a}");
        }
        else
        {
            Console.WriteLine(&"Наибольшее число {b}");
        }
    }
}

int n = RandomNumber();
Console.WriteLine($"заданное число {n}");
Output(n);
