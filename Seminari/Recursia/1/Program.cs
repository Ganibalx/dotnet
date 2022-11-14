int Input()
{
    Console.WriteLine("Введите N");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

int Print(int N)
{ 
 if(N == 0) return 0;
 else return N + Print(N-1); 
}

int n = Input();
Console.WriteLine(Print(n));