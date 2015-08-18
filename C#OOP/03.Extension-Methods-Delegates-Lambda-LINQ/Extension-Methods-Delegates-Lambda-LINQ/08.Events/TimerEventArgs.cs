using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    public class TimerEventArgs : EventArgs
    {
        private DateTime timerTime;

        public TimerEventArgs(DateTime time)
        {
            this.timerTime = time;
        }

        public DateTime TimerTime
        {
            get
            {
                return timerTime;
            }
        }

    }
}
