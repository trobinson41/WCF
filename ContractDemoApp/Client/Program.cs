using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.EmpServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpServiceClient sc = new EmpServiceClient();
            //sc.InsertEmp("Sandeep", 10000);
            sc.UpdateEmp(new DevelopmentEmployee() { EmpId = 1, EmpName = "E1", EmpSalary = 10000, DateOfBirth = new DateTime(2017, 4, 2), ProgrammingLanguage = "DotNet" });
            sc.Close();
        }
    }
}
