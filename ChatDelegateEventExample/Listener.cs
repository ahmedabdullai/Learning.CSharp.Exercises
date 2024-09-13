using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDelegateEventExample
{
    public class Listener
    {
        // This method matches the delegate signature and will handle the event
        public void OnProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Listener: The process has been completed.");
        }
    }
}
