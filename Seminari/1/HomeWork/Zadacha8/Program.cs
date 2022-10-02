int N = -20;
int i = 1;
if (i<N)
{
    while (i<=N)
    {
       if (i % 2 == 0)
       {
           Console.Write(i+ ", ");
      }
      i += 1;
    }
}
else
{
    while (N<=i)
        {
        if (N % 2 == 0)
        {
            Console.Write(N+ ", ");
        }
        N += 1;
        }
}
