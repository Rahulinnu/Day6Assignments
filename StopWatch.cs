using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
namespace Day6Assignment
{
    public class StopWatch
    {
        public void TimeElapsed()
        {
            Stopwatch stopwatch = new Stopwatch();  
            stopwatch.Start(); 
            Thread.Sleep(10000);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("\nRunTime " + elapsedTime);
            Console.WriteLine("\nTime elapsed: {0}", stopwatch.Elapsed);
        }
    }
    
}
