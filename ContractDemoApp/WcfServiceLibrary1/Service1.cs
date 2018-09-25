using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmpService : IEmpService
    {
        public void DeleteEmp(Employee e)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmpDetails(int empId)
        {
            return new Employee() { EmpId = empId, EmpName = "E" + empId, EmpSalary = 1000 };
        }

        public Employee[] GetEmployees()
        {
            throw new NotImplementedException();
        }

        public void InsertEmp(Employee e)
        {
            if (e is TrainingEmployee)
            {
                Console.WriteLine("Emp inserted (Training) with the following details:");
                Console.WriteLine($"Name: {e.EmpName}, Salary: {e.EmpSalary}, DOB: {e.DateOfBirth.ToLongDateString()}, Subject: {((TrainingEmployee)e).Subject}");
            }
            else if (e is DevelopmentEmployee)
            {
                Console.WriteLine("Emp inserted (Development) with the following details:");
                Console.WriteLine($"Name: {e.EmpName}, Salary: {e.EmpSalary}, DOB: {e.DateOfBirth.ToLongDateString()}, Programming Language: {((DevelopmentEmployee)e).ProgrammingLanguage}");
            }
        }

        public void UpdateEmp(Employee e)
        {
            if (e is TrainingEmployee)
            {
                Console.WriteLine($"Emp with ID {e.EmpId} updated (Training) with the following details:");
                Console.WriteLine($"ID: {e.EmpId}, Name: {e.EmpName}, Salary: {e.EmpSalary}, DOB: {e.DateOfBirth.ToLongDateString()}, Subject: {((TrainingEmployee)e).Subject}");
            }
            else if (e is DevelopmentEmployee)
            {
                Console.WriteLine("Emp updated (Development) with the following details:");
                Console.WriteLine($"ID: {e.EmpId}, Name: {e.EmpName}, Salary: {e.EmpSalary}, DOB: {e.DateOfBirth.ToLongDateString()}, Programming Language: {((DevelopmentEmployee)e).ProgrammingLanguage}");
            }
        }
    }
}
