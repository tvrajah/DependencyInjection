using System;

namespace DI
{
    class EventLogWriter : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine("Event log writer fired");
        }
    }

    class EmailSender : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine("Email sender fired");
        }
    }

    class SMSSender : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine("SMSSender fired");
        }
    }
}
