namespace AppliedMaths;

public class Fraction
{
    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
    
    public int Numerator;
    public int Denominator;

    public override string ToString()
    {
        return (Numerator + "/" + Denominator);
    }
}