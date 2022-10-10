int InputVisitors()
{
    return new Random().Next(1, 20);
}

string InputTime()
{
    int a = new Random().Next(0, 23);
    int b = new Random().Next(0, 23);
    string result = $"{a}-{b}";
    if (a == b)
    {
        result = $"{a}";
    }
    else
    {
        if (a > b)
        {
            result = $"{b}-{a}";
        }
    }
    return result;
}

int [] Transformation(string a)
{
    if(a.Length > 2)
    {
        string[] s = a.Split('-');
        int i = Convert.ToInt32(s[1]) - Convert.ToInt32(s[0]) + 1;
        int[] result = new int[i];
        for (int j = 0; j < result.Length; j++)
        {
            result[j] = Convert.ToInt32(s[0]) + j;
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

int[] calculationTime(int[] array, int[] a)
{
    int i = 0;
    while (i < a.Length)
    {
        array[a[i]]++;
        i++;
    }
    return array;
}

void Output(int[] array)
{
    int max = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
    }
    bool q = true;
    int a = 0;
    int b = 0;
    string result = string.Empty;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] == max)
        {
            a = i;
            q=true;
            while (q)
            {
                if (array[i + 1] == max)
                {
                    i++;
                    b = i;
                }
                else
                {
                    b = i;
                    i++;
                    q = false;
                }
            }
            if (b > a)
            {
                result = result + $" {a}-{b},";
            }
            else
            {
                result = result + $" {a},";
            }
        }
        else
        {
            i++;
        }
    }
    Console.WriteLine(result);
}

int n = InputVisitors();
int[] time = new int[24];
for (int i = 0; i < n; i++)
{
    time = calculationTime(time, Transformation(InputTime()));
}
Output(time);



