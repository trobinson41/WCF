using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFLibrary;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(Service1));
            System.ServiceModel.Description.ServiceEndpoint sep = sh.AddServiceEndpoint(
                typeof(IService1),
                new WSHttpBinding(),
                "");

            sh.Open();
            Console.WriteLine("Service running...");

            Console.ReadLine();
            sh.Close();
        }
    }
}
