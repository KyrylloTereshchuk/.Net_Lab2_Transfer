using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab2
{
    public class XmlConcat : IXmlConcat
    {
        private string filePath = "D:\\XmlLibrary2\\";
        public void ConcatXmlFiles()
        {
            string[] fileNames = { filePath + "employees.xml", filePath + "company.xml", filePath + "salary.xml", 
                filePath + "employeesSalaries.xml"};

            XElement root = new XElement("Collections");

            foreach (string fileName in fileNames)
            {
                XDocument doc = XDocument.Load(fileName);

                root.Add(doc.Root.Elements());
            }

            XDocument concatDocument = new XDocument(root);

            concatDocument.Save(filePath + "Collections.xml");

            Console.WriteLine("Successfull");
        }
    }
}
