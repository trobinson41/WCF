using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFLibrary;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(MathService));
            sh.Open();
            Console.WriteLine("Server running...");

            Console.ReadLine();
            sh.Close();
        }
    }
}
