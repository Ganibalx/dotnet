char[,] FieldRendering(char[,] array) //Заполнение массива пробелами
{
  for(int i = 0; i<15; i++)
  {
    for(int j = 0; j<20; j++)
    {
      array[i,j]= ' ';
    }
  }    
  return array;
}
char[,] Frame(char[,] array) // заполнение рамки в массиве
{
  for(int i = 0; i<15; i++)
  {
    if(i<14)
    {
      for(int j = 0; j<20; j+=19)
    {
      array[i,j]= '#';
    }
    }
    else
    {
      for(int j = 0; j<20; j++)
    {
      array[i,j]= '#';
    }
    }    
  }    
  return array;
}
void Output(char[,] array) // Вывод на экран
{
  for(int i = 0; i<15; i++)
  {    
    for(int j = 0; j<20; j++)
    {
      Console.Write(array[i,j]);
    }
    Console.WriteLine();
  }      
}
char[,] DrawingTheSquare(char[,] array, int x, int y) // логика квадрата
{
  for(int i = x; i<=x+1; i++)
  {
    for(int j = y; j<=y+1; j++)
    {
      array[i,j]= '#';
    }       
  }    
  return array;
}

char[,] field = new char[15,20];
int x = 0;
int y = 9;
int [] a = {x,y};
int [] b = {x,y+1};
int [] c = {x+1,y};
int [] d = {x+1,y+1};

new Thread(() =>
{
  while (true)
  {
    Console.Clear();
    field= DrawingTheSquare(Frame(FieldRendering(field)), x, y);
    Output(field);   
    Console.CursorVisible = false;
    Thread.Sleep(500);
    x ++;    
  }
}).Start();
