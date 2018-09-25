using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name = "IEmpService", Namespace = "http://www.trobinsoin41.com/wcf")]
    //[ServiceKnownType(typeof(DevelopmentEmployee))]
    //[ServiceKnownType(typeof(TrainingEmployee))]
    public interface IEmpService
    {
        [OperationContract]
        void InsertEmp(Employee e);

        [OperationContract]
        void UpdateEmp(Employee e);

        [OperationContract]
        void DeleteEmp(Employee e);

        [OperationContract]
        Employee[] GetEmployees();

        [OperationContract]
        Employee GetEmpDetails(int empId);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
    [DataContract]
    //[KnownType(typeof(DevelopmentEmployee))]
    //[KnownType(typeof(TrainingEmployee))]
    public class Employee
    {
        [DataMember]
        public int EmpId { get; set; }

        [DataMember]
        public string EmpName { get; set; }

        [DataMember]
        public decimal EmpSalary { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime DateOfBirth { get; set; }
    }

    [DataContract]
    public class DevelopmentEmployee : Employee
    {
        [DataMember()]
        public string ProgrammingLanguage { get; set; }
    }

    [DataContract]
    public class TrainingEmployee : Employee
    {
        [DataMember()]
        public string Subject { get; set; }
    }
}
