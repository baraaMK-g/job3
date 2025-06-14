
using Xunit;
using UnitTestingDemo.Core;
namespace UnitTestingDemo.Tests;

public class CalculatorTests
{  //Multiply
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
     int a = 2, b = 3;
     int result = Calculator.Multiply(a, b);
     Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_NumberWithZero()
    {
     int a = 0, b = 5;
     int result =Calculator.Multiply(a, b);
     Assert.Equal(0, result);
    }

   [Fact]
   public void Multiply_NegativeAndPositiveNumber()
   {
    int a = -2, b = 3;
    int result = Calculator.Multiply(a, b);
    Assert.Equal(-6, result);
   }
   [Fact]
   public void Multiply_TwoNegativeNumbers_ReturnsPositive()
   {
   int a = -2, b = -3;
   int result = Calculator.Multiply(a, b);
   Assert.Equal(6, result);
   }

 //Divide
    [Fact]
    public void Divide_TwoPositiveNumbers()
    {
     int a = 16, b = 2;
    
     int result = Calculator.Divide(a, b);
     Assert.Equal(8, result);
    }
     
    [Fact]
    public void Divide_NegativeNumbers()
    {
        int a = -10, b = 2;
        int result = Calculator.Divide(a, b);
        Assert.Equal(-5, result);
    }


    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        int a = 10;
        int b = 0;
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }
    [Fact]
     public void Divide_ByOne_ReturnsSameNumber()
    {
            int a = 9, b = 1;
            int result = Calculator.Divide(a, b);
            Assert.Equal(9, result);
     }


 
    [Fact]
    public void isEven_returnTrue()
    {
     int a = 24;
     bool result = Calculator.isEven(a);
     Assert.True( result);
    }
    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        int number = 5;
        bool result = Calculator.isEven(number);
        Assert.False(result);
    }
       [Fact]
    public void IsEven_Zero_ReturnsTrue()
    {
        int number = 0;
        bool result = Calculator.isEven(number);
        Assert.True(result);
    }

    [Fact]
    public void IsEven_NegativeEvenNumber_ReturnsTrue()
    {

        int number = -4;
        bool result = Calculator.isEven(number);
        Assert.True(result);
    }

}
