bool Calculation(bool x, bool y)
{
    bool result = false;
    if(!(x || y) == (!x && !y)) result = true;
    return result;
}

void Output (bool [] array)
{
    int result = 0;
    for(int i =0; i<array.Length; i++)
    {
        if(array[i]==false) result++;
    }
    if(result==0)
    Console.WriteLine("Выражение истино");
    else
    Console.WriteLine("Выражение ложно");
}

bool x = false;
bool y = false;
bool [] result = new bool[4];
int flag = 0;
for(int i = 0; i <= 1; i++)
{
    if(i==1) x = true;
    for(int j = 0; j <= 1; j++)
    {
        if(j ==1 ) y = true;
        result[flag] = Calculation(x, y);
        flag ++;
    }
}
Console.WriteLine(string.Join(' ', result));
Output(result);

