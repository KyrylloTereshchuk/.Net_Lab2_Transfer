using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab2
{
    public class XmlManager
    {
        private readonly XmlWriterSettings settings;
        private readonly XmlCreator xmlCreator;
        private readonly XmlWriters xmlWriters;

        public XmlManager(XmlWriterSettings settings, XmlCreator xmlCreator)
        {
            this.settings = settings;
            this.xmlCreator = xmlCreator;
        }


        public void CreatXmlFiles()
        {

            xmlCreator.WriteEmployees(settings);

            xmlCreator.WriteEmployeesSalaries(settings);

            xmlCreator.WriteSalary(settings);

            xmlCreator.WriteCompany(settings);

            xmlCreator.WriteEmployeesWithoutEmployement(settings);
        }
      
    }
}
