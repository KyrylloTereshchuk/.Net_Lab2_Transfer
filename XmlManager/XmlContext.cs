using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab2
{
    public class XmlContext
    {
        private string filePath = "D:\\XmlLibrary\\";

        public Dictionary<string, XDocument> files;

        public XmlContext(List<string> list)
        {
            files = new Dictionary<string, XDocument>();


            for (int i = 0; i < list.Count; i++)
            {
                XDocument xmlDoc = XDocument.Load(filePath + list[i] + ".xml");
                files.Add(list[i], xmlDoc);
            }

        }

    }
}
