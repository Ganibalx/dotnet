string Input()
{
    Console.WriteLine("Введите коардинаты точки через запятую, без пробелов");
    return Console.ReadLine();
}

int [] processing(string coordinate)
{
    string[] words = coordinate.Split(',');
    int [] array = new int[words.Length];
    for(int i=0; i< array.Length; i++)
    {
        array[i]= Convert.ToInt32(words[i]);        
    }
    return array;
}

void Output(int [] a, int [] b)
{
    double result = 0;
    for (int i=0; i<a.Length; i++)
    {
        result=result + Math.Pow((a[i]-b[i]),2);
    }
    Console.WriteLine(Math.Round(Math.Sqrt(result),3));
}

Output(processing(Input()), processing(Input()));