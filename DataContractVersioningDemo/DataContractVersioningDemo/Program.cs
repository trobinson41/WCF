using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataContractVersioningDemo
{
    [DataContract(Name = "Person", Namespace = "http://www.trobinson41.com/wcfdemo")]
    public class Person : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataObject_value;
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataObject_value;
            }

            set
            {
                extensionDataObject_value = value;
            }
        }

        [DataMember]
        public string Name;
    }

    [DataContract(Name = "Person", Namespace = "http://www.trobinson41.com/wcfdemo")]
    public class PersonVersion2 : IExtensibleDataObject
    {
        [DataMember(Order = 2)]
        public int ID;

        [DataMember]
        public string Name;

        private ExtensionDataObject extensionDataObject_value;
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataObject_value;
            }

            set
            {
                extensionDataObject_value = value;
            }
        }
    }

    public interface IPersonService
    {
        PersonVersion2 GetPersonDetails(int id);
        void UpdatePerson(PersonVersion2 p);
    }

    public class PersonService : IPersonService
    {
        public PersonVersion2 GetPersonDetails(int id)
        {
            return new PersonVersion2() { Name = "Elizabeth", ID = 1 };
        }

        public void UpdatePerson(PersonVersion2 p)
        {
            Console.WriteLine("Person Name saved: " + p.Name);
            Console.WriteLine("Person ID saved: " + p.ID);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteVersion2("V2.xml");
            ReadVersion2AsVersion1AndModifyAndSave("V2.xml");
            ReadVersion2("V2.xml");

            Console.ReadLine();
        }

        static void WriteVersion2(string path)
        {
            Console.WriteLine("Creating a version 2 object");
            PersonVersion2 p2 = new PersonVersion2();
            p2.Name = "Elizabeth";
            p2.ID = 2006;

            Console.WriteLine("Object data includes an ID");
            Console.WriteLine($"\tName: {p2.Name}");
            Console.WriteLine($"\tID: {p2.ID}");

            DataContractSerializer ser = new DataContractSerializer(typeof(PersonVersion2));

            Console.WriteLine("\nSerializing the v2 object to a file.\n\n");
            FileStream fs = new FileStream(path, FileMode.Create);
            ser.WriteObject(fs, p2);
            fs.Close();
        }

        static void ReadVersion2AsVersion1AndModifyAndSave(string path)
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(Person));

            FileStream fs = new FileStream(path, FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            Console.WriteLine("Deserializing v2 data to v1 object.\n\n");

            Person p1 = (Person)ser.ReadObject(reader, false);

            Console.WriteLine("V1 data has only a Name field.");
            Console.WriteLine("But the v2 data is stored in the ExtensionData property.\n\n");
            Console.WriteLine($"\tName: {p1.Name}");

            fs.Close();

            p1.Name = "John";
            Console.WriteLine("Changed the Name value to 'John' and reserializing the object to version 2\n\n");

            fs = new FileStream(path, FileMode.Create);
            ser.WriteObject(fs, p1);
            fs.Close();
        }

        public static void ReadVersion2(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            DataContractSerializer ser = new DataContractSerializer(typeof(PersonVersion2));

            Console.WriteLine("Deserializing new data to version 2\n\n");
            PersonVersion2 p2 = (PersonVersion2)ser.ReadObject(fs);
            fs.Close();

            Console.WriteLine("The data includes the old ID field value.\n");
            Console.WriteLine($"\t(New) Name: {p2.Name}");
            Console.WriteLine($"\tID: {p2.ID}\n\n");
        }
    }
}
