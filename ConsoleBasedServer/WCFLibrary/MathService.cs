using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace WCFLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathService" in both code and config file together.
    public class MathService : IMathService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void ClientStopped(string name)
        {
            StreamWriter sw = new StreamWriter("ClientLog.txt", true);
            sw.WriteLine(name + " STOPPED at " + DateTime.Now);
            sw.Close();
        }

        public void ClientStarted(string name)
        {
            StreamWriter sw = new StreamWriter("ClientLog.txt", true);
            sw.WriteLine(name + " STARTED at " + DateTime.Now);
            sw.Close();
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
