using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;



namespace STEM_Application
{
    class TaskScheduler
    {
        private static System.Timers.Timer aTimer;

        public void runTask()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Time event elapsed at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }

       

    }
}
