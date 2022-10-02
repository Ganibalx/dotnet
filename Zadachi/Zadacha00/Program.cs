//Вывести квадрат числа

double Chislo()
{
    Console.WriteLine("Введите число для возведения в квадрат");
    double A = Convert.ToDouble(Console.ReadLine());
    return A;        
}

double A = Chislo();
Console.WriteLine($"{A}^2 = {Math.Round(Math.Pow(A,2), 3)}");