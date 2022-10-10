int InputVisitors() 
{
    return new Random().Next(1,100); 
}

string InputTime ()
{
    int a = new Random().Next(0,23);
    int b = new Random().Next(0,23);
    string result = $"{a}-{b}";
    if(a==b)
    {
        result = $"{a}";
    }
    else
    {
        if (a>b)
        {
            result = $"{b}-{a}";
        }
    }
    return result
}

int [] Transformation(string a)
{
    if(a.Length>2)
    {
    string [] s = a.Split('-');
    int i = Convert.ToInt32(s[1])-Convert.ToInt32(s[0])+1;
    int [] result = new int [i];
    for(int j = 0; j<result.Length; j++)
    {
        result[i] = Convert.ToInt32(s[0])+j;
    }
    }
    else
    {
        int [] array = new int[1];
        array[0] = Convert.ToInt32(a);
    }
    return array;
}

int [] calculationTime (int [] array, int [] a)
{
    int i = 0;
    while (i<a.Length)
    {
        array[a[i]]++;
        i++;
    }
    return array;
}

void Output(int [] array)
{
    int max = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>max)
        {
            max=array[i];
        }
    }
    for(i=0; i<array.Length; i++)
    {
        if(array[i]==max)
        {
            while()
        }
    }
    }
}



