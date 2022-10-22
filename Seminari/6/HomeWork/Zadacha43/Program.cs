double input(string a)
{
    Console.Write($"Введите {a}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = input("Введите К1");
double b1 = input("Введите B1");
double k2 = input("Введите K2");
double b2 = input("Введите B2");
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine($"Точки пересечения [{x},{y}]");