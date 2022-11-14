int Input()
{
    Console.WriteLine("Введите N");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

void Print(int N, int i)
{ 
 while (i <= N)
 {    
    Console.WriteLine(i);
    Print(N, i+1);
    return;
 } 
return;
}
int n = Input();
Print(n, -n);