using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTrening.Models
{
    class Events
    {
        public delegate void UpdateStatus(string status);

        public event UpdateStatus StatusUpdated;

        public void StartUpdatingStatus()
        {
            while (true)
            {
                var message = $"Status, ticks{DateTime.UtcNow.Ticks}";

                StatusUpdated?.Invoke(message);

            }
        }

        public class EventsSandbox
        {
            public void Test()
            {
                var events = new Events();
                events.StatusUpdated += DisplayStatus;
                events.StartUpdatingStatus();

            }

            public void DisplayStatus(string message)
            {
                Console.WriteLine(message); 
            }

        }


    }
}
