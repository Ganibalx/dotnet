//int n = 999;// 10 <= n <= 1000
//int[] arr = new int[n];// 0..100
// {1,2,1,1,1,1,2,2,2,3,3,3,3, 8,9}
// 1 - 5р
// 2 - 4р
// 3 - 4р
// 8 - 1р
// 9 - 1р

int Input(string ad)
{
    Console.WriteLine(ad);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int n, int b)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, b);
        Console.Write($"{array[i]} ,");
    }
    Console.WriteLine();
    return array;
}

int[] Output(int[] array, int b)
{
    int[] result = new int[b];
    for (int i = 0; i < array.Length; i++)
    {
        result[array[i]] += 1;
    }
    return result;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i} -> {array[i]} раз");
    }
}

int b = Input("Ведите маккс возможных значений массива");
Print(Output(Array(Input("Ведите кол-во элементов массива"), b), b));
