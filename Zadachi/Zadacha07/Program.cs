int Input()
{
    Console.WriteLine("Введите N");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

void Print(int N)
{
 int i = -N;
 while (i <= N)
 {
    Console.Write($"{i}, ");
    i ++;
 }
}

Print(Input());