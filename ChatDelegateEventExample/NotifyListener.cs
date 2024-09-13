using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDelegateEventExample
{
    internal class NotifyListener
    {
        public void OnProcessCompleted(object sender, EventArgs args)
        {
            Console.WriteLine("Everyone related to this issue has been notified successfully...");
        }
    }
}
