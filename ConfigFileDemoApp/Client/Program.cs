using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.Service1Client s = new localhost.Service1Client();
            Console.WriteLine(s.GetData(10));
            localhost.CompositeType c1 = new localhost.CompositeType();
            c1.BoolValue = false;
            c1.StringValue = "test";
            var c2 = s.GetDataUsingDataContract(c1);
            Console.WriteLine(c2.BoolValue + ", " + c2.StringValue);

            Console.ReadLine();

        }
    }
}
