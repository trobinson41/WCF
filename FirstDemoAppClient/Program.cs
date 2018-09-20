using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoAppClient
{
    class Program
    {
        private static string PrintComplex(localhost.Complex c)
        {
            string result;
            if (c.Imag >= 0)
                result = $"{c.Real}+{c.Imag}i";
            else
                result = $"{c.Real}{c.Imag}i";
            return result;
        }
        static void Main(string[] args)
        {
            localhost.MathServiceClient mc = new localhost.MathServiceClient();
            Console.WriteLine("10 + 5 = " + mc.Add(10, 5));
            localhost.Complex c1 = new localhost.Complex();
            c1.Real = 10;
            c1.Imag = 5;
            localhost.Complex c2 = new localhost.Complex();
            c2.Real = 5;
            c2.Imag = -7;
            Console.WriteLine($"{PrintComplex(c1)} + {PrintComplex(c2)} = {PrintComplex(mc.AddComplex(c1, c2))}");

            Console.ReadLine();
        }
    }
}
