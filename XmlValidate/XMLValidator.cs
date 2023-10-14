using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Lab2
{
    public class XMLValidator
    {

        private readonly XmlContext _xmlContext;
        private bool repeat = true;
        private string input;

        public XMLValidator(XmlContext xmlContext)
        {
            _xmlContext = xmlContext;
        }


        public Employees ValidateEmployee(Employees employee)
        {

            Console.WriteLine("Enter lastname:");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Enter firstname:");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Enter middlename:");
            employee.MiddleName = Console.ReadLine();

            Console.WriteLine("Enter date of birth:");
            employee.DateOfBirth = DateValidate();

            Console.WriteLine("Enter roll number:");
            employee.RollNumber = Console.ReadLine();

            Console.WriteLine("Enter education:");
            employee.Education = Console.ReadLine();

            Console.WriteLine("Enter specialty:");
            employee.Specialty = Console.ReadLine();

            Console.WriteLine("Enter hire birth:");
            employee.HireDate = DateValidate();

            return employee;
        }


        public EmployeesSalaries ValidateEmployeesSalaries(EmployeesSalaries employeesSalaries)
        {
            Console.WriteLine("Enter employees Id:");
            employeesSalaries.EmployeeId = EmployeeIdValidate();

            Console.WriteLine("Enter salaries Id:");
            employeesSalaries.SalaryId = SalaryIdValidate();


            return employeesSalaries;
        }


        public Salary ValidateSalary(Salary salary)
        {
            Console.WriteLine("Enter employees Id:");
            salary.EmployeeId = EmployeeIdValidate();

            return salary;
        }



        ////////////////////////
        ////////////////////////




        internal int IntValidate()
        {
            while (repeat)
            {
                Console.WriteLine("Enter value:");
                input = Console.ReadLine();

                if (int.TryParse(input, out int value) && value < 1000000)
                {
                    return value;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid value. Please enter a valid integer value.");
                }
            }

            return 0;
        }

        private DateTime DateValidate()
        {
            while (repeat)
            {
                Console.WriteLine("Enter date in the format YYYY-MM-DD:");
                input = Console.ReadLine();
                if (DateTime.TryParse(input, out DateTime date) && date > DateTime.Parse("1990-01-01"))
                {
                    return date;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date. Please enter a valid date in the format YYYY-MM-DD.");
                }
            }

            return DateTime.Now;
        }


        private int EmployeeIdValidate()
        {
            while (repeat)
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    bool containsEmployee = _xmlContext.files["employees"].Descendants("employee")
                    .Any(employee => int.Parse(employee.Element("EmployeeId").Value) == value);

                    if (containsEmployee)
                    {
                        return value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Employees with this Id doesn`t exist. Please enter a valid integer value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value. Please enter a valid integer value.");
                }
            }

            return 0;
        }


        private int SalaryIdValidate()
        {
            while (repeat)
            {
                Console.WriteLine("Enter value:");
                input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    bool containsSalary = _xmlContext.files["salary"].Descendants("salary")
                    .Any(employee => int.Parse(employee.Element("EmployeeId").Value) == value);

                    if (containsSalary)
                    {
                        return value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Salaries with this Id doesn`t exist. Please enter a valid integer value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value. Please enter a valid integer value.");
                }
            }

            return 0;
        }
    }
}
