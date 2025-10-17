using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string wynik;
        for (int i = 0; i < n; i++)
        {
            wynik = IsPrime(int.Parse(Console.ReadLine())) == true ? "TAK" : "NIE";
            Console.WriteLine(wynik);
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
