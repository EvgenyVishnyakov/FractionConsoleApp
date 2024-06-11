namespace FractionConsoleApp;

public class Fraction
{
    /// <summary>
    /// Числитель
    /// </summary>
    public int Numerator;
    /// <summary>
    /// Знаменатель
    /// </summary>
    public int Denominator;

    public Fraction(int number)
    {
        Numerator = number;
        Denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
          Numerator = numerator;
          Denominator = denominator;              
    }    
    public void Print()
    {
        GetReduceFraction();
        if (Denominator == 1)
        {
            Console.WriteLine(Numerator);
        }
        else if (Math.Abs(Numerator) > Denominator && Numerator < 0)
        {
            Numerator *= -1;
            int wholeNumber = GetWholeNumber();
            Console.WriteLine($"-{wholeNumber}_{Numerator}/{Denominator}");
        }
        else if (Numerator > Denominator)
        {
            int wholeNumber = GetWholeNumber();
            Console.WriteLine($"{wholeNumber}_{Numerator}/{Denominator}");
        }
        else
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }
    }
    private void GetReduceFraction()
    {
        for (int i = 2; i <= Math.Min(Numerator, Denominator); i++)
        {
            while (Numerator % i == 0 && Denominator % i == 0)
            {
                Numerator /= i;
                Denominator /= i;
            }
        }
    }
    private int GetWholeNumber()
    {
        int wholeNumber = Numerator / Denominator;
        GetNumerator(wholeNumber);
        return wholeNumber;
    }
    private void GetNumerator(int wholeNumber)
    {
        Numerator -= wholeNumber * Denominator;
    }
    public Fraction Sum(Fraction otherFraction)
    {
        var commonDenominator = Denominator * otherFraction.Denominator;
        var resultNumenator = Numerator * otherFraction.Denominator + otherFraction.Numerator * Denominator;
        return new Fraction(resultNumenator, commonDenominator);
    }
    public Fraction Difference(Fraction otherFraction)
    {
        var commonDenominator = Denominator * otherFraction.Denominator;
        var resultNumenator = Numerator * otherFraction.Denominator - otherFraction.Numerator * Denominator;
        return new Fraction(resultNumenator, commonDenominator);
    }
    public Fraction Multiply(Fraction otherFraction)
    {
        return new Fraction(Numerator * otherFraction.Numerator, Denominator * otherFraction.Denominator);
    }
    public Fraction Devide(Fraction otherFraction)
    {
        return new Fraction(Numerator * otherFraction.Denominator, Denominator * otherFraction.Numerator);
    }
    public Fraction Sum(int number)
    {
        Fraction otherFraction = new Fraction(number);
        return Sum(otherFraction);
    }
    public Fraction Difference(int number)
    {
        Fraction otherFraction = new Fraction(number);
        return Difference(otherFraction);
    }
    public Fraction Multiply(int number)
    {
        Fraction otherFraction = new Fraction(number);
        return Multiply(otherFraction);
    }
    public Fraction Devide(int number)
    {
        Fraction otherFraction = new Fraction(number);
        return Devide(otherFraction);
    }
}
