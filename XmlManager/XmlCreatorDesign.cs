using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab2
{
    public class XmlCreatorDesign
    {
        public XmlWriterSettings GetSettings()
        {
            Console.OutputEncoding = Encoding.UTF8;

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            return settings;
        }
    }
}
