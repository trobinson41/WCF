using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ServiceModel;

namespace WCFWindowsServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            ServiceHost sh;
            sh = new ServiceHost(typeof(WCFLibrary.DemoService));
            sh.Open();
            Console.WriteLine("Server Started");
            Console.WriteLine("Press any key to close the Server");
            Console.ReadKey(true);
        }
    }
}
