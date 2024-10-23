// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first number: ");

double firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter:\n+ for adding\n- for subtracting\n* for multiplying\n/ for division");

char operation = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.WriteLine("Enter second number: ");
double secondNum = Convert.ToDouble(Console.ReadLine());

double result = 0;

switch (operation)
{
    case '+':
        result = firstNum + secondNum;
        break;
    case '-':
        result = firstNum - secondNum;
        break;
    case '*':
        result = firstNum * secondNum;
        break;
    case '/':
        if (secondNum != 0)
            result = firstNum / secondNum;
        else
        {
            Console.WriteLine("Cannot divide by zero!");
            return;
        }
        break;
    default:
        Console.WriteLine("Invalid operation");
        return;
}
Console.WriteLine($"Result: {result}");
