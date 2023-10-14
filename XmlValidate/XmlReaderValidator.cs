using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Lab2
{
    public class XmlReaderValidator
    {
        private readonly XmlContext _xmlContext;
        private DateTime date;
        private int Id;
        private bool validate;

        public XmlReaderValidator(XmlContext xmlContext)
        {
            _xmlContext = xmlContext;
        }


        public bool ValidateXmlCollection(string filePath)
        {
            
            try
            {
                using (XmlReader reader = XmlReader.Create("D:\\XmlLibrary\\" + filePath + ".xml"))
                {
                    while (reader.Read())
                    {

                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.Name)
                            {
                                case "SalaryId":
                                    
                                    if (int.TryParse(reader.ReadElementContentAsString(), out Id))
                                    {
                                        validate = _xmlContext.files["employees"].Descendants("employee")
                                        .Any(employee => int.Parse(employee.Element("EmployeeId").Value) == Id);
                                        if (!validate)
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                    break;

                                case "EmployeeId":
                                    
                                    if (int.TryParse(reader.ReadElementContentAsString(), out Id))
                                    {
                                        validate = _xmlContext.files["employees"].Descendants("employee")
                                        .Any(employee => int.Parse(employee.Element("EmployeeId").Value) == Id);

                                        if (!validate)
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                    break;
                                case "value":
                                    int value;
                                    if (int.TryParse(reader.ReadElementContentAsString(), out value))
                                    {
                                        if (value > 1000000 || value < 0)
                                            return false;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                    break;
                                case "HireDate":
                                    if (DateTime.TryParse(reader.ReadElementContentAsString(), out date))
                                    {
                                        if (date < DateTime.Parse("1990-01-01"))
                                            return false;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                    break;

                                case "DateOfBirth":
                                    if (DateTime.TryParse(reader.ReadElementContentAsString(), out date))
                                    {
                                        if (date < DateTime.Parse("1950-01-01"))
                                            return false;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                    break;
                            }



                        }
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during XML validation: " + ex.Message);
                return false;
            }
        }


        











    }

}
