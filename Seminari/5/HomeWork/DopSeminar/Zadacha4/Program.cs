int Calculation(int[] array) //основной расчет
{       
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) result++;        
    }    
    return result;
}
int[] NewArray(int n) // заполнение одномерного массива заданной размерности
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0,151);
    }
    return array;
}

int [] array = NewArray(123);
Console.WriteLine(string.Join(' ', array));
Console.WriteLine($"В интервале от 10 до 99 лежит - {Calculation(array)}");