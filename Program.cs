using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main()
        {
            Collections Collections = new();

            XmlCreatorDesign xmlCreatorDesign = new();

            XmlConcat xmlConcat = new();

            PrintXml loadXml = new();
           
            List<string> list = new List<string> { "employees", "salary", "company", "employeesSalaries", "employeesWithoutEmployement", "Collections" };

            XmlContext xmlContext = new(list);

            XMLValidator xmlValidator = new XMLValidator(xmlContext);

            XmlWriters xmlWriters = new(xmlContext, xmlValidator, xmlConcat);

            XmlReaderValidator xmlReaderValidator = new XmlReaderValidator(xmlContext);

            IQueries querys = new Queries(xmlContext);

            Commands commands = new Commands(querys);


            ///////////////////////////
            ///
            XmlCreator xmlCreator = new(Collections);
            XmlManager xmlManager = new(xmlCreatorDesign.GetSettings(), xmlCreator);
            xmlManager.CreatXmlFiles();
            ///////////////////////////
            ///
            

            ICommandXmlWrite commandXmlWrite = new CommandXmlWrite(xmlCreatorDesign.GetSettings(), xmlWriters);

            MenuDictionary dictionary = new MenuDictionary(commands, commandXmlWrite, xmlConcat, loadXml);

            ExecutionProcess executionProcess = new ExecutionProcess(dictionary, xmlReaderValidator);

            executionProcess.Process();

            

        }

    }

}