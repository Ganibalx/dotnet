int Input(string a)
{
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}

int Print(int m, int n)
{ 
 if(m == 0) 
 return n+1;
 else
    if((m > 0) && (n == 0))
        return Print(m-1, 1);
    else
        return Print(m-1, Print(m, n-1));
 }   

Console.WriteLine(Print(Input("Введите m: "), Input("Введите n: ")));