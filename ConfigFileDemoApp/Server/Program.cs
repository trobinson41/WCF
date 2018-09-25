using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFLibrary;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(Service1));
            Binding binding = new WSHttpBinding();
            System.ServiceModel.Description.ServiceEndpoint sep = sh.AddServiceEndpoint(
                typeof(IService1),
                binding,
                "");
            PrintBindingProperties(binding);

            //To get reference to binding mentioned in app.config file
            binding = sh.Description.Endpoints[0].Binding;
            PrintBindingProperties(binding);

            sh.Open();
            Console.WriteLine("Service running...");

            Console.ReadLine();
            sh.Close();
        }

        static void PrintBindingProperties(Binding binding)
        {
            Console.WriteLine("Name: " + binding.Name);
            Console.WriteLine("MessageVersion: " + binding.MessageVersion);
            Console.WriteLine("Namespace: " + binding.Namespace);
            Console.WriteLine("OpenTimeout: " + binding.OpenTimeout);
            Console.WriteLine("CloseTimeout: " + binding.CloseTimeout);
            Console.WriteLine("SendTimeout: " + binding.SendTimeout);
            Console.WriteLine("ReceiveTimeout: " + binding.ReceiveTimeout);
            Console.WriteLine("Scheme: " + binding.Scheme);
            Console.WriteLine();
        }
    }
}
