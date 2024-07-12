using System;

class Calculator
{
    public double Add(double a, double b)
    {
    }

    public double Subtract(double a, double b)
    {
        return a-b;
    }

    public double Multiply(double a, double b)
    {
    }

    public double Divide(double a, double b)
    {
    }
}
}
using System;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        double sum = calculator.Add(num1, num2);
        double difference = calculator.Subtract(num1, num2);
        double product = calculator.Multiply(num1, num2);
        double quotient = calculator.Divide(num1, num2);

        Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
        Console.WriteLine($"Difference of {num1} and {num2} is: {difference}");
        Console.WriteLine($"Product of {num1} and {num2} is: {product}");
        Console.WriteLine($"Quotient of {num1} and {num2} is: {quotient}");

        Console.ReadLine();
    }
}
