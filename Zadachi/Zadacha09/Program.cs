int Input()
{
    Console.WriteLine("Введите трехзначное число");
    return Convert.ToInt32(Console.ReadLine());
}

void Output(int N)
{
    Console.WriteLine("Третье число - " + N % 10 );
}

Output(Input());