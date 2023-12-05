using calculator_nuget_demo.Contracts;

namespace calculator_nuget_demo;

public class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }  
}