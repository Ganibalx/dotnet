void FindWords(string bukvi, char[] word, int length = 0)
{
    if(length == word.Length)
    {
        Console.WriteLine(new String (word));
        return; 
    }
    for (int i = 0; i<bukvi.Length; i++)
    {
        word[length] = bukvi[i];
        FindWords( bukvi, word, length +1);
    }
}

FindWords("Пока", new char[2]);