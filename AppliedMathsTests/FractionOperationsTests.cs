using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppliedMaths;
using AppliedMaths.BasicMath;

namespace AppliedMathsTests;

[TestClass]
public class FractionOperationsTests
{
    [TestMethod]
    public void AddOperation()
    {
        Assert.AreEqual(FractionOperations.AddFractions(new Fraction(323, 10), new Fraction(54645, 29321)).ToString()  , new Fraction(10017133,293210).ToString());
    }
    [TestMethod]
    public void AddOperationWithSign()
    {
        Assert.AreEqual(FractionOperations.AddFractions(new Fraction(323, 10), new Fraction(54645, 29321)).ToString()  , new Fraction(10017133,293210).ToString());
    }
    [TestMethod]
    public void MultiplyOperation()
    {
        Assert.AreEqual(FractionOperations.AddFractions(new Fraction(323, 10), new Fraction(54645, 29321)).ToString()  , new Fraction(10017133,293210).ToString());
    }
    [TestMethod]
    public void MultiplyOperationWithSign()
    {
        Assert.AreEqual(FractionOperations.AddFractions(new Fraction(323, 10), new Fraction(54645, 29321)).ToString()  , new Fraction(10017133,293210).ToString());
    }
}