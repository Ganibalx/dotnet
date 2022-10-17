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

char[,] field = new char[15,20];
Frame(FieldRendering(field));
new Thread(() =>
{
  while (true)
  {
    Console.Clear();
    Output(field);
    Console.CursorVisible = false;
    Thread.Sleep(500);    
  }
}).Start();
