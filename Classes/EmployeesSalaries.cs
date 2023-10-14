using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable, XmlRoot(EmployeesSalariesName.Root)]
    public class EmployeesSalaries
    {
        [XmlAttribute(AttributeName = EmployeesSalariesName.EmployeeId)]
        public int EmployeeId { get; set; }

        [XmlAttribute(AttributeName = EmployeesSalariesName.SalaryId)]
        public int SalaryId { get; set; }

        public EmployeesSalaries(int employeeId, int salaryId)
        {
            this.EmployeeId = employeeId;
            this.SalaryId = salaryId;
        }
        public EmployeesSalaries()
        {
        }

        public override string ToString()
        {
            return string.Format(
                $"Employee Id = {this.EmployeeId};" +
                $"Salary Id = {this.SalaryId}\n");
        }
    }
}
