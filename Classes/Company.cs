using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable, XmlRoot(CompanyName.Root)]
    public class Company
    {
        [XmlAttribute(AttributeName = CompanyName.Name)]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = CompanyName.Employees)]
        public List<Employees>? Employees { get; set; }

        public Company(string name)
        {
            Name = name;
            Employees = new List<Employees>();
        }
        public Company()
        {
            Employees = new List<Employees>();
        }

    }
}
