// See https://aka.ms/new-console-template for more information

using System.Security.AccessControl;

Console.WriteLine("Hello, World!");

Console.WriteLine("Pierwszy commit");

Console.WriteLine("Drugi commit");

Console.WriteLine("Trzeci commit");

static double GetAverage(int[] numbers)
{
    double result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);