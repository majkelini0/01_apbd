// See https://aka.ms/new-console-template for more information

using System.Security.AccessControl;

Console.WriteLine("Hello, World!");

Console.WriteLine("Pierwszy commit");

Console.WriteLine("Drugi commit");

Console.WriteLine("Trzeci commit");

static double GetAverage(int[] numbers)
{
    double resuuult = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        resuuult += numbers[i];
    }

    return resuuult / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static double GetMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
    }
    return max;
}

Console.WriteLine( GetMax(numbers) );