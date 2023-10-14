using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable, XmlRoot(EmployeesName.Root)]
    public class Employees
    {
        [XmlAttribute(AttributeName = EmployeesName.LastName)]
        public string LastName { get; set; }

        [XmlAttribute(AttributeName = EmployeesName.FirstName)]
        public string FirstName { get; set; }

        [XmlAttribute(AttributeName = EmployeesName.MiddleName)]
        public string MiddleName { get; set; }

        [XmlAttribute(AttributeName = EmployeesName.DateOfBirth)]
        public DateTime? DateOfBirth { get; set; }

        [XmlAttribute(AttributeName = EmployeesName.EmployeeId)]
        public int EmployeeId { get; set; }

        [XmlAttribute(AttributeName = EmployeesName.RollNumber)]
        public string RollNumber { get; set; }

        [XmlAttribute(AttributeName = EmployeesName.Education)]
        public string Education { get; set; }

        [XmlAttribute(AttributeName = EmployeesName.Specialty)]
        public string Specialty { get; set; }

        [XmlAttribute(AttributeName = EmployeesName.HireDate)]
        public DateTime? HireDate { get; set; }

        public Employees(string lastName, string firstName, string middleName, 
                        int employeeId, string rollNumber, string education)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            EmployeeId = employeeId;
            RollNumber = rollNumber;
            Education = education;
        }

        public Employees( string cardId)
        {
            RollNumber = cardId;
        }
        public Employees()
        {
        }

        public override string ToString()
        {
            return string.Format(
                $"Last name: {this.LastName};" +
                $" First name: {this.FirstName};" +
                $" Middle name: {this.MiddleName}\n" +
                $"Date of birthday: {this.DateOfBirth};\n" +
                $" Employee Id: {this.EmployeeId};" +
                $" Card Id: {this.RollNumber};\n" +
                $" Education: {this.Education};" +
                $" Specialty: {this.Specialty};\n" +
                $" Hire date: {this.HireDate};\n"
                );
        }
    }
}
