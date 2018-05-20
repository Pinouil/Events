using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Event
{
    class Publisher
    {
        public event EventHandler<DateEventArgs> OnTimer;

        public void Run()
        {
            while (true)
            {

                Thread.Sleep(1000);
                if (OnTimer != null)
                {
                    DateEventArgs DateToSend = new DateEventArgs();
                    DateToSend.Date = DateTime.Now;
                    OnTimer(this, DateToSend);
                }
            }
        }
    }

    public class DateEventArgs : EventArgs
    {
        public DateTime Date { get; set; }
    }
}
