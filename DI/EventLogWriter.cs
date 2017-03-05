using System;

namespace DI
{
    class EventLogWriter : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            // Write to event log here
        }
    }

    class EmailSender : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            // Send email from here
        }
    }

    class SMSSender : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            // Send SMS from here
        }
    }
}
