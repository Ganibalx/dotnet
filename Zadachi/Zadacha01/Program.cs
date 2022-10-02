// По двум заданным числам проверять является ли первое квадратом второго

int[] Chisla()
{
    Console.WriteLine("Введите проверяемое число и предпологаемый квадрат");
    int [] array = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
    return array;
}

int [] array =  Chisla();

if (Math.Pow(array[0],2)==array[1])
{
    Console.WriteLine($"Число {array[1]} является квадратом {array[0]}");
}
else
{
    Console.WriteLine($"Число {array[1]} не является квадратом {array[0]}");
}