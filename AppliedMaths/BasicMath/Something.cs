namespace AppliedMaths.BasicMath;

public class Something
{
    //https://en.wikipedia.org/wiki/Least_common_multiple
    public static int LeastCommonMultiple(int firstNumb, int secondNumb)
    {
        //using Greatest Common Divisor 
        return Math.Abs(secondNumb)*Math.Abs(firstNumb / GreatestCommonDivisor(firstNumb, secondNumb));
    }
    
    //https://en.wikipedia.org/wiki/Greatest_common_divisor
    public static int GreatestCommonDivisor(int firstNumb, int secondNumb)
    {
        while (secondNumb != 0)
        {
            int temp = secondNumb;
            secondNumb = firstNumb % secondNumb;
            firstNumb = temp;
        }
        return firstNumb;
    }
}