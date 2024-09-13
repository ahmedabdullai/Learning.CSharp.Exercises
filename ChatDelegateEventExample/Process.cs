using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDelegateEventExample
{
    public class Process
    {
        // 1. Declare the delegate (if using non-generic pattern)
        public delegate void ProcessCompletedEventHandler(object sender, EventArgs e);

        // 2. Declare the event using the delegate
        public event ProcessCompletedEventHandler ProcessCompleted;

        // Alternatively, you can use the built-in EventHandler
        // public event EventHandler ProcessCompleted;

        // 3. Method to start the process
        public void StartProcess()
        {
            Console.WriteLine("Process started...");

            // Simulate some work with a delay
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Process finished!");

            // 4. Raise the event after process completion
            OnProcessCompleted();
        }

        // 5. Raise the event by calling the event handler
        protected virtual void OnProcessCompleted()
        {
            // Check if there are any subscribers, and if so, invoke the event
            ProcessCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
