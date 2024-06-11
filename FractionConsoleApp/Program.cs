namespace FractionConsoleApp;
public class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(2, 3);
        fraction1.Print();
        fraction2.Print();
        Fraction resultSum = fraction1.Sum(fraction2);
        resultSum.Print();
        Fraction resultDiffernce = fraction1.Difference(fraction2);
        resultDiffernce.Print();
        Fraction resultMultiply = fraction1.Multiply(fraction2);
        resultMultiply.Print();
        Fraction resultDevide = fraction1.Devide(fraction2);
        resultDevide.Print();
        Console.WriteLine("__________________________");
        Fraction resultSumNumber = fraction1.Sum(4);
        resultSumNumber.Print();
        Fraction resultDifferenceNumber = fraction1.Difference(4);
        resultDifferenceNumber.Print();
        Fraction resultMultiplyNumber = fraction1.Multiply(4);
        resultMultiplyNumber.Print();
        Fraction resultDevideNumber = fraction1.Devide(2);
        resultDevideNumber.Print();
    }
}
