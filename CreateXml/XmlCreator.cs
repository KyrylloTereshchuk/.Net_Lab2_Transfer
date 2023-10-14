using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab2
{
    public class XmlCreator
    {
        private readonly Collections _collections;
        public XmlCreator(Collections c)
        {
            _collections = c;
        }

        private string filePath = "D:\\XmlLibrary2\\";


        public void WriteEmployees(XmlWriterSettings settings)
        {


            using (XmlWriter writer = XmlWriter.Create(filePath + "employees.xml", settings))
            {

                writer.WriteStartElement("employees");
                foreach (Employees employee in _collections.Employees)
                {
                    writer.WriteStartElement("employee");
                    writer.WriteElementString("LastName", employee.LastName);
                    writer.WriteElementString("FirstName", employee.FirstName);
                    writer.WriteElementString("MiddleName", employee.MiddleName);
                    writer.WriteElementString("DateOfBirth", employee.DateOfBirth.ToString());
                    writer.WriteElementString("EmployeeId", employee.EmployeeId.ToString());
                    writer.WriteElementString("RollNumber", employee.RollNumber);
                    writer.WriteElementString("Education", employee.Education);
                    writer.WriteElementString("Specialty", employee.Specialty);
                    writer.WriteElementString("HireDate", employee.HireDate.ToString());


                    writer.WriteEndElement();
                }
                writer.WriteEndDocument();
            }
        }


        public void WriteEmployeesWithoutEmployement(XmlWriterSettings settings)
        {


            using (XmlWriter writer = XmlWriter.Create(filePath + "employeesWithoutEmployement.xml", settings))
            {

                writer.WriteStartElement("employees");
                foreach (Employees employee in _collections.EmployeesWithoutEmployement)
                {
                    writer.WriteStartElement("employee");
                    writer.WriteElementString("LastName", employee.LastName);
                    writer.WriteElementString("FirstName", employee.FirstName);
                    writer.WriteElementString("MiddleName", employee.MiddleName);
                    writer.WriteElementString("DateOfBirth", employee.DateOfBirth.ToString());
                    writer.WriteElementString("EmployeeId", employee.EmployeeId.ToString());
                    writer.WriteElementString("RollNumber", employee.RollNumber);
                    writer.WriteElementString("Education", employee.Education);
                    writer.WriteElementString("Specialty", employee.Specialty);
                    writer.WriteElementString("HireDate", employee.HireDate.ToString());


                    writer.WriteEndElement();
                }
                writer.WriteEndDocument();
            }
        }


        public void WriteEmployeesSalaries(XmlWriterSettings settings)
        {


            using (XmlWriter writer = XmlWriter.Create(filePath + "employeesSalaries.xml", settings))
            {
                writer.WriteStartElement("employeesSalaries");
                foreach (EmployeesSalaries employeesSalaries in _collections.EmployeesSalaries)
                {
                    writer.WriteStartElement("employeeSalaries");
                    writer.WriteElementString("EmployeeId", employeesSalaries.EmployeeId.ToString());
                    writer.WriteElementString("SalaryId", employeesSalaries.SalaryId.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }


        public void WriteSalary(XmlWriterSettings settings)
        {


            using (XmlWriter writer = XmlWriter.Create(filePath + "salary.xml", settings))
            {
                writer.WriteStartElement("salaries");
                foreach (Salary salary in _collections.Salary)
                {
                    writer.WriteStartElement("salary");
                    writer.WriteElementString("EmployeeId", salary.EmployeeId.ToString());

                    foreach (decimal sal in salary.MonthlySalaries) 
                    {
                        writer.WriteElementString("value", sal.ToString());
                    }

                    
                    
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }


        public void WriteCompany(XmlWriterSettings settings)
        {


            using (XmlWriter writer = XmlWriter.Create(filePath + "company.xml", settings))
            {
                writer.WriteStartElement("companies");
                foreach (Company company in _collections.Companies)
                {
                    writer.WriteStartElement("company");
                    writer.WriteElementString("Name", company.Name);

                    foreach (Employees employee in company.Employees)
                    {
                        writer.WriteStartElement("employee");
                        writer.WriteElementString("LastName", employee.LastName);
                        writer.WriteElementString("FirstName", employee.FirstName);
                        writer.WriteElementString("MiddleName", employee.MiddleName);
                        writer.WriteElementString("DateOfBirth", employee.DateOfBirth.ToString());
                        writer.WriteElementString("EmployeeId", employee.EmployeeId.ToString());
                        writer.WriteElementString("RollNumber", employee.RollNumber);
                        writer.WriteElementString("Education", employee.Education);
                        writer.WriteElementString("Specialty", employee.Specialty);
                        writer.WriteElementString("HireDate", employee.HireDate.ToString());
                    }

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }

    }
}
