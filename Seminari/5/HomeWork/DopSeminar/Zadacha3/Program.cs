int inputN(string a) // ввод числа с проверкой
{
    bool flag = false;
    int i=0;
    while(!flag)
    {
        Console.Write(a);
        flag=int.TryParse(Console.ReadLine(),out i);
    }
    return Math.Abs(i);
}
int [] Calculation(int[] array) //основной расчет
{       
    for (int i = 0; i < array.Length; i++)
    {
        array[i]*= -1;        
    }    
    return array;
}
int[] NewArray(int n) // заполнение одномерного массива заданной размерности
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-50,51);
    }
    return array;
}

void printarray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

int [] array = NewArray(inputN("Введите кол-во элементов массива: "));
printarray(array);
array = Calculation(array);
printarray(array);