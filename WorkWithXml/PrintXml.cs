using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab2
{
    public class PrintXml : IPrintXml
    {
        private string filePath = "D:\\XmlLibrary\\";

        public void LoadXmlFile()
        {
            string fileName;
            Console.WriteLine("Enter xml file name:");
            fileName = Console.ReadLine();
            string fullPath = Path.Combine(filePath, fileName + ".xml");

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fullPath);

                XmlSerializer serializer = new XmlSerializer(typeof(XmlDocument));

                using (StringWriter stringWriter = new StringWriter())
                {
                    using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter))
                    {
                        xmlTextWriter.Formatting = Formatting.Indented;
                        serializer.Serialize(xmlTextWriter, xmlDocument);
                        Console.WriteLine(stringWriter.ToString());
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(" File not found");
            }
        }





    }
}
