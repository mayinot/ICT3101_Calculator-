using NUnit.Framework;
namespace ICT3101_Calculator_Lab2.UnitTests;

public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
    }

    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(20, 30);
        // Assert
        Assert.That(result, Is.EqualTo(50));
    }

    [Test]
    public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtraction()
    {
        // Act
        double result = _calculator.Subtract(20, 10);
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiplication()
    {
        // Act
        double result = _calculator.Multiply(2233, 333);
        // Assert
        Assert.That(result, Is.EqualTo(743589));
    }

    [Test]
    public void Multiply_WhenMultiplyingWithZero_ResultEqualToZero()
    {
        // Act
        double result = _calculator.Multiply(27388338, 0);
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Divide_WhenDividingWithTwoNumbers_ResultEqualToDivision()
    {
        // Act
        double result = _calculator.Divide(27, 2);
        // Assert
        Assert.That(result, Is.EqualTo(13.5));
    }

    [Test]
    [TestCase(0,0)]
    [TestCase(0,10)]
    [TestCase(10, 0)]
    public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
    {
        // Act
        // Assert
        Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
    }

    [Test]
    public void Factorial_WithPosInput_ResultEqualToFactorial()
    {
        // Act
        double result = _calculator.Factorial(10);
        // Assert
        Assert.That(result, Is.EqualTo(3628800));
    }

    [Test]
    public void Factorial_WithNegInput_ResultThrowArgumentException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);
    }


    [Test]
    public void AreaOfTriangle_WhenGivenLengthHeight_ResultEqualToArea()
    {
        // Act
        double result = _calculator.AreaOfTriangle(10, 20);
        // Assert
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    [TestCase(0, 0)]
    [TestCase(0, 10)]
    [TestCase(10, 0)]
    public void AreaOfTriangle_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
    {
        // Act
        // Assert
        Assert.That(() => _calculator.AreaOfTriangle(a, b), Throws.ArgumentException);
    }

    [Test]
    [TestCase(-1, -9)]
    [TestCase(-1, 10)]
    [TestCase(10, -1)]
    public void AreaOfTriangle_WithNegNumsAsInputs_ResultThrowArgumentException(int a, int b)
    {
        // Act
        // Assert
        Assert.That(() => _calculator.AreaOfTriangle(a, b), Throws.ArgumentException);
    }

    [Test]
    public void AreaOfCircle_WhenGivenRadius_ResultEqualToArea()
    {
        // Act
        double result = _calculator.AreaOfCircle(5);
        // Assert
        double pi = 3.1415926535897931;
        Assert.That(result, Is.EqualTo(25*pi));
    }

    [Test]
    public void AreaOfCircle_WithZeroAsInputs_ResultThrowArgumentException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.AreaOfCircle(0), Throws.ArgumentException);
    }

    [Test]
    public void AreaOfCircle_WithNegNumInputs_ResultThrowArgumentException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.AreaOfCircle(-2), Throws.ArgumentException);
    }

    // UnknownFunctionA’s Unit tests:
    // [Hint a. involves the following function uses: 2 Factorials, 1 Divide, and 1 Subtract.]
    [Test]
    public void UnknownFunctionA_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(60));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
    }

    //  UnknownFunctionB’s Unit tests:
    // [Hint b. involves the following function uses: 3 Factorials, 1 Divide, 1 Multiply, and 1 Subtract.]
    [Test]
    public void UnknownFunctionB_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
    }
}
