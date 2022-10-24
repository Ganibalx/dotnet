int inputN(string a)
{
    bool flag = false;
    int i = 0;
    while (!flag)
    {
        Console.Write(a);
        flag = int.TryParse(Console.ReadLine(), out i);
    }
    return Math.Abs(i);
}
int[] Calculation(int[] array)
{
    int n = 0;
    if (array.Length % 2 == 0)
    {
        n = array.Length / 2;
    }
    else
    {
        n = (array.Length / 2) + 1;
    }
    int[] result = new int[n];
    for (int i = 0; i < result.Length; i++)
    {
        if(i == array.Length - 1 - i) result[i]=array[i];
        else result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}
int[] NewArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
void printarray(int[] array)
{
    Console.WriteLine(string.Join(' ', array));
}

int[] array = NewArray(inputN("Введите кол-во элементов массива: "));
printarray(array);
printarray(Calculation(array));