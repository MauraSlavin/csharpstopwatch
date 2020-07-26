using System;

namespace stopwatch.StartLap
{
    public class StartClock
    {
        public static DateTime startTime;
        
        public static DateTime GetNow()
        {
            return startTime = DateTime.Now;
        }
    }
}