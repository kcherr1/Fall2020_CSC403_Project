using System;
using System.Timers;

public class Demo
{
    private static Timer timer;

    public static void Main()
    {
        timer = new System.Timers.Timer();
        timer.Interval = 5000;

        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;

        Console.WriteLine("Press the Enter key to exit anytime... ");
        Console.ReadLine();
    }

    private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("Raised: {0}", e.SignalTime);
    }
}