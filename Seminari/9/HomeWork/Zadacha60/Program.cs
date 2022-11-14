int[] Filling(int [] array, int i = 10, int length = 0)
{
    if(length == array.Length)
    {
        return array; 
    }
    else
    {
        array[length] = i;
        return Filling(array, i+1, length+1);
    }
}

void Filling3D (int [] array, int x, int y, int z)
{
    int flag = 0;
    for(int i = 0; i<x ; i++)
        for(int j = 0; j<y ; j++)
        {
            for(int k = 0; k<z ; k++)
            {
                Console.Write($"{array[flag]}({i},{j},{k}), ");
                flag += 1;
            }
            Console.WriteLine();
        }     
}

int x = 4;
int y = 4;
int z = 3;
int [] result = new int [x*y*z];
Filling3D(Filling(result), x, y,  z);
