using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface ICollections
    {

        IEnumerable<Employees> Employees { get; }
        IEnumerable<Employees> EmployeesWithoutEmployement { get; }
        IEnumerable<Salary> Salary { get; }
        IEnumerable<EmployeesSalaries> EmployeesSalaries { get; }
        IEnumerable<Company> Companies { get; }
    }
}
