using ChatDelegateEventExample;

// 6. Instantiate the event publisher
Process process = new Process();

// 7. Instantiate the event subscriber
Listener listener = new Listener();
NotifyListener notifyListener = new NotifyListener();

// 8. Subscribe to the event
process.ProcessCompleted += listener.OnProcessCompleted;
process.ProcessCompleted += notifyListener.OnProcessCompleted;

// 9. Start the process (this will raise the event)
process.StartProcess();