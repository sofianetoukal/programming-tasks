
using System;

Console.WriteLine("Student Grade Average");

Console.Write("How many grades? ");
int n = Convert.ToInt32(Console.ReadLine());
double total = 0;

if (n > 0)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("Enter grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());
        total = total + grade;
    }

    double average = total / n;
    Console.WriteLine("Average: " + average.ToString("F2"));

    if (average >= 3.0)
    {
        Console.WriteLine("The student passed.");
    }
    else
    {
        Console.WriteLine("The student failed.");
    }
}
else
{
    Console.WriteLine("Enter at least one grade.");
}

