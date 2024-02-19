using System;

class TemperatureTracker
{
    private const int DaysInWeek = 7;
    private double[] temperatures;

    public TemperatureTracker()
    {
        temperatures = new double[DaysInWeek];
    }

    public void InputTemperatures()
    {
        for (int i = 0; i < DaysInWeek; i++)
        {
            string input;
            do
            {
                Console.WriteLine($"Enter temperature for Day {i + 1} (in °C):");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out temperatures[i]) || temperatures[i] < -100 || temperatures[i] > 100); // Added temperature range validation
        }
    }

    public void DisplayReport()
    {
        if (temperatures == null || temperatures.Length == 0)
        {
            Console.WriteLine("No temperature data available.");
            return;
        }

        double average = CalculateAverage();
        double highest = FindHighestTemperature();
        double lowest = FindLowestTemperature();

        Console.WriteLine("\nWeekly Temperature Report:");
        for (int i = 0; i < DaysInWeek; i++)
        {
            Console.WriteLine($"Day {i + 1}: {temperatures[i]:F2} °C");
        }

        Console.WriteLine($"\nAverage temperature: {average:F2} °C");
        Console.WriteLine($"Highest temperature: {highest:F2} °C");
        Console.WriteLine($"Lowest temperature: {lowest:F2} °C");
    }

    private double CalculateAverage()
    {
        double sum = 0;
        foreach (double temp in temperatures)
        {
            sum += temp;
        }
        return sum / DaysInWeek;
    }

    private double FindHighestTemperature()
    {
        double highest = temperatures[0];
        for (int i = 1; i < DaysInWeek; i++)
        {
            if (temperatures[i] > highest)
            {
                highest = temperatures[i];
            }
        }
        return highest;
    }

    private double FindLowestTemperature()
    {
        double lowest = temperatures[0];
        for (int i = 1; i < DaysInWeek; i++)
        {
            if (temperatures[i] < lowest)
            {
                lowest = temperatures[i];
            }
        }
        return lowest;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TemperatureTracker tracker = new TemperatureTracker();
        tracker.InputTemperatures();
        tracker.DisplayReport();
    }
}
