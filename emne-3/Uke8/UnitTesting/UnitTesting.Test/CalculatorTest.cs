namespace UnitTesting.Test;

public class CalculatorTest
{
    [Test]
    public void Test1()
    {
        // arrange
        var calc = new UnitTesting.Calculator();
        // act
        var sum = calc.Addition(1, 1);
        // assert
        Assert.That(sum, Is.EqualTo(2));
    }
    
    [Test]
    public void Test2()
    {
        var calc = new UnitTesting.Calculator();
        var sum = calc.Subtraction(1, 1);
        Assert.That(sum, Is.EqualTo(0));
    }
    
    [Test]
    public void Test3()
    {
        var calc = new UnitTesting.Calculator();
        var sum = calc.Multiplication(1, 1);
        Assert.That(sum, Is.EqualTo(1));
    }
    
    [Test]
    public void Test4()
    {
        var calc = new UnitTesting.Calculator();
        var sum = calc.Division(1, 1);
        Assert.That(sum, Is.EqualTo(1));
    }
}