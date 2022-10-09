int Input()
{
    int i = 0;
    bool flag = false;
    while (!flag)
    {
        Console.WriteLine("Введите для скольки чисел вывести таблицу кубов");
        string data = Console.ReadLine();
        flag = int.TryParse(data, out i);
        i = Math.Abs(i);
    }
    return i;
}

void Output(int n)
{
    Console.Write($"{n} -> ");
    for (int i = 1; i <= n; i++)
    {
        Console.Write($" {Math.Pow(i, 3)},");
    }
}

Output(Input());