namespace DI
{
    class AppPoolWatcher
    {
        // Handle to EventLog writer to write to the logs
        INofificationAction action = null;

        public AppPoolWatcher(INofificationAction concreteImplementation)
        {
            this.action = concreteImplementation;
        }

        // This function will be called when the app pool has problem
        public void Notify(string message)
        {
            if (action == null)
            {
                // Here we will map the abstraction i.e. interface to concrete class 
            }
            action.ActOnNotification(message);
        }
    }
}
