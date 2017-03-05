using System;

namespace DI
{
    class PhoneCaller : ICall
    {
        public void Call(string message)
        {
            Console.WriteLine("Call function fired");
            Console.WriteLine("Calling operator .........." + message);
            Console.WriteLine("Successfully called the operator");
            Console.WriteLine();
        }
    }

    class EmailSender : IEmail
    {
        public void Email(string message)
        {
            Console.WriteLine("Email function fired");
            Console.WriteLine("Sending email ......." + message);
            Console.WriteLine("Successfully emailed the operator");
            Console.WriteLine();
        }
    }

    class SMSSender : ISMS
    {
        public void Sms(string message)
        {
            Console.WriteLine("SMS function fired");
            Console.WriteLine("Sending SMS ......." + message);
            Console.WriteLine("A SMS has successfully been sent to the operator");
            Console.WriteLine();
        }
    }
}
