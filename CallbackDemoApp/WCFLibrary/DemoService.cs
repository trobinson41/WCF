using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLibrary
{
    [ServiceBehavior()]
    public class DemoService : IDemoService
    {
        public void SendEmailAndNotifyCompletion(string name, string toEmailId, string body)
        {
            Console.WriteLine("Now sending email");
            //simulate sending  of email by sleeping for 5 secs.
            System.Threading.Thread.Sleep(5000);
            //Callback client method.
            ICallbackService callback = OperationContext.Current.GetCallbackChannel<ICallbackService>();
            callback.OperationCompleted(string.Format("Hello {0}, Your email to {1} is sent", name, toEmailId)); ;
            Console.WriteLine("Email Sent");
        }      
     }
}
