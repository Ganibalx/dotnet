int Input()
{
    bool flag = false;
    int i = 0;
    while(!flag)
    {
    Console.WriteLine("Введите число N");
    flag = int.TryParse(Console.ReadLine(), out i);
    }
    return i;
}

int [] Filling(int n)
{
    int[]array = new int[n];
    for(int i = 0; i < array.Length; i++)
    array[i]=i+1;
    return array;
}

