using System;

class Program
{
    static string ToTime(int seconds)
    {
        if (seconds < 0)
        {
            throw new ArgumentException("Input must be a non-negative integer.");
        }

        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = seconds % 60;

        string formattedHours = hours.ToString().PadLeft(2, '0');
        string formattedMinutes = minutes.ToString().PadLeft(2, '0');
        string formattedSeconds = remainingSeconds.ToString().PadLeft(2, '0');

        return $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";
    }

    static void Main()
    {
        int seconds = 70;
        Console.WriteLine(ToTime(seconds));
    }
}
