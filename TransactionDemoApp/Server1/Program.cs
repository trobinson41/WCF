using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Server1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(AccountLibrary.AccoutService));
            sh.Open();
            Console.WriteLine("Service Started");
            Console.WriteLine("Press any key to stop the service");
            Console.ReadKey();
            Console.WriteLine("Service Stopped");
        }
    }
}
