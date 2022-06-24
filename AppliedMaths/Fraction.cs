using AppliedMaths.BasicMath;

namespace AppliedMaths;

public class Fraction
{
    public int Numerator;
    public int Denominator;
    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
    // FRACTION OPERATORS
    
    // +
    public static Fraction operator +(Fraction fraction1 , Fraction fraction2)
    {
        int lcm = Something.LeastCommonMultiple(fraction1.Denominator, fraction2.Denominator);
        return new Fraction((lcm / fraction1.Denominator * fraction1.Numerator) + (lcm / fraction2.Denominator * fraction2.Numerator), lcm);
    }
    public static Fraction operator +(Fraction fraction1) => fraction1;
    
    // -

    public static Fraction operator -(Fraction fraction1, Fraction fraction2)
    {
        int lcm = Something.LeastCommonMultiple(fraction1.Denominator, fraction2.Denominator);
        return new Fraction((lcm / fraction1.Denominator * fraction1.Numerator) - (lcm / fraction2.Denominator * fraction2.Numerator), lcm);
    }

    public static Fraction operator -(Fraction fraction1) => new Fraction(-fraction1.Numerator, fraction1.Denominator);

    public override string ToString()
    {
        return (Numerator + "/" + Denominator);
    }
}