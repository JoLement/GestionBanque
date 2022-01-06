using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Banque;

namespace UnitTestBasicMaths
{
    [TestClass]
    public class UnitTestMaths
    { 
    [TestMethod]
    public void BasicMaths_DivisionParZero()
    {
        // Arrange
        double num1 = 10;
        double num2 = 0;

        BasicMaths math = new BasicMaths();
        // Act
        try
        {
            math.divide(num1, num2);
        }
        catch (System.DivideByZeroException)
        {
            // Assert
            Assert.ThrowsException<System.DivideByZeroException>(() => math.divide(num1, num2));
            return;
        }


    }
    [TestMethod]
    public void BasicMaths_PLusEqual()
    {
        // Arrange
        double num1 = 5;
        double num2 = 2;
        double expected = 7;
        BasicMaths math = new BasicMaths();
        // Act
        double actual = math.Add(num1, num2);
        // Assert

        Assert.AreEqual(expected, actual, 0.001, "Problème dans la méthode Add");
    }

    [TestMethod]
    public void BasicMaths_MinusEqual()
    {
        // Arrange
        double num1 = 5;
        double num2 = 2;
        double expected = 3;
        BasicMaths math = new BasicMaths();
        // Act
        double actual = math.Substract(num1, num2);
        // Assert

        Assert.AreEqual(expected, actual, 0.001, "Problème dans la méthode Add");
    }
    [TestMethod]
    public void BasicMaths_divideEqual()
    {
        // Arrange
        double num1 = 6;
        double num2 = 2;
        double expected = 3;
        BasicMaths math = new BasicMaths();
        // Act
        double actual = math.divide(num1, num2);
        // Assert

        Assert.AreEqual(expected, actual, 0.001, "Problème dans la méthode Add");
    }
    [TestMethod]
    public void BasicMaths_MultiplyEqual()
    {
        // Arrange
        double num1 = 5;
        double num2 = 2;
        double expected = 10;
        BasicMaths math = new BasicMaths();
        // Act
        double actual = math.Multiply(num1, num2);
        // Assert

        Assert.AreEqual(expected, actual, 0.001, "Problème dans la méthode Add");
    }
}
}
