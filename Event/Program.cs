using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscribit = new Subscriber();
            Publisher publishit = new Publisher();

            subscribit.Subscribe(publishit);
            publishit.Run();
        }
    }
}
