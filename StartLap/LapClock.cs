using System;

namespace stopwatch.StartLap
{
    public class LapClock
    {
        public static DateTime GetLapTime()
        {
            return DateTime.Now;
        }

        public static TimeSpan GetElapsed(DateTime startAt, DateTime lapAt)
        {
            return lapAt.Subtract(startAt);
        }


    }
}