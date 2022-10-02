int NumberEntry()
{
    Console.WriteLine("Введите номер дня недели");
    int d = Convert.ToInt32(Console.ReadLine());
    return d;
}

bool Checking(int n)
{
    return (n >0 && n <8);
}

string [] Sunday = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int d = NumberEntry();
if (Checking(d))
{
    Console.WriteLine($"Заданый день - {Sunday[d-1]}");
}
else
{
    Console.WriteLine("Заданный день должен лежать в интервале от 1 до 7");
}