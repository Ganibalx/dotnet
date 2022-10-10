int[] Generation()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void print(int[] array)
{
    Console.WriteLine(string.Join(' ', array));
}

print(Generation());