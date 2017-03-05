namespace DI
{
    class AppPoolWatcher
    {
        // Handle to EventLog writer to write to the logs
        ICall call = null;
        IEmail email = null;
        ISMS sms = null;

        public AppPoolWatcher(ICall call, IEmail email, ISMS sms)
        {
            this.call = call;
            this.email = email;
            this.sms = sms;
        }

        // This function will be called when the app pool has problem
        public void Notify(string message)
        {
            if (call != null)
            {
                call.Call(message);
            }
            if (email != null)
            {
                email.Email(message);
            }
            if (sms != null)
            {
                sms.Sms(message);
            }
        }
    }
}
