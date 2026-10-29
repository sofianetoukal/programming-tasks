
using System;

Console.WriteLine("Temperature Converter");

Console.Write("Choose c or f: ");
string choice = Console.ReadLine() ?? "";

Console.Write("Enter temperature: ");
double temp = Convert.ToDouble(Console.ReadLine());

if (choice == "c")
{
    double result = temp * 1.8 + 32;
    Console.WriteLine("Result: " + result + " F");
}
else if (choice == "f")
{
    double result = (temp - 32) / 1.8;
    Console.WriteLine("Result: " + result + " C");
}
else
{
    Console.WriteLine("Wrong choice");
}
