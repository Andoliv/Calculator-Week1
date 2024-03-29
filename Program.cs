
int option;
int num1;
int num2;

do
{
    try
    {
        Console.Clear();
        Console.WriteLine("Welcome to Calculator!");
        Console.WriteLine("\nPlease enter you intended math operation: ");
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");
        Console.Write("Choose an option: ");
        option = CheckOption(Convert.ToInt32(Console.ReadLine()));

        Console.Write("\nType a first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Type a second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Calculator calculator = new Calculator();

        switch (option)
        {
            case 1:
                Console.WriteLine($"\n\nAdd( {num1} + {num2} ) = {calculator.Add(num1, num2)}");
                break;
            case 2:
                Console.WriteLine($"\n\nSubtract( {num1} - {num2} ) = {calculator.Subtract(num1, num2)}");
                break;
            case 3:
                Console.WriteLine($"\n\nMultiply( {num1} * {num2} ) = {calculator.Multiply(num1, num2)}");
                break;
            case 4:
                Console.WriteLine($"\n\nDivide( {num1} / {num2} ) = {calculator.Divide(num1, num2)}");
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;

        }

    } catch (FormatException fe)
    {
        Console.WriteLine($"Format Exception: {fe.Message}");
    }
    catch (DivideByZeroException de)
    {
        Console.WriteLine($"Divide by zero exception: {de.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }
    finally
    {
        Console.Write("\n\nDo you want to make another operation? (Y/N): ");
    }
} while (Console.ReadLine().ToUpper() == "Y");

int CheckOption(int optionToCheck)
{
    if(optionToCheck < 1 || optionToCheck > 4)
    {
        Console.Write("Please type a valid option: ");
        optionToCheck = CheckOption(Convert.ToInt32(Console.ReadLine()));
    }

    return optionToCheck;
}