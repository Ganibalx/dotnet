double Сorner()
{
    Console.WriteLine("Введите a для поиска y = f(a)");
    double a = Convert.ToDouble(Console.ReadLine());
    return a;
}

double Сalculation(double a)
{
    double y = Math.Sin(a)+(1-Math.Cos(a));
    return y;
}

Console.WriteLine(Math.Round(Сalculation(Сorner()),3));
