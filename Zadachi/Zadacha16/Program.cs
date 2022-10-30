int NumberEntry()
{
    Console.WriteLine("Введите номер дня недели");
    return Convert.ToInt32(Console.ReadLine());
}

bool Checking(int n)
{
    return (n >0 && n <8);
}

string [] Sunday = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int d = NumberEntry();
if (Checking(d))
{
    if (d > 5)
    {
        Console.WriteLine($"{Sunday[d-1]} - выходной");
    }
    else
    {
        Console.WriteLine($"{Sunday[d-1]} - не выходной");
    }
}
else
{
    Console.WriteLine("Заданный день должен лежать в интервале от 1 до 7");
}