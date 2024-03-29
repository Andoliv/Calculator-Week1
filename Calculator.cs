internal class Calculator : CalculatorBase 
{
    public override int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public override int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public override int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public override int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}
