string input()
{
    string result = string.Empty;
    string a = string.Empty;
    bool flag = false;
    int i= 0;
    Console.WriteLine("Введите несколько чисел, после каждого числа нажмите Enter, по окончании ввода введите любую букву и нажмите Enter");
    while(!flag)
    {
        a=Console.ReadLine();
        if(int.TryParse(a, out i))
        {
            if(String.IsNullOrWhiteSpace(result))
            {
                result = Convert.ToString(i);
            }
            else
            {
                result = result + "#" + Convert.ToString(i);            
            }
        }
        else
        {
            flag=true;
        }
    }
    return result;
}
int [] Conversion(string a)
{    
    if(a.Length > 2)
    {
        string[] s = a.Split('#');        
        int[] result = new int[s.Length];
        for (int i = 0; i < result.Length; i++)
        {            
            result[i] = Convert.ToInt32(s[i]);
        }        
        return result;
    }
    else
    {
        int[] result = new int[1];
        result[0] = Convert.ToInt32(a);
        return result;
    }
}
int Output(int[]array)
{
    int result = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>0) result++;        
    }
    return result;
}

int [] array = Conversion(input());
Console.WriteLine(string.Join(' ', array));
Console.WriteLine($"Чисел бюольше 0 {Output(array)}");