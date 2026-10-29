
using System;

Console.WriteLine("Simple Calculator");

Console.Write("First number: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Second number: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Choose +, -, * or /: ");
string op = Console.ReadLine();

if (op == "+")
{
    Console.WriteLine("Result: " + (a + b));
}
else if (op == "-")
{
    Console.WriteLine("Result: " + (a - b));
}
else if (op == "*")
{
    Console.WriteLine("Result: " + (a * b));
}
else if (op == "/")
{
    if (b == 0)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    else
    {
        Console.WriteLine("Result: " + (a / b));
    }
}
else
{
    Console.WriteLine("Wrong operation");
}
