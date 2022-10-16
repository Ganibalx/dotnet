int Input (string a)
{
    int result = 0;
    bool flag = false;
    while(!(flag && result!=0))
    {
        Console.WriteLine(a);
        flag = int.TryParse(Console.ReadLine(), out result);
    }
    return result;
}

bool Kratnost(int a, int b)
{
    return a % b == 0;
}

int b = Input ("Введите делитель");
int a = Input ("Введите проверяемое число на кратность");
if(Kratnost(a, b))
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine($"Не является, остаток {a % b}");
}

