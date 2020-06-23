using System;
using System.Runtime.CompilerServices;
using System.Timers;

namespace welcash_web.Core
{
    public class Runner
    {
        private static Timer aTimer;

        /// <summary>
        /// <see cref="!:https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer.interval?view=netcore-3.1"/>
        /// </summary>
        public Runner()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 2000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }
     
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
           new Request().sendInfo();
        }
    }
}