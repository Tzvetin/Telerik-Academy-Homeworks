//Using delegates write a class Timer that can execute certain method at each t seconds.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _07.Timer
{
    public delegate void SimpleDelegate(int param);

    public class Timer
    {
        static Thread timerThread;

        static void PrintMethod(int interval)
        {
            Console.WriteLine("I was called by a delegate.");
            Console.WriteLine("I'm executed every {0} seconds! Timestamp: {1: HH:mm:ss}", interval, DateTime.Now);
        }

        static void StartTimer(int interval, SimpleDelegate method)
        {
            Console.WriteLine("Press any key to stop the timer\n");
            timerThread = new Thread(() =>
            {
                while (true)
                {
                    method(interval);
                    Thread.Sleep(interval * 1000);
                }
            });
            timerThread.Start();
        }

        public static void StopTimer()
        {
            timerThread.Abort();
        }

        static void Main(string[] args)
        {
            int interval = 2;
            SimpleDelegate method = new SimpleDelegate(PrintMethod);
            StartTimer(interval, method);
            while (!Console.KeyAvailable)
            {
            }
            StopTimer();
        }
    }
}
