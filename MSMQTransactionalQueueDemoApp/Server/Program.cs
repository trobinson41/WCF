using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using System.ServiceModel;
using System.Messaging;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string queue = ".\\private$\\DemoTx";
            if (!MessageQueue.Exists(queue))
                MessageQueue.Create(queue);
            ServiceHost sh = new ServiceHost(typeof(Service1));
            sh.Open();
            Console.WriteLine("Server running...");

            Console.ReadKey();
        }
    }
}
