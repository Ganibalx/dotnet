//Выяснить являются ли три числа сторонами треугольника

int input(string a)
{
    Console.WriteLine($"Введите длинну отрезка {a}");
    return Convert.ToInt32(Console.ReadLine());
}

bool Output(int a, int b, int c)
{
    return (a+b>c && a+c>b && b+c>a);
}

Console.WriteLine(Output(input("a"), input("b"), input("c")));
