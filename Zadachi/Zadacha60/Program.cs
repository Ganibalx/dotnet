char [] Count(string a)
{
    char[] result = new char[a.Length];
    bool b = false;
    for(int i=0; i<a.Length; i++)
    {
        b = false;
        int j = 0;
        while(!b)
        {
            if(a[i] == result[j])
            {
                b = true;
            } 
            j++;
        } 
        if(b)
        {
            result
        }
    }


}