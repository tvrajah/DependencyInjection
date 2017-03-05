using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace DI
{
    class Program
    {
        //https://www.codeproject.com/Articles/615139/An-Absolute-Beginners-Tutorial-on-Dependency-Inver

        static void Main(string[] args)
        {
            /*
             * WITHOUT IOC
            EventLogWriter writer = new EventLogWriter();
            AppPoolWatcher watcherWriter = new AppPoolWatcher(writer);
            watcherWriter.Notify("Sample message to event log.");

            EmailSender email = new EmailSender();
            AppPoolWatcher watcherEmail = new AppPoolWatcher(email);
            watcherEmail.Notify("Sample message to Email.");

            SMSSender sms = new SMSSender();
            AppPoolWatcher watcherSms = new AppPoolWatcher(sms);
            watcherSms.Notify("Sample message to SMS.");
            */

            /*
             * WITH IOC - Confuguration via code           
            var container = new UnityContainer();
            container.RegisterType<INofificationAction, EventLogWriter>();
            var watcherWriter = container.Resolve<AppPoolWatcher>();
            watcherWriter.Notify("Sample message to event log.");
            */

            /* 
             * WITH IOC - configuration via xml */
            IUnityContainer container = new UnityContainer().LoadConfiguration();
            var watcherWriter = container.Resolve<AppPoolWatcher>();
            watcherWriter.Notify("Sample message to event log.");
        }
    }
}
