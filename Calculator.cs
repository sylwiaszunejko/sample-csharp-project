namespace SampleLibrary;

/// <summary>
/// A sample calculator class demonstrating basic mathematical operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two integers and returns the result.
    /// </summary>
    /// <param name="a">The first number to add.</param>
    /// <param name="b">The second number to add.</param>
    /// <returns>The sum of the two numbers.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second number from the first and returns the result.
    /// </summary>
    /// <param name="a">The number to subtract from.</param>
    /// <param name="b">The number to subtract.</param>
    /// <returns>The difference between the two numbers.</returns>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two integers and returns the result.
    /// </summary>
    /// <param name="a">The first number to multiply.</param>
    /// <param name="b">The second number to multiply.</param>
    /// <returns>The product of the two numbers.</returns>
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides the first number by the second and returns the result.
    /// </summary>
    /// <param name="a">The dividend.</param>
    /// <param name="b">The divisor.</param>
    /// <returns>The quotient of the division.</returns>
    /// <exception cref="DivideByZeroException">Thrown when the divisor is zero.</exception>
    public double Divide(double a, double b)
    {
        if (Math.Abs(b) < double.Epsilon)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }
}
