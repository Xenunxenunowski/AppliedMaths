namespace AppliedMaths.BasicMath;

public class FractionOperations
{
    public static Fraction AddFractions(Fraction fraction1, Fraction fraction2)
    {
        int lcm = Something.LeastCommonMultiple(fraction1.Denominator, fraction2.Denominator);
        return new Fraction((lcm / fraction1.Denominator * fraction1.Numerator) + (lcm / fraction2.Denominator * fraction2.Numerator), lcm);
    }
    public static Fraction MultiplyFractions(Fraction fraction1, Fraction fraction2)
    {
        int lcm = Something.LeastCommonMultiple(fraction1.Denominator, fraction2.Denominator);
        return new Fraction((lcm / fraction1.Denominator * fraction1.Numerator) + (lcm / fraction2.Denominator * fraction2.Numerator), lcm);
    }

    public static Fraction DivideFractions(Fraction fraction1, Fraction fraction2)
    {
        return new Fraction(0,0);
    }
}