double GetValue(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print (double ax, double ay, double bx, double by, double result)
{
string output = "|A(" + ax + ", " + ay + ")| " + "|B(" +bx + ", "+ by + ")| = " + result;
Console.WriteLine(output);
}

double GetDistans (double ax, double ay, double bx, double by)
{
    double result = Math.Sqrt(Math.Pow((ax-bx),2)+Math.Pow((ay-by),2));
    return result;
}

double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");

Print (ax, ay, bx, by, GetDistans(ax, ay, bx, by));