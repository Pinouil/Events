using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Subscriber
    {
        public void Subscribe(Publisher publishit)
        {
            publishit.OnTimer += publishit_OnTimer;
        }

        private static void publishit_OnTimer(object sender, DateEventArgs dateArgs)
        {
            Console.WriteLine(dateArgs.Date);
        }

    }
}
