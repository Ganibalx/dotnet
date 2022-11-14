int Input(string a)
{
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}

int Print(int m, int n)
{ 
 if(n == m) return n;
 else return n + Print(m, n-1); 
}

Console.WriteLine(Print(Input("Введите m: "), Input("Введите n: ")));