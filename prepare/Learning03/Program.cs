using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(3,4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.SetDecimalvalue());

        Fraction fraction2 = new Fraction(6,1);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.SetDecimalvalue());

        Fraction fraction3 = new Fraction(6,7);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.SetDecimalvalue());

    }
}