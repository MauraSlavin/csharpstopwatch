using System;
using stopwatch.StartLap;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'Start' to begin.  Then enter 'Lap' to get timestamps and elapsed times.  Enter 'End' to stop Stopwatch.");
            
            // declare variables
            var entry = "";
            DateTime lapTime;
            TimeSpan elapsed;

            // Start the clock
            entry = Console.ReadLine();
            entry = entry.ToLower().Replace(" ", String.Empty);
            while (entry != "start")
            {
                Console.WriteLine(entry + " is invalid.  Enter 'Start' to begin:");
                entry = Console.ReadLine();
            }
            var startAt = StartClock.GetNow();
            Console.WriteLine("Start at: " + startAt);

            // Read next user entry until "end" is entered
            while (entry != "end")
            {
                entry = Console.ReadLine();
                entry = entry.ToLower().Replace(" ", String.Empty);
                if (entry == "lap")
                {
                    lapTime = LapClock.GetLapTime();
                    elapsed = LapClock.GetElapsed(startAt, lapTime);
                    Console.WriteLine("Lap at: " + lapTime + ";  Elapsed time: " + elapsed + ".");
                }
                else if (entry != "end")
                {
                    Console.WriteLine("'" + entry + "' entered.  Please enter 'Lap' for current time, or 'End' to stop Stopwatch.");
                };
            }

            // One last time at end
            lapTime = LapClock.GetLapTime();
            elapsed = LapClock.GetElapsed(startAt, lapTime);
            Console.WriteLine("Stop at: " + lapTime + ";  Elapsed time: " + elapsed + ".");
    
        }
    }
}
