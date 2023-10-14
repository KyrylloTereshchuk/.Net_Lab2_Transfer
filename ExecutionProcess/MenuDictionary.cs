using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class MenuDictionary
    {
        private readonly ICommands _Commands;
        private readonly ICommandXmlWrite _CommandXmlWrite;
        private readonly IXmlConcat _XmlConcat;
        private readonly IPrintXml _LoadXml;
        public MenuDictionary(ICommands command, ICommandXmlWrite commandXmlWrite, IXmlConcat xmlConcat, IPrintXml loadXml)
        {
            _Commands = command;
            _CommandXmlWrite = commandXmlWrite;
            _XmlConcat = xmlConcat;
            _LoadXml = loadXml;
        }

        public Dictionary<Enums.QueriesNames, Action> MenuCreate()
        {
            var menuChoices = new Dictionary<Enums.QueriesNames, Action>()
               {
                       [ Enums.QueriesNames.Exit]=  _Commands.Exit,

                       [Enums.QueriesNames.WriteEmployees] = _CommandXmlWrite.WriteXmlEmployees,
                       [Enums.QueriesNames.WriteCompany] = _CommandXmlWrite.WriteXmlCompany,
                       [Enums.QueriesNames.WriteEmployeesSalaries] = _CommandXmlWrite.WriteXmlEmployeesSalaries,
                       [Enums.QueriesNames.WriteSalary] = _CommandXmlWrite.WriteXmlSalary,

                       [Enums.QueriesNames.ConcatXmlFiles]=  _XmlConcat.ConcatXmlFiles ,

                       [Enums.QueriesNames.LoadXmlFile]= _LoadXml.LoadXmlFile ,

                       [Enums.QueriesNames.GetEmployees] =  _Commands.Command1 ,
                       [Enums.QueriesNames.GetCompaniesName] =  _Commands.Command2 ,
                       [Enums.QueriesNames.GetAllEmployees] =  _Commands.Command3 ,
                       [Enums.QueriesNames.GetCountEmployeesWithEducation] =  _Commands.Command4 ,
                       [Enums.QueriesNames.GetSortedEmployees] = _Commands.Command5 ,
                       [Enums.QueriesNames.GetCompaniesStartWith] =  _Commands.Command6 ,
                       [Enums.QueriesNames.GetEmployeesIdBiggerThan] = _Commands.Command7 ,
                       [Enums.QueriesNames.GetEmployeesSalariesId] =  _Commands.Command8 ,
                       [Enums.QueriesNames.GetSpecificRollNumbers] =  _Commands.Command9 ,
                       [Enums.QueriesNames.GetYoungestEmployee] =  _Commands.Command10 ,
                       [Enums.QueriesNames.GetEmployeesFromTo] =  _Commands.Command11 ,
                       [Enums.QueriesNames.GetEmployementEmployees] =  _Commands.Command12 ,
                       [Enums.QueriesNames.GetEmployeesArray] = _Commands.Command13 ,
                       [Enums.QueriesNames.GetAllRollNumbers] =  _Commands.Command14 ,
                       [Enums.QueriesNames.GetFirstEmployeeWithIdBiggerThan] =  _Commands.Command15 ,
                       [Enums.QueriesNames.GetIdByName] = _Commands.Command16,
            };
            return menuChoices;
        }
    }
}

