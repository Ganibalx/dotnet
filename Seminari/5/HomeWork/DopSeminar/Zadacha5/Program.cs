int inputN(string a)
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
bool Calculation(int[] array, int a)
{    
    bool result=false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]==a) result = true;        
    }    
    return result;
}
int[] NewArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0,50);
    }
    return array;
}
void print(string a)
{
    Console.WriteLine(a);
}
void printarray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int [] array = NewArray(inputN("Введите кол-во элементов массива: "));
printarray(array);
if(Calculation(array, inputN("Введите число для поиска: "))) print("Данный элемент есть");
else print("Данного элемента нет");